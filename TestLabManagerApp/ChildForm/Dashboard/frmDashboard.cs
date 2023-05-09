using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLabLibrary.Repository;

namespace TestLabManagerApp.ChildForm
{
    public partial class frmDashboard : Form
    {
        IStudentRepository _studentRepository;
        IPaperRepository _paperRepository;
        IQuestionRepository _questionRepository;
        public frmDashboard(IRepository rp)
        {
            InitializeComponent();
            _studentRepository = rp.StudentRepository;
            _paperRepository = rp.PaperRepository;
            _questionRepository = rp.QuestionRepository;
            int studentCount = _studentRepository.CountAll();
            int paperCount = _paperRepository.CountAll();
            int questionCount = _questionRepository.CountAll();
            int courseCount = _questionRepository.CountAllCourse();
            int chapterCount = _questionRepository.CountAllChapter();

            btnStudent.Text = $"{studentCount} Student";
            btnTestPaper.Text = $"{paperCount} Test Paper";
            btnQuestion.Text = $"{questionCount} Question";
            btnCourse.Text = $"{courseCount} Course";
            btnChapter.Text = $"{chapterCount} Chapter";
        }
    }
}
