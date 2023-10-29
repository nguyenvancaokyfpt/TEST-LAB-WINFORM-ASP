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
    class EditTestPaperViewModel : ViewModelBase
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
        private TlPaperObj _paper;

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

        public TlPaperObj Paper
        {
            get
            {
                return _paper;
            }
            set
            {
                _paper = value;
                OnPropertyChanged(nameof(Paper));
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



        // Set data for edit paper
        public void SetDataForEditPaper(TlPaperObj paper)
        {
            PaperName = paper.PaperName;
            PaperCode = paper.PaperCode;
            NumberOfQuestion = paper.QuestionNum.ToString();
            IsOpen = paper.IsOpen;
            StartTime = (DateTime)paper.StartTime;
            EndTime = (DateTime)paper.EndTime;
            Duration = paper.Duration.ToString();
            IdCourseSelected = (int)paper.CourseId;
            // Get questions of paper
            var questionRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
            var questionsEf = questionRepository.GetQuestionsByPaperId(paper.Id);
            QuestionsOfTestPaper = new ObservableCollection<TlQuestionObj>(MyMapper.mapper.Map<List<TlQuestionObj>>(questionsEf));

        }

        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand SaveCommand { get; }

        public EditTestPaperViewModel(TlPaper tlPaper)
        {
            AddCommand = new ViewModelCommand(ExuteAddCommand, null);
            DeleteCommand = new ViewModelCommand(ExuteDeleteCommand, null);
            SaveCommand = new ViewModelCommand(ExuteSaveCommand, null);
            SetDataForEditPaper(MyMapper.mapper.Map<TlPaperObj>(tlPaper));
            Paper = MyMapper.mapper.Map<TlPaperObj>(tlPaper);
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

            Paper.PaperName = PaperName;
            Paper.PaperCode = PaperCode;
            Paper.Duration = int.Parse(Duration);
            Paper.StartTime = StartTime;
            Paper.EndTime = EndTime;
            Paper.IsOpen = IsOpen;
            Paper.CourseId = IdCourseSelected;
            Paper.QuestionNum = QuestionsOfTestPaper.Count;
            Paper.CreateBy = 1;
            paperRepository.UpdatePaper(MyMapper.mapper.Map<TlPaper>(Paper));



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
                var questionRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
                foreach (var question in selectedQuestions)
                {
                    QuestionsOfTestPaper.Remove(question);
                    questionRepository.DeleteQuestionPaper(question.Id, Paper.Id);
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
                var questionRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
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
                    questionRepository.AddQuestionToPaper(question.Id, Paper.Id);
                }
                NumberOfQuestion = QuestionsOfTestPaper.Count.ToString();
            }
        }
    }
}
