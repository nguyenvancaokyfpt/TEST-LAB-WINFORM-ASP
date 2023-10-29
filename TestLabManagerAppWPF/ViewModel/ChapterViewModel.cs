using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using TestLabEntity.BusinessObject;
using TestLabLibrary.Repository;
using TestLabManagerAppWPF.ChildWindow.Chapter;

namespace TestLabManagerAppWPF.ViewModel
{
    class ChapterViewModel : ViewModelBase
    {
        private ObservableCollection<TlChapterObj> _chapters;
        private ObservableCollection<TlCourseObj> _courses;
        private TlCourseObj _selectedCourse;
        private string _searchText = "";

        public ObservableCollection<TlChapterObj> Chapters
        {
            get
            {
                return _chapters;
            }
            set
            {
                _chapters = value;
                OnPropertyChanged(nameof(Chapters));
            }
        }
        public ObservableCollection<TlCourseObj> Courses
        {
            get
            {
                return _courses;
            }
            set
            {
                _courses = value;
                OnPropertyChanged(nameof(Courses));
            }
        }
        public TlCourseObj SelectedCourse
        {
            get
            {
                return _selectedCourse;
            }
            set
            {
                // Load chapters
                LoadChapters(value.Id);
                _selectedCourse = value;
                OnPropertyChanged(nameof(SelectedCourse));
            }
        }

        public string SearchText
        {
            get
            {
                return _searchText;
            }
            set
            {
                _searchText = value;
                OnPropertyChanged(nameof(SearchText));
            }
        }


        // Command
        public ICommand SearchCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        // Get Courses from database
        public void LoadCourses()
        {
            var courseRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
            var coursesEf = courseRepository.GetCourses();
            Courses = new ObservableCollection<TlCourseObj>(MyMapper.mapper.Map<List<TlCourseObj>>(coursesEf));
        }

        // Get Chapters from database by CourseId
        public void LoadChapters(int courseId)
        {
            if (courseId == 0)
            {
                return;
            }
            var chapterRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
            var chaptersEf = chapterRepository.GetChapters(0, 9999, courseId, SearchText);
            Chapters = new ObservableCollection<TlChapterObj>(MyMapper.mapper.Map<List<TlChapterObj>>(chaptersEf));
        }

        // Get Selected Chapters
        public List<TlChapterObj> GetSelectedChapters()
        {
            List<TlChapterObj> selectedChapters = new List<TlChapterObj>();
            foreach (var chapter in Chapters)
            {
                if (chapter.IsSelected)
                {
                    selectedChapters.Add(chapter);
                }
            }
            return selectedChapters;
        }

        public ChapterViewModel()
        {
            // Load courses
            LoadCourses();
            SearchCommand = new ViewModelCommand(ExuteSearchCommand, null);
            AddCommand = new ViewModelCommand(ExuteAddCommand, null);
            EditCommand = new ViewModelCommand(ExuteEditCommand, null);
            DeleteCommand = new ViewModelCommand(ExuteDeleteCommand, null);
        }

        private void ExuteSearchCommand(object obj)
        {
            // Get selected course from combobox
            if (SelectedCourse != null)
            {
                // Load chapters
                LoadChapters(SelectedCourse.Id);
            }
        }

        private void ExuteAddCommand(object obj)
        {
            // Open add chapter window
            AddChapterWindow addChapterWindow = new AddChapterWindow(SelectedCourse.Id);
            if (addChapterWindow.ShowDialog() == true)
            {
                // Reload data
                LoadChapters(SelectedCourse.Id);
            }
        }

        private void ExuteEditCommand(object obj)
        {
            // Get selected chapter
            List<TlChapterObj> selectedChapters = GetSelectedChapters();
            if (selectedChapters.Count == 0)
            {
                System.Windows.MessageBox.Show("Please select chapter");
                return;
            }
            if (selectedChapters.Count > 1)
            {
                System.Windows.MessageBox.Show("Please select only one chapter");
                return;
            }
            // Open edit chapter window
            EditChapterWindow editChapterWindow = new EditChapterWindow(selectedChapters[0]);
            if (editChapterWindow.ShowDialog() == true)
            {
                // Reload data
                LoadChapters(SelectedCourse.Id);
            }
        }

        private void ExuteDeleteCommand(object obj)
        {
            // Get selected chapter
            List<TlChapterObj> selectedChapters = GetSelectedChapters();
            if (selectedChapters.Count == 0)
            {
                System.Windows.MessageBox.Show("Please select chapter");
                return;
            }
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Are you sure to delete all slected chapter?", "Delete chapter", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Delete chapter
                var chapterRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
                foreach (var chapter in selectedChapters)
                {
                    try
                    {
                        chapterRepository.DeleteChapter(chapter.Id);
                    }
                    catch
                    {
                        System.Windows.MessageBox.Show("Cannot delete chapter " + chapter.ChapterName);
                    }
                }
                // Reload data
                LoadChapters(SelectedCourse.Id);
            }
        }
    }
}
