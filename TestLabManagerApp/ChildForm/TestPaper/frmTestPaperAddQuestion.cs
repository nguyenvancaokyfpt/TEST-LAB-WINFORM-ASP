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

namespace TestLabManagerApp.ChildForm.TestPaper
{
    public partial class frmTestPaperAddQuestion : Form
    {
        IQuestionRepository _questionRepository;
        String SearchText = "";
        int IdCourseSelected = 1;
        int IdChapterSelected = 1;
        public List<int> id_questions = new List<int>();
        public frmTestPaperAddQuestion(int IdCourseSelected, IQuestionRepository rp)
        {
            InitializeComponent();
            this._questionRepository = rp;
            this.IdCourseSelected = IdCourseSelected;
            SetColums();
            LoadCourseFilter();
            LoadChapterFilter();
            LoadData();
        }

        public void LoadCourseFilter()
        {
            var c = _questionRepository.GetCourseById(IdCourseSelected);
            var courses = new List<TlCourse>();
            courses.Add(c);
            if (courses.Count > 0)
            {
                IdCourseSelected = courses[0].Id;
                cbCourse.DataSource = courses;
                cbCourse.DisplayMember = "CourseName";
                cbCourse.ValueMember = "Id";
                LoadData();
            }
            else
            {
                cbCourse.DataSource = null;
            }
        }

        public void LoadChapterFilter()
        {
            var chapters = _questionRepository.GetChapters(0, 999, IdCourseSelected);
            if (chapters.Count > 0)
            {
                IdChapterSelected = chapters[0].Id;
                cbChapter.DataSource = chapters;
                cbChapter.DisplayMember = "ChapterName";
                cbChapter.ValueMember = "Id";
                LoadData();
            }
            else
            {
                cbChapter.DataSource = null;
            }
        }


        public void LoadData()
        {

            var questions = _questionRepository.GetQuestions(0, 999, IdCourseSelected, IdChapterSelected, SearchText);
            if (questions.Count > 0)
            {
                dgvQuestion.DataSource = questions;
            }
            else
            {
                dgvQuestion.DataSource = null;
            }
        }


        public void SetColums()
        {
            dgvQuestion.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            dgvQuestion.Columns.Add(colId);

            DataGridViewTextBoxColumn colQuestionText = new DataGridViewTextBoxColumn();
            colQuestionText.DataPropertyName = "QuestionText";
            colQuestionText.HeaderText = "QuestionText";
            colQuestionText.Name = "colQuestionText";
            colQuestionText.ReadOnly = true;
            dgvQuestion.Columns.Add(colQuestionText);

            DataGridViewTextBoxColumn colCourseId = new DataGridViewTextBoxColumn();
            colCourseId.DataPropertyName = "CourseId";
            colCourseId.HeaderText = "CourseId";
            colCourseId.Name = "colCourseId";
            colCourseId.ReadOnly = true;
            dgvQuestion.Columns.Add(colCourseId);

            DataGridViewTextBoxColumn colChapterId = new DataGridViewTextBoxColumn();
            colChapterId.DataPropertyName = "ChapterId";
            colChapterId.HeaderText = "ChapterId";
            colChapterId.Name = "colChapterId";
            colChapterId.ReadOnly = true;
            dgvQuestion.Columns.Add(colChapterId);
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdCourseSelected = (int)cbCourse.SelectedValue;
            }
            catch
            {

            }
            LoadChapterFilter();
        }

        private void cbChapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdChapterSelected = (int)cbChapter.SelectedValue;
            }
            catch
            {

            }
            LoadData();
        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            SearchText = inputStudentSearch.Text;
            LoadData();
        }

        private void inputStudentSearch_TextChanged(object sender, EventArgs e)
        {
            SearchText = inputStudentSearch.Text;
            LoadData();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvQuestion.SelectedRows)
            {
                // Delete answer of question
                int id = (int)row.Cells["colId"].Value;
                if (id > 0)
                {
                    id_questions.Add(id);
                }
            }
            if (id_questions.Count > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
