using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestLabEntity.AutoDB;
using TestLabEntity.BusinessObject;
using TestLabLibrary.Repository;
using TestLabManagerAppWPF.ChildWindow.TestPaper;

namespace TestLabManagerAppWPF.ViewModel
{
    class TestPaperViewModel : ViewModelBase
    {
        private ObservableCollection<TlPaperObj> _papers;
        private ObservableCollection<TlCourseObj> _courses;
        private TlCourseObj _selectedCourse;
        private string _searchText = "";

        public ObservableCollection<TlPaperObj> Papers
        {
            get
            {
                return _papers;
            }
            set
            {
                _papers = value;
                OnPropertyChanged(nameof(Papers));
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
                // Load papers
                _selectedCourse = value;
                LoadPapers(value.Id);
                OnPropertyChanged(nameof(SelectedCourse));
            }
        }

        // Get Papers from database
        public void LoadPapers(int courseId = 0)
        {
            var paperRepository = MyService.serviceProvider.GetService<IPaperRepository>();
            var papersEf = new ObservableCollection<TlPaper>(paperRepository.GetPapers(0, 9999, SearchText));
            if (courseId != 0)
            {
                papersEf = new ObservableCollection<TlPaper>(papersEf.Where(p => p.CourseId == courseId).ToList());
            }
            Papers = new ObservableCollection<TlPaperObj>(MyMapper.mapper.Map<List<TlPaperObj>>(papersEf));
        }

        // Load Courses
        public void LoadCourses()
        {
            var courseRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
            var coursesEf = courseRepository.GetCourses(0, 9999, SearchText);
            Courses = new ObservableCollection<TlCourseObj>(MyMapper.mapper.Map<List<TlCourseObj>>(coursesEf));
        }

        // Get Selected Papers
        public List<TlPaperObj> GetSelectedPapers()
        {
            List<TlPaperObj> selectedPapers = new List<TlPaperObj>();
            foreach (var paper in Papers)
            {
                if (paper.IsSelected)
                {
                    selectedPapers.Add(paper);
                }
            }
            return selectedPapers;
        }


        // Command
        public ICommand SearchCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
        public TestPaperViewModel()
        {
            LoadCourses();
            LoadPapers();
            
            SearchCommand = new ViewModelCommand(ExuteSearchCommand, null);
            AddCommand = new ViewModelCommand(ExuteAddCommand, null);
            EditCommand = new ViewModelCommand(ExuteEditCommand, null);
            DeleteCommand = new ViewModelCommand(ExuteDeleteCommand, null);
        }

        private void ExuteDeleteCommand(object obj)
        {
            // Get selected Paper
            var selectedPapers = GetSelectedPapers();
            if (selectedPapers.Count == 0)
            {
                System.Windows.MessageBox.Show("Please select a paper to delete!");
                return;
            }
            var paperRepository = MyService.serviceProvider.GetService<IPaperRepository>();
            try
            {
                foreach (var paper in selectedPapers)
                {
                    paperRepository.DeletePaper(paper.Id);
                }
                System.Windows.MessageBox.Show("Delete paper successfully!");
                LoadPapers();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Delete paper failed with error: " + ex.Message);
            }
        }

        private void ExuteEditCommand(object obj)
        {
            // get selected paper
            var selectedPapers = GetSelectedPapers();
            if (selectedPapers.Count == 0)
            {
                System.Windows.MessageBox.Show("Please select a paper to edit!");
                return;
            }
            if (selectedPapers.Count > 1)
            {
                System.Windows.MessageBox.Show("Please select only one paper to edit!");
                return;
            }
            if (SelectedCourse == null)
            {
                System.Windows.MessageBox.Show("Please select a course!");
                return;
            }

            var editTestPaperWindow = new EditTestPaperWindow();
            var paper = MyMapper.mapper.Map<TlPaper>(selectedPapers[0]);
            var editTestPaperViewModel = new EditTestPaperViewModel(paper);
            editTestPaperViewModel.IdCourseSelected = SelectedCourse.Id;
            editTestPaperWindow.DataContext = editTestPaperViewModel;
            if (editTestPaperWindow.ShowDialog() == true)
            {
                // Reload papers
                LoadPapers(SelectedCourse.Id);
            }
        }

        private void ExuteAddCommand(object obj)
        {
            var addTestPaperWindow = new AddTestPaperWindow();
            var addTestPaperViewModel = new AddTestPaperViewModel();
            if (SelectedCourse == null)
            {
                System.Windows.MessageBox.Show("Please select a course!");
                return;
            }
            addTestPaperViewModel.IdCourseSelected = SelectedCourse.Id;
            addTestPaperWindow.DataContext = addTestPaperViewModel;
            if (addTestPaperWindow.ShowDialog() == true)
            {
                // Reload papers
                LoadPapers(SelectedCourse.Id);
            }

        }

        private void ExuteSearchCommand(object obj)
        {
            if (SelectedCourse == null)
            {
                LoadPapers();
            }
            else
            {
                LoadPapers(SelectedCourse.Id);
            }
            // Notify UI to update
            OnPropertyChanged(nameof(Papers));
        }
    }
}
