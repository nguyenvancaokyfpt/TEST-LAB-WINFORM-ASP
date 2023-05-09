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
using TestLabManagerApp.ChildForm.Chapter;

namespace TestLabManagerApp.ChildForm
{
    public partial class frmChapter : Form
    {
        IQuestionRepository _questionRepository;
        int IdCourseSelected = 0;
        int IdChapterSelected = 0;
        string searchValue = "";
        List<TlCourse> courses = null;
        TlAdmin _admin = null;
        public frmChapter(IRepository rp)
        {
            InitializeComponent();
            _questionRepository = rp.QuestionRepository;
            _admin = rp.Admin;
            SetColums();
            LoadCourseFilter();
        }

        public void LoadCourseFilter()
        {
            courses = _questionRepository.GetCourses();
            if (courses.Count > 0)
            {
                IdCourseSelected = courses[0].Id;
                cbFilterByCourse.DataSource = courses;
                cbFilterByCourse.DisplayMember = "CourseName";
                cbFilterByCourse.ValueMember = "Id";
                LoadData();
            }
            else
            {
                cbFilterByCourse.DataSource = null;
            }
        }

        public void LoadData()
        {
            if (searchValue != "")
            {
                search();
            }
            else
            {
                List<TlChapter> chapters = _questionRepository.GetChapters(0, 9999, IdCourseSelected, "");
                if (chapters.Count > 0)
                {
                    dgvChapter.DataSource = chapters;
                }
                else
                {
                    dgvChapter.DataSource = null;
                }
            }
        }

        public void search()
        {
            List<TlChapter> chapters = _questionRepository.GetChapters(0, 9999, IdCourseSelected, searchValue);
            if (chapters.Count > 0)
            {
                dgvChapter.DataSource = chapters;
            }
            else
            {
                dgvChapter.DataSource = null;
            }
        }

        public void SetColums()
        {
            dgvChapter.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            dgvChapter.Columns.Add(colId);

            DataGridViewTextBoxColumn colChapterName = new DataGridViewTextBoxColumn();
            colChapterName.DataPropertyName = "ChapterName";
            colChapterName.HeaderText = "Chapter Name";
            colChapterName.Name = "colChapterName";
            colChapterName.ReadOnly = true;
            dgvChapter.Columns.Add(colChapterName);
        }

        private void btnAddChapter_Click(object sender, EventArgs e)
        {
            frmChapterAdd frm = new frmChapterAdd(_admin, IdCourseSelected, courses, _questionRepository);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnChapterCourse_Click(object sender, EventArgs e)
        {
            frmChapterEdit frm = new frmChapterEdit(IdChapterSelected, IdCourseSelected, courses, _questionRepository);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void cbFilterByCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdCourseSelected = (int)cbFilterByCourse.SelectedValue;
                LoadData();
            }
            catch
            {

            }
        }

        private void inputChapterSearch_TextChanged(object sender, EventArgs e)
        {
            searchValue = inputChapterSearch.Text;
            LoadData();
        }

        private void btnChapterSearch_Click(object sender, EventArgs e)
        {
            searchValue = inputChapterSearch.Text;
            LoadData();
        }

        private void btnChapterDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete all slected chapter?", "Delete chapter", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvChapter.SelectedRows)
                {
                    try
                    {
                        int id = (int)row.Cells["colId"].Value;
                        _questionRepository.DeleteChapter(id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error when delete chapter: " + row.Cells["colChapterName"].Value.ToString() + "\n" + ex.Message);
                    }
                }
                LoadData();
            }
        }

        private void dgvChapter_Click(object sender, EventArgs e)
        {
            try
            {
                IdChapterSelected = (int)dgvChapter.CurrentRow.Cells["colId"].Value;
            }
            catch (Exception ex)
            {
                IdChapterSelected = 0;
            }
        }

        private void dgvChapter_DoubleClick(object sender, EventArgs e)
        {
            IdChapterSelected = (int)dgvChapter.CurrentRow.Cells["colId"].Value;
            frmChapterEdit frm = new frmChapterEdit(IdChapterSelected, IdCourseSelected, courses, _questionRepository);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
