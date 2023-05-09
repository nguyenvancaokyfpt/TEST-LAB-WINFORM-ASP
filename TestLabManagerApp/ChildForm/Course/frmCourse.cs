using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLabManagerApp.ChildForm.Course;
using TestLabLibrary.Repository;
using TestLabEntity;
using TestLabEntity.AutoDB;

namespace TestLabManagerApp.ChildForm
{
    public partial class frmCourse : Form
    {
        IQuestionRepository _questionRepository;
        TlAdmin _admin;
        int idCourseSelected = 0;
        string searchValue = "";
        public frmCourse(IRepository rp)
        {
            InitializeComponent();
            _questionRepository = rp.QuestionRepository;
            _admin = rp.Admin;
            SetColums();
            LoadData();
        }

        public void SetColums()
        {
            dgvCourse.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            dgvCourse.Columns.Add(colId);

            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.DataPropertyName = "CourseName";
            colName.HeaderText = "Course Name";
            colName.Name = "colCourseName";
            colName.ReadOnly = true;
            dgvCourse.Columns.Add(colName);
        }

        public void LoadData()
        {
            if (searchValue != "")
            {
                search();
            }
            else
            {
                List<TlCourse> courses = _questionRepository.GetCourses();
                dgvCourse.DataSource = courses;
            }
        }

        public void search()
        {
            List<TlCourse> courses = _questionRepository.GetCourses(0, 9999, searchValue);
            dgvCourse.DataSource = courses;
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmCourseAdd frm = new frmCourseAdd(_questionRepository, _admin);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnStudentCourse_Click(object sender, EventArgs e)
        {
            frmCourseEdit frm = new frmCourseEdit(_questionRepository, idCourseSelected);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnCourseDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete all slected student?", "Delete student", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvCourse.SelectedRows)
                {
                    int id = (int)row.Cells["colId"].Value;
                    _questionRepository.DeleteCourse(id);
                }
                LoadData();
            }
        }

        private void btnCourseSearch_Click(object sender, EventArgs e)
        {
            searchValue = inputCourseSearch.Text;
            LoadData();
        }

        private void inputCourseSearch_TextChanged(object sender, EventArgs e)
        {
            searchValue = inputCourseSearch.Text;
            LoadData();
        }

        private void dgvCourse_Click(object sender, EventArgs e)
        {

            idCourseSelected = dgvCourse.Rows[dgvCourse.CurrentCell.RowIndex].Cells["colId"].Value != null ? Convert.ToInt32(dgvCourse.Rows[dgvCourse.CurrentCell.RowIndex].Cells["colId"].Value) : 0;
        }

        private void dgvCourse_DoubleClick(object sender, EventArgs e)
        {
            frmCourseEdit frm = new frmCourseEdit(_questionRepository, idCourseSelected);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
