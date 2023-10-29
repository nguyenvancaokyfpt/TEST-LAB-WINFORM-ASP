using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TestLabEntity.BusinessObject;
using TestLabLibrary.Repository;
using TestLabManagerAppWPF.ChildWindow.Question;

namespace TestLabManagerAppWPF.ViewModel
{
    class QuestionViewModel : ViewModelBase
    {
        private ObservableCollection<TlQuestionObj> _questions;
        private ObservableCollection<TlCourseObj> _courses;
        private ObservableCollection<TlChapterObj> _chapters;
        private TlCourseObj _selectedCourse;
        private TlChapterObj _selectedChapter;

        private string _searchText = "";

        public ObservableCollection<TlQuestionObj> Questions
        {
            get
            {
                return _questions;
            }
            set
            {
                _questions = value;
                OnPropertyChanged(nameof(Questions));
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

        public TlCourseObj SelectedCourse
        {
            get
            {
                return _selectedCourse;
            }
            set
            {
                _selectedCourse = value;
                LoadChapters(value.Id);
                OnPropertyChanged(nameof(SelectedCourse));
            }
        }

        public TlChapterObj SelectedChapter
        {
            get
            {
                return _selectedChapter;
            }
            set
            {
                _selectedChapter = value;
                LoadQuestions(value.Id);
                OnPropertyChanged(nameof(SelectedChapter));
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
            var chapterRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
            var chaptersEf = chapterRepository.GetChapters(0, 9999, courseId, "");
            Chapters = new ObservableCollection<TlChapterObj>(MyMapper.mapper.Map<List<TlChapterObj>>(chaptersEf));
        }

        // Get Questions from database by ChapterId
        public void LoadQuestions(int id)
        {
            if (SelectedChapter == null)
            {
                return;
            }
            if (SelectedCourse == null)
            {
                return;
            }
            var questionRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
            var questionsEf = questionRepository.GetQuestions(0, 9999, SelectedCourse.Id, id, SearchText);
            Questions = new ObservableCollection<TlQuestionObj>(MyMapper.mapper.Map<List<TlQuestionObj>>(questionsEf));
        }

        // Command
        public ICommand SearchCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
        public QuestionViewModel()
        {
            LoadCourses();
            SearchCommand = new ViewModelCommand(ExuteSearchCommand, null);
            AddCommand = new ViewModelCommand(ExuteAddCommand, null);
            EditCommand = new ViewModelCommand(ExuteEditCommand, null);
            DeleteCommand = new ViewModelCommand(ExuteDeleteCommand, null);
        }

        // Get Selected Questions
        public List<TlQuestionObj> GetSelectedQuestions()
        {
            List<TlQuestionObj> selectedQuestions = new List<TlQuestionObj>();
            foreach (var question in Questions)
            {
                if (question.IsSelected)
                {
                    selectedQuestions.Add(question);
                }
            }
            return selectedQuestions;
        }
        private void ExuteDeleteCommand(object obj)
        {
            // Get selected questions
            var selectedQuestions = GetSelectedQuestions();
            if (selectedQuestions.Count == 0)
            {
                MessageBox.Show("Please select questions to delete!");
                return;
            }
            // Delete questions
            try
            {
                var questionRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
                foreach (var question in selectedQuestions)
                {
                    try
                    {
                        // Delete answers of question
                        questionRepository.DeleteAnswerByQuestionId(question.Id);
                        questionRepository.DeleteQuestion(question.Id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("Delete questions successfully!");
                LoadQuestions(SelectedChapter.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExuteEditCommand(object obj)
        {
            // open edit question window
            var selectedQuestions = GetSelectedQuestions();
            if (selectedQuestions.Count == 0)
            {
                MessageBox.Show("Please select a question to edit!");
                return;
            }
            var editQuestionWindow = new EditQuestionWindow();
            editQuestionWindow.DataContext = new EditQuestionViewModel(selectedQuestions[0].Id);
            if (editQuestionWindow.ShowDialog() == true)
            {
                // reload questions
                LoadQuestions(SelectedChapter.Id);
            }
        }

        private void ExuteAddCommand(object obj)
        {
            // open add question window
            int cid = (SelectedCourse == null) ? 0 : SelectedCourse.Id;
            int chid = (SelectedChapter == null) ? 0 : SelectedChapter.Id;
            var addQuestionWindow = new AddQuestionWindow(cid, chid);
            addQuestionWindow.DataContext = new AddQuestionViewModel(cid, chid);
            if (addQuestionWindow.ShowDialog() == true)
            {
                // reload questions
                LoadQuestions(SelectedChapter.Id);
            }
        }

        private void ExuteSearchCommand(object obj)
        {
            LoadQuestions(SelectedChapter.Id);
        }
    }
}
