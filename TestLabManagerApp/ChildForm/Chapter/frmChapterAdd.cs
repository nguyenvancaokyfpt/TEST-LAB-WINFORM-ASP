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
    public partial class frmChapterAdd : Form
    {
        IQuestionRepository _questionRepository;
        int IdCourseSelected = 0;
        List<TlCourse> courses = null;
        TlAdmin _admin = null;
        public frmChapterAdd(TlAdmin admin, int IdCourseSelected, List<TlCourse> courses, IQuestionRepository rp)
        {
            InitializeComponent();
            _questionRepository = rp;
            this.IdCourseSelected = IdCourseSelected;
            this.courses = courses;
            _admin = admin;
            LoadCourseFilter();
        }

        public void LoadCourseFilter()
        {
            if (courses.Count > 0)
            {
                cbCourse.DataSource = courses;
                cbCourse.DisplayMember = "CourseName";
                cbCourse.ValueMember = "Id";
                cbCourse.SelectedValue = IdCourseSelected;
            }
            else
            {
                cbCourse.DataSource = null;
            }
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            TlChapter chapter = new TlChapter();
            chapter.ChapterName = inputCourse.Text;
            chapter.CourseId = (int)cbCourse.SelectedValue;
            chapter.CreateBy = _admin.Id;
            try
            {
                _questionRepository.AddChapter(chapter);
                // exit with status ok
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
