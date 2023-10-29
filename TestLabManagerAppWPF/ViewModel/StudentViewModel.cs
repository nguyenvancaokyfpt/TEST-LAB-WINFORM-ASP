using Microsoft.EntityFrameworkCore.ChangeTracking;
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
using TestLabEntity.AutoDB;
using TestLabEntity.BusinessObject;
using TestLabLibrary.Repository;
using TestLabManagerAppWPF.ChildWindow.Student;

namespace TestLabManagerAppWPF.ViewModel
{
    class StudentViewModel : ViewModelBase
    {
        private ObservableCollection<TlStudentObj> _students;
        private string _searchText = "";


        public ObservableCollection<TlStudentObj> Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
                OnPropertyChanged(nameof(Students));
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

        // GetSelectedStudent
        public List<TlStudentObj> GetSelectedStudents()
        {
            List<TlStudentObj> selectedStudents = new List<TlStudentObj>();
            foreach (var student in Students)
            {
                if (student.IsSelected)
                {
                    selectedStudents.Add(student);
                }
            }
            return selectedStudents;
        }

        // Command
        public ICommand SearchCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        // Constructor
        public StudentViewModel()
        {

            LoadStudents();
            SearchCommand = new ViewModelCommand(ExuteSearchCommand, null);
            AddCommand = new ViewModelCommand(ExuteAddCommand, null);
            EditCommand = new ViewModelCommand(ExuteEditCommand, null);
            DeleteCommand = new ViewModelCommand(ExuteDeleteCommand, null);
        }

        private void ExuteDeleteCommand(object obj)
        {
            // Get selected student
            var selectedStudents = GetSelectedStudents();
            if (selectedStudents.Count == 0)
            {
                System.Windows.MessageBox.Show("Please select a student to delete", "Delete student");
                return;
            }
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Are you sure to delete all slected student?", "Delete student", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Delete student
                var studentRepo = MyService.serviceProvider.GetService<IStudentRepository>();
                foreach (var student in selectedStudents)
                {
                    studentRepo.DeleteStudent(student.Id);
                }
                // Reload data
                LoadStudents();
            }
        }

        private void ExuteEditCommand(object obj)
        {
            // Get selected student
            var selectedStudents = GetSelectedStudents();
            if (selectedStudents.Count == 0)
            {
                System.Windows.MessageBox.Show("Please select a student to edit", "Edit student");
                return;
            }
            if (selectedStudents.Count > 1)
            {
                System.Windows.MessageBox.Show("Please select only one student to edit", "Edit student");
                return;
            }
            // Open edit window
            EditStudentWindow editStudentWindow = new EditStudentWindow(selectedStudents[0]);
            if (editStudentWindow.ShowDialog() == true)
            {
                LoadStudents();
            }
        }

        private void ExuteAddCommand(object obj)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            if (addStudentWindow.ShowDialog() == true)
            {
                LoadStudents();
            }
        }

        private void ExuteSearchCommand(object obj)
        {
            LoadStudents();
            // Notify UI to update
            OnPropertyChanged(nameof(Students));
        }

        private void LoadStudents()
        {
            var studentRepo = MyService.serviceProvider.GetService<IStudentRepository>();
            var studentsEf = new ObservableCollection<TlStudent>(studentRepo.GetStudents(0, 9999, SearchText));
            Students = new ObservableCollection<TlStudentObj>(MyMapper.mapper.Map<List<TlStudentObj>>(studentsEf));
        }
    }
}
