using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using TestLabEntity.AutoDB;
using TestLabEntity.BusinessObject;
using TestLabLibrary.Repository;
using TestLabManagerAppWPF.ChildWindow.Question;

namespace TestLabManagerAppWPF.ViewModel
{
    class EditQuestionViewModel : ViewModelBase
    {

        private ObservableCollection<TlCourseObj> _courses;
        private ObservableCollection<TlChapterObj> _chapters;
        private ObservableCollection<TlAnswerObj> _answers = new ObservableCollection<TlAnswerObj>();
        private TlCourseObj _selectedCourse;
        private TlChapterObj _selectedChapter;
        private string _questionText;
        private TlQuestion _question;

        private bool isShow = false;
        // Image
        private ImageSource _imageSource;

        public TlCourseObj SelectedCourse
        {
            get
            {
                return _selectedCourse;
            }
            set
            {
                if (isShow)
                {
                    LoadChapters(value.Id);
                }
                _selectedCourse = value;
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
                OnPropertyChanged(nameof(SelectedChapter));
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

        public ObservableCollection<TlAnswerObj> Answers
        {
            get
            {
                return _answers;
            }
            set
            {
                _answers = value;
                OnPropertyChanged(nameof(Answers));
            }
        }

        public ImageSource ImageSource
        {
            get
            {
                return _imageSource;
            }
            set
            {
                _imageSource = value;
                OnPropertyChanged(nameof(ImageSource));
            }
        }

        public string QuestionText
        {
            get
            {
                return _questionText;
            }
            set
            {
                _questionText = value;
                OnPropertyChanged(nameof(QuestionText));
            }
        }

        public TlQuestion Question
        {
            get
            {
                return _question;
            }
            set
            {
                _question = value;
                OnPropertyChanged(nameof(Question));
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

        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }

        public ICommand SaveCommand { get; }

        public ICommand AddImageCommand { get; }


        public EditQuestionViewModel(int qid)
        {
            var questionRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
            Question = questionRepository.GetQuestion(qid);
            var question = Question;

            QuestionText = question.QuestionText;

            ImageSource = BytesToImageSource(question.QuestionImage);

            var answers = questionRepository.GetAnswers(qid);
            Answers = new ObservableCollection<TlAnswerObj>(MyMapper.mapper.Map<List<TlAnswerObj>>(answers));


            LoadChapters(question.CourseId);
            var ch = Chapters.Where(c => c.Id == question.ChapterId).FirstOrDefault();
            if (ch != null)
            {
                SelectedChapter = ch;
            }
            LoadCourses();
            var c = Courses.Where(c => c.Id == question.CourseId).FirstOrDefault();
            if (c != null)
            {
                SelectedCourse = c;
            }
            isShow = true;

            AddCommand = new ViewModelCommand(ExecuteAddCommand, null);
            DeleteCommand = new ViewModelCommand(ExecuteDeleteCommand, null);
            SaveCommand = new ViewModelCommand(ExecuteSaveCommand, null);
            AddImageCommand = new ViewModelCommand(ExecuteAddImageCommand, null);
        }

        private void ExecuteAddImageCommand(object obj)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select Image";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageSource = new BitmapImage(new Uri(openFileDialog.FileName));
            }


        }

        public byte[] ImageSourceToBytes(ImageSource imageSource)
        {
            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            if (imageSource != null)
            {
                encoder.Frames.Add(BitmapFrame.Create((BitmapSource)imageSource));
                using (MemoryStream ms = new MemoryStream())
                {
                    encoder.Save(ms);
                    data = ms.ToArray();
                }
            }
            else
            {
                data = null;
            }
            return data;
        }

        // byte[] to ImageSource
        public ImageSource BytesToImageSource(byte[] bytes)
        {
            if (bytes == null)
            {
                return null;
            }
            BitmapImage bitmapImage = new BitmapImage();
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = ms;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
            }
            return bitmapImage;
        }

        private void ExecuteSaveCommand(object obj)
        {
            TlQuestion question = Question;
            question.QuestionText = QuestionText;
            question.ChapterId = SelectedChapter.Id;
            question.CourseId = SelectedCourse.Id;
            var imageBytes = ImageSourceToBytes(ImageSource);
            question.QuestionImage = imageBytes;
            question.CreateBy = 1;

            // check answer has correct answer
            int countCorrectAnswer = 0;
            foreach (var answer in Answers)
            {
                if (answer.IsCorrect)
                {
                    countCorrectAnswer++;
                }
            }
            if (countCorrectAnswer == 0)
            {
                System.Windows.MessageBox.Show("Please select at least one correct answer", "Warning", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Warning);
                return;
            }

            // Save question to database
            var questionRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
            questionRepository.UpdateQuestion(question);

            // Save answers to database
            foreach (var answerObj in Answers)
            {
                var answer = MyMapper.mapper.Map<TlAnswer>(answerObj);
                if (answer.Id == 0)
                {
                    answer.QuestionId = question.Id;
                    answer.CreateBy = 1;
                    questionRepository.AddAnswer(answer);
                }
                else
                {
                    questionRepository.UpdateAnswer(answer);
                }
            }

            // Message
            System.Windows.MessageBox.Show("Add question successfully", "Message", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
        }

        // Get Selected Answers
        public List<TlAnswerObj> GetSelectedAnswers()
        {
            List<TlAnswerObj> selectedAnswers = new List<TlAnswerObj>();
            foreach (var answer in Answers)
            {
                if (answer.IsSelected)
                {
                    selectedAnswers.Add(answer);
                }
            }
            return selectedAnswers;
        }

        private void ExecuteDeleteCommand(object obj)
        {
            // Get selected answer
            var selectedAnswers = GetSelectedAnswers();
            if (selectedAnswers.Count == 0)
            {
                System.Windows.MessageBox.Show("Please select an answer to delete", "Delete answer");
                return;
            }
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Are you sure to delete all slected answer?", "Delete answer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Delete answer
                var answerRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
                foreach (var answer in selectedAnswers)
                {
                    if (answer.Id != 0)
                    {
                        answerRepository.DeleteAnswer(answer.Id);
                    }
                    Answers.Remove(answer);
                }
            }
        }

        private void ExecuteAddCommand(object obj)
        {
            // open add answer window
            var addAnswerQuestionWindow = new AddAnswerQuestionWindow();
            if (addAnswerQuestionWindow.ShowDialog() == true)
            {
                var answer = addAnswerQuestionWindow.Answer;
                // map to TlAnswerObj
                var answerObj = MyMapper.mapper.Map<TlAnswerObj>(answer);
                // add to Answers
                Answers.Add(answerObj);
            }

        }

    }
}
