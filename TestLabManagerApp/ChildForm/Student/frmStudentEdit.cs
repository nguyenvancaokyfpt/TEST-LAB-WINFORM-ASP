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
using TestLabEntity.AutoDB;

namespace TestLabManagerApp.ChildForm.Student
{
    public partial class frmStudentEdit : Form
    {
        private IStudentRepository _studentRepository;
        private TlStudent? _student;
        public frmStudentEdit(int id, IStudentRepository rp)
        {
            InitializeComponent();
            _studentRepository = rp;
            LoadData(id);
        }

        public void LoadData(int id)
        {
            _student = _studentRepository.GetStudent(id);
            if (_student != null)
            {
                inputFullname.Text = _student.Fullname;
                inputUsername.Text = _student.Username;
                inputPassword.Text = _student.Password;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (_student != null)
            {
                _student.Fullname = inputFullname.Text;
                _student.Username = inputUsername.Text;
                _student.Password = inputPassword.Text;
                _studentRepository.UpdateStudent(_student);
                // exit with status ok
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Student not found");
                this.Close();
            }
        }
    }
}
