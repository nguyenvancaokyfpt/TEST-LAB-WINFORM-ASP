using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TestLabManagerAppWPF.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private ViewModelBase? _currentChildView;
        private string? _caption;
        private IconChar _icon;


        public ViewModelBase CurrentChildView
        {
            get
            {
                return _currentChildView;
            }
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }

        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }
        public IconChar Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value;
                OnPropertyChanged(nameof(Icon));
            }
        }

        // Commands
        public ICommand ShowDashboardViewCommand { get; }
        public ICommand ShowStudentViewCommand { get; }
        public ICommand ShowCourseViewCommand { get; }
        public ICommand ShowChapterViewCommand { get; }
        public ICommand ShowQuestionViewCommand { get; }
        public ICommand ShowTestPaperViewCommand { get; }
        public ICommand ShowSubmitPaperViewCommand { get; }

        // Constructor
        public MainViewModel()
        {
            // Initialize commands
            ShowDashboardViewCommand = new ViewModelCommand(ExecuteShowDashboardViewCommand, CanExecuteShowDashboardViewCommand);
            ShowStudentViewCommand = new ViewModelCommand(ExecuteShowStudentViewCommand, CanExecuteShowStudentViewCommand);
            ShowCourseViewCommand = new ViewModelCommand(ExecuteShowCourseViewCommand, CanExecuteShowCourseViewCommand);
            ShowChapterViewCommand = new ViewModelCommand(ExecuteShowChapterViewCommand, CanExecuteShowChapterViewCommand);
            ShowQuestionViewCommand = new ViewModelCommand(ExecuteShowQuestionViewCommand, CanExecuteShowQuestionViewCommand);
            ShowTestPaperViewCommand = new ViewModelCommand(ExecuteShowTestPaperViewCommand, CanExecuteShowTestPaperViewCommand);
            ShowSubmitPaperViewCommand = new ViewModelCommand(ExecuteShowSubmitPaperViewCommand, CanExecuteShowSubmitPaperViewCommand);

            // Default view
            ExecuteShowDashboardViewCommand(null);
        }

        private bool CanExecuteShowSubmitPaperViewCommand(object obj)
        {
            return true;
        }

        private void ExecuteShowSubmitPaperViewCommand(object obj)
        {
            CurrentChildView = new SubmitPaperViewModel();
            Caption = "Submit Paper";
            Icon = IconChar.FileAlt;
        }

        private bool CanExecuteShowTestPaperViewCommand(object obj)
        {
            return true;
        }

        private void ExecuteShowTestPaperViewCommand(object obj)
        {
            CurrentChildView = new TestPaperViewModel();
            Caption = "Test Paper";
            Icon = IconChar.FileAlt;
        }

        private void ExecuteShowQuestionViewCommand(object obj)
        {
            CurrentChildView = new QuestionViewModel();
            Caption = "Question";
            Icon = IconChar.Question;
        }

        private bool CanExecuteShowQuestionViewCommand(object obj)
        {
            return true;
        }

        private void ExecuteShowChapterViewCommand(object obj)
        {
            CurrentChildView = new ChapterViewModel();
            Caption = "Chapter";
            Icon = IconChar.Book;
        }

        private bool CanExecuteShowChapterViewCommand(object obj)
        {
            return true;
        }

        private void ExecuteShowCourseViewCommand(object obj)
        {
            CurrentChildView = new CourseViewModel();
            Caption = "Course";
            Icon = IconChar.Book;
        }

        private bool CanExecuteShowCourseViewCommand(object obj)
        {
            return true;
        }

        private bool CanExecuteShowStudentViewCommand(object obj)
        {
            return true;
        }

        private void ExecuteShowStudentViewCommand(object obj)
        {
            CurrentChildView = new StudentViewModel();
            Caption = "Student";
            Icon = IconChar.User;
        }

        private bool CanExecuteShowDashboardViewCommand(object obj)
        {
            return true;
        }

        private void ExecuteShowDashboardViewCommand(object obj)
        {
            CurrentChildView = new DashboardViewModel();
            Caption = "Dashboard";
            Icon = IconChar.Home;
        }
    }
}
