using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLabEntity.AutoDB;
using TestLabLibrary.Repository;

namespace TestLabManagerApp.ChildForm.Chapter
{
    public partial class frmChapterEdit : Form
    {
        IQuestionRepository _questionRepository;
        List<TlCourse> courses = null;
        TlChapter? _chapter = null;
        public frmChapterEdit(int IdChapterSelected, int IdCourseSelected, List<TlCourse> courses, IQuestionRepository rp)
        {
            InitializeComponent();
            _questionRepository = rp;
            this.courses = courses;
            LoadCourse(IdChapterSelected, IdCourseSelected);
        }

        public void LoadCourse(int IdChapterSelected, int IdCourseSelected)
        {
            _chapter = _questionRepository.GetChapter(IdChapterSelected);
            if (_chapter != null)
            {
                inputCourse.Text = _chapter.ChapterName;
            }
            cbCourse.DataSource = courses;
            cbCourse.DisplayMember = "CourseName";
            cbCourse.ValueMember = "Id";
            cbCourse.SelectedValue = IdCourseSelected;
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (_chapter != null)
            {
                _chapter.ChapterName = inputCourse.Text;
                _chapter.CourseId = (int)cbCourse.SelectedValue;
                _questionRepository.UpdateChapter(_chapter);
                // exit with status ok
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Chapter not found");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
