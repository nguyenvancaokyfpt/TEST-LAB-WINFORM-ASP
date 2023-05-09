using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLabManagerApp.ChildForm.Student;
using TestLabLibrary.Repository;
using TestLabEntity.AutoDB;

namespace TestLabManagerApp.ChildForm
{
    public partial class frmStudent : Form
    {
        IStudentRepository _studentRepository;
        BindingSource _studentBindingSource = new BindingSource();
        int idStudentSelected = 0;
        string searchValue = "";
        public frmStudent(IRepository rp)
        {
            InitializeComponent();
            _studentRepository = rp.StudentRepository;
            SetColums();
            LoadData();
            // Set selected row
            if (dgvStudents.Rows.Count > 0)
            {
                dgvStudents.Rows[idStudentSelected].Selected = true;
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
                List<TlStudent> students = _studentRepository.GetStudents();
                _studentBindingSource.DataSource = students;
                dgvStudents.AutoGenerateColumns = false;
                dgvStudents.DataSource = _studentBindingSource;
            }

        }

        public void SetColums()
        {
            dgvStudents.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            dgvStudents.Columns.Add(colId);

            DataGridViewTextBoxColumn colFullname = new DataGridViewTextBoxColumn();
            colFullname.DataPropertyName = "Fullname";
            colFullname.HeaderText = "Fullname";
            colFullname.Name = "colFullname";
            colFullname.ReadOnly = true;
            dgvStudents.Columns.Add(colFullname);

            DataGridViewTextBoxColumn colUsername = new DataGridViewTextBoxColumn();
            colUsername.DataPropertyName = "Username";
            colUsername.HeaderText = "Username";
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            dgvStudents.Columns.Add(colUsername);

            DataGridViewTextBoxColumn colPassword = new DataGridViewTextBoxColumn();
            colPassword.DataPropertyName = "Password";
            colPassword.HeaderText = "Password";
            colPassword.Name = "colPassword";
            colPassword.ReadOnly = true;
            dgvStudents.Columns.Add(colPassword);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmStudentAdd frm = new frmStudentAdd(_studentRepository);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnStudentEdit_Click(object sender, EventArgs e)
        {
            frmStudentEdit frm = new frmStudentEdit(idStudentSelected, _studentRepository);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete all slected student?", "Delete student", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvStudents.SelectedRows)
                {
                    int id = (int)row.Cells["colId"].Value;
                    _studentRepository.DeleteStudent(id);
                }
                LoadData();
            }
        }

        public void RefreshData()
        {
            LoadData();
        }

        private void search()
        {
            List<TlStudent> students = _studentRepository.GetStudents(0, 9999, searchValue);
            _studentBindingSource.DataSource = students;
            dgvStudents.DataSource = _studentBindingSource;
        }

        private void inputStudentSearch_TextChanged(object sender, EventArgs e)
        {
            searchValue = inputStudentSearch.Text;
            search();
        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void dgvStudents_DoubleClick(object sender, EventArgs e)
        {
            frmStudentEdit frm = new frmStudentEdit(idStudentSelected, _studentRepository);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvStudents_Click(object sender, EventArgs e)
        {
            // Get id student of row selected
            idStudentSelected = dgvStudents.Rows[dgvStudents.CurrentRow.Index].Cells[0].Value != null ? (int)dgvStudents.Rows[dgvStudents.CurrentRow.Index].Cells[0].Value : 0;
        }
    }
}
