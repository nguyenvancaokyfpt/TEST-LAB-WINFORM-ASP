using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TestLabEntity.AutoDB;
using TestLabEntity.BusinessObject;
using TestLabLibrary.Repository;
using TestLabManagerAppWPF.ChildWindow.TestPaper;

namespace TestLabManagerAppWPF.ViewModel
{
    class AddTestPaperViewModel : ViewModelBase
    {
        private int _idCourseSelected;
        private string _paperName;
        private string _paperCode;
        private string _numberOfQuestion;
        private bool _isOpen;
        private DateTime _startTime = DateTime.Now;
        private DateTime _endTime = DateTime.Now;
        private string _duration;
        private ObservableCollection<TlQuestionObj> _questionsOfTestPaper = new ObservableCollection<TlQuestionObj>();

        public int IdCourseSelected
        {
            get
            {
                return _idCourseSelected;
            }
            set
            {
                _idCourseSelected = value;
                OnPropertyChanged(nameof(IdCourseSelected));
            }
        }

        public string PaperName
        {
            get
            {
                return _paperName;
            }
            set
            {
                _paperName = value;
                OnPropertyChanged(nameof(PaperName));
            }
        }

        public string PaperCode
        {
            get
            {
                return _paperCode;
            }
            set
            {
                _paperCode = value;
                OnPropertyChanged(nameof(PaperCode));
            }
        }

        public string NumberOfQuestion
        {
            get
            {
                return _numberOfQuestion;
            }
            set
            {
                _numberOfQuestion = value;
                OnPropertyChanged(nameof(NumberOfQuestion));
            }
        }

        public bool IsOpen
        {
            get
            {
                return _isOpen;
            }
            set
            {
                _isOpen = value;
                OnPropertyChanged(nameof(IsOpen));
            }
        }

        public DateTime StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime = value;
                OnPropertyChanged(nameof(StartTime));
            }
        }

        public DateTime EndTime
        {
            get
            {
                return _endTime;
            }
            set
            {
                _endTime = value;
                OnPropertyChanged(nameof(EndTime));
            }
        }

        public string Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                _duration = value;
                OnPropertyChanged(nameof(Duration));
            }
        }

        public ObservableCollection<TlQuestionObj> QuestionsOfTestPaper
        {
            get
            {
                return _questionsOfTestPaper;
            }
            set
            {
                _questionsOfTestPaper = value;
                OnPropertyChanged(nameof(QuestionsOfTestPaper));
            }
        }

        // Get Selected Questions
        public List<TlQuestionObj> GetSelectedQuestions()
        {
            List<TlQuestionObj> selectedQuestions = new List<TlQuestionObj>();
            foreach (var question in QuestionsOfTestPaper)
            {
                if (question.IsSelected)
                {
                    selectedQuestions.Add(question);
                }
            }
            return selectedQuestions;
        }

        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand SaveCommand { get; }

        public AddTestPaperViewModel()
        {
            AddCommand = new ViewModelCommand(ExuteAddCommand, null);
            DeleteCommand = new ViewModelCommand(ExuteDeleteCommand, null);
            SaveCommand = new ViewModelCommand(ExuteSaveCommand, null);


        }

        private void ExuteSaveCommand(object obj)
        {
            // Validate
            if (string.IsNullOrEmpty(PaperName))
            {
                MessageBox.Show("Please enter paper name!");
                return;
            }
            if (string.IsNullOrEmpty(PaperCode))
            {
                MessageBox.Show("Please enter paper code!");
                return;
            }
            if (string.IsNullOrEmpty(NumberOfQuestion))
            {
                MessageBox.Show("Please enter number of question!");
                return;
            }
            if (QuestionsOfTestPaper.Count == 0)
            {
                MessageBox.Show("Please add question to paper!");
                return;
            }
            if (StartTime > EndTime)
            {
                MessageBox.Show("Start time must be less than end time!");
                return;
            }
            if (EndTime < DateTime.Now)
            {
                MessageBox.Show("End time must be greater than current time!");
                return;
            }
            if (string.IsNullOrEmpty(Duration))
            {
                MessageBox.Show("Please enter duration!");
                return;
            }
            // Save paper
            var paperRepository = MyService.serviceProvider.GetService<IPaperRepository>();
            var questionRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
            var paper = new TlPaperObj
            {
                PaperName = PaperName,
                PaperCode = PaperCode,
                Duration = int.Parse(Duration),
                StartTime = StartTime,
                EndTime = EndTime,
                IsOpen = IsOpen,
                CourseId = IdCourseSelected,
                QuestionNum = QuestionsOfTestPaper.Count,
                CreateBy = 1
            };
            int id = paperRepository.AddPaper(MyMapper.mapper.Map<TlPaper>(paper));

            // Save question to paper
            foreach (var question in QuestionsOfTestPaper)
            {
                questionRepository.AddQuestionToPaper(question.Id, id);
            }

            // Message
            MessageBox.Show("Add paper successfully!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
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
                foreach (var question in selectedQuestions)
                {
                    QuestionsOfTestPaper.Remove(question);
                    NumberOfQuestion = QuestionsOfTestPaper.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete question failed with error: " + ex.Message);
            }
        }

        private void ExuteAddCommand(object obj)
        {
            var addQuestionToTestPaper = new AddQuestionTestPaperWindow(IdCourseSelected);
            if (addQuestionToTestPaper.ShowDialog() == true)
            {
                var selectedQuestions = addQuestionToTestPaper.SelectedQuestions;
                foreach (var question in selectedQuestions)
                {
                    var questionOfTestPaper = QuestionsOfTestPaper.FirstOrDefault(q => q.Id == question.Id);
                    if (questionOfTestPaper != null)
                    {
                        continue;
                    }
                    // tlQuestion to tlQuestionObj
                    var questionObj = MyMapper.mapper.Map<TlQuestionObj>(question);
                    QuestionsOfTestPaper.Add(questionObj);
                }
                NumberOfQuestion = QuestionsOfTestPaper.Count.ToString();
            }
        }
    }
}
