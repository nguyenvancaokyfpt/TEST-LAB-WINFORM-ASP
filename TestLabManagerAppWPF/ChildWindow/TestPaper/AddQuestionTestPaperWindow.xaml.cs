using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TestLabEntity.AutoDB;
using TestLabLibrary.Repository;
using TestLabManagerAppWPF.ChildWindow.Chapter;
using TestLabManagerAppWPF.ChildWindow.Course;

namespace TestLabManagerAppWPF.ChildWindow.TestPaper
{
    /// <summary>
    /// Interaction logic for AddQuestionTestPaperWindow.xaml
    /// </summary>
    public partial class AddQuestionTestPaperWindow : Window
    {
        List<TlQuestion> _selectedQuestions;
        List<TlQuestion> _questions;
        string _searchText = "";
        int _idCourseSelected = 2;
        int _idChapterSelected = 1;

        public List<TlQuestion> SelectedQuestions
        {
            get { return _selectedQuestions; }
            set { _selectedQuestions = value; }
        }

        public List<TlQuestion> Questions
        {
            get { return _questions; }
            set { _questions = value; }
        }

        public string SearchText
        {
            get { return _searchText; }
            set { _searchText = value; }
        }

        public int IdCourseSelected
        {
            get { return _idCourseSelected; }
            set { _idCourseSelected = value; }
        }

        public int IdChapterSelected
        {
            get { return _idChapterSelected; }
            set { _idChapterSelected = value; }
        }


        public AddQuestionTestPaperWindow(int idCourseSelected)
        {
            _idCourseSelected = idCourseSelected;
            InitializeComponent();
            LoadCourseFilter();
            LoadChapterFilter();
            LoadQuestions();
        }

        void LoadQuestions()
        {
            var questionRepo = MyService.serviceProvider.GetService<IQuestionRepository>();
            _questions = questionRepo.GetQuestions(0, 9999, IdCourseSelected, IdChapterSelected, SearchText);
            lvQuestions.ItemsSource = _questions;
        }

        public void LoadCourseFilter()
        {
            var questionRepo = MyService.serviceProvider.GetService<IQuestionRepository>();
            var c = questionRepo.GetCourseById(IdCourseSelected);
            var courses = new List<TlCourse>();
            courses.Add(c);
            if (courses.Count > 0)
            {
                IdCourseSelected = courses[0].Id;
                cmbCourse.ItemsSource = courses;
                cmbCourse.DisplayMemberPath = "CourseName";
                cmbCourse.SelectedValuePath = "Id";
                cmbCourse.SelectedIndex = 0;
            }
            else
            {
                cmbCourse.ItemsSource = null;
            }
        }

        public void LoadChapterFilter()
        {
            var questionRepo = MyService.serviceProvider.GetService<IQuestionRepository>();
            var chapters = questionRepo.GetChapters(0, 999, IdCourseSelected);
            if (chapters.Count > 0)
            {
                IdChapterSelected = chapters[0].Id;
                cmbChapter.ItemsSource = chapters;
                cmbChapter.DisplayMemberPath = "ChapterName";
                cmbChapter.SelectedValuePath = "Id";
            }
            else
            {
                cmbChapter.ItemsSource = null;
            }
        }

        private void btnSave(object sender, RoutedEventArgs e)
        {
            SelectedQuestions = lvQuestions.SelectedItems.Cast<TlQuestion>().ToList();
            DialogResult = true;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SearchText = txtSearch.Text;
            LoadQuestions();
        }

        private void cmbCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                IdCourseSelected = (int)cmbCourse.SelectedValue;
            }
            catch
            {

            }
            LoadChapterFilter();
        }

        private void cmbChapter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                IdChapterSelected = (int)cmbChapter.SelectedValue;
            }
            catch
            {

            }
            LoadQuestions();
        }
    }
}
