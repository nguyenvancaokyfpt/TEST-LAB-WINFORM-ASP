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
using TestLabManagerApp.ChildForm.Question;

namespace TestLabManagerApp.ChildForm
{
    public partial class frmQuestion : Form
    {
        IQuestionRepository _questionRepository;
        String SearchText = "";
        int IdCourseSelected = 1;
        int IdChapterSelected = 1;
        int IdQuestionSelected = 0;
        TlAdmin admin = null;
        public frmQuestion(IRepository rp)
        {
            InitializeComponent();
            _questionRepository = rp.QuestionRepository;
            admin = rp.Admin;
            SetColums();
            LoadCourseFilter();
            LoadChapterFilter();
            LoadData();
        }

        public void LoadCourseFilter()
        {
            var courses = _questionRepository.GetCourses();
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

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            frmQuestionAddEdit frm = new frmQuestionAddEdit(-1, _questionRepository, admin, IdCourseSelected, IdChapterSelected);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
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

        private void cbChapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdChapterSelected = Convert.ToInt32(cbChapter.SelectedValue);
            } catch
            {

            }
            LoadData();
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdCourseSelected = Convert.ToInt32(cbCourse.SelectedValue);
            } catch
            {

            }
            LoadChapterFilter();
            LoadData();
        }

        private void inputQuestionSearch_TextChanged(object sender, EventArgs e)
        {
            SearchText = inputQuestionSearch.Text;
            LoadData();
        }

        private void btnQuestionSearch_Click(object sender, EventArgs e)
        {
            SearchText = inputQuestionSearch.Text;
            LoadData();
        }

        private void dgvQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestion.SelectedRows.Count > 0)
            {
                IdQuestionSelected = Convert.ToInt32(dgvQuestion.SelectedRows[0].Cells["colId"].Value);
            }
        }

        private void dgvQuestion_DoubleClick(object sender, EventArgs e)
        {
            if (dgvQuestion.SelectedRows.Count > 0)
            {
                IdQuestionSelected = Convert.ToInt32(dgvQuestion.SelectedRows[0].Cells["colId"].Value);
                frmQuestionAddEdit frm = new frmQuestionAddEdit(IdQuestionSelected, _questionRepository, admin);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnQuestionDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete all slected question?", "Delete question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvQuestion.SelectedRows)
                {
                    // Delete answer of question
                    int id = (int)row.Cells["colId"].Value;
                    _questionRepository.DeleteAnswerByQuestionId(id);
                    _questionRepository.DeleteQuestion(id);
                }
                LoadData();
            }
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            if (dgvQuestion.SelectedRows.Count > 0)
            {
                IdQuestionSelected = Convert.ToInt32(dgvQuestion.SelectedRows[0].Cells["colId"].Value);
                frmQuestionAddEdit frm = new frmQuestionAddEdit(IdQuestionSelected, _questionRepository, admin);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
    }
}
