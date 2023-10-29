using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using TestLabEntity.BusinessObject;
using TestLabLibrary.Repository;
using TestLabManagerAppWPF.ChildWindow.Course;

namespace TestLabManagerAppWPF.ViewModel
{
    class CourseViewModel : ViewModelBase
    {
        private ObservableCollection<TlCourseObj> _courses;
        private string _searchText = "";

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
            var coursesEf = courseRepository.GetCourses(0, 9999, SearchText);
            Courses = new ObservableCollection<TlCourseObj>(MyMapper.mapper.Map<List<TlCourseObj>>(coursesEf));
        }

        // Get Selected Courses
        public List<TlCourseObj> GetSelectedCourses()
        {
            List<TlCourseObj> selectedCourses = new List<TlCourseObj>();
            foreach (var course in Courses)
            {
                if (course.IsSelected)
                {
                    selectedCourses.Add(course);
                }
            }
            return selectedCourses;
        }

        // Command
        public ICommand SearchCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
        public CourseViewModel()
        {
            LoadCourses();
            SearchCommand = new ViewModelCommand(ExuteSearchCommand, null);
            AddCommand = new ViewModelCommand(ExuteAddCommand, null);
            EditCommand = new ViewModelCommand(ExuteEditCommand, null);
            DeleteCommand = new ViewModelCommand(ExuteDeleteCommand, null);
        }

        private void ExuteDeleteCommand(object obj)
        {
            // Get selected course
            var selectedCourses = GetSelectedCourses();
            if (selectedCourses.Count == 0)
            {
                System.Windows.MessageBox.Show("Please select course to delete", "Warning", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Warning);
                return;
            }
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Are you sure to delete selected course?", "Delete course", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else
            {
                // Delete selected course
                var courseRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
                foreach (var course in selectedCourses)
                {
                    try
                    {
                        courseRepository.DeleteCourse(course.Id);
                    }
                    catch
                    {
                        MessageBox.Show("Cannot delete course " + course.CourseName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Reload course list
                LoadCourses();
            }
        }

        private void ExuteEditCommand(object obj)
        {
            // Get selected course
            var selectedCourses = GetSelectedCourses();
            if (selectedCourses.Count == 0)
            {
                System.Windows.MessageBox.Show("Please select course to edit", "Warning", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Warning);
            }
            else if (selectedCourses.Count > 1)
            {
                System.Windows.MessageBox.Show("Please select only one course to edit", "Warning", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Warning);
            }
            else
            {
                // Open EditCourseWindow
                var editCourseWindow = new EditCourseWindow(selectedCourses[0]);
                if (editCourseWindow.ShowDialog() == true)
                {
                    // Reload course list
                    LoadCourses();
                }
            }

        }

        private void ExuteAddCommand(object obj)
        {
            // Open AddCourseWindow
            var addCourseWindow = new AddCourseWindow();
            if (addCourseWindow.ShowDialog() == true)
            {
                // Reload course list
                LoadCourses();
            }
        }

        private void ExuteSearchCommand(object obj)
        {
            LoadCourses();
        }
    }
}
