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
    public partial class frmStudentAdd : Form
    {
        private IStudentRepository _studentRepository;
        private TlStudent? _student;
        public frmStudentAdd(IStudentRepository rp)
        {
            InitializeComponent();
            _studentRepository = rp;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            _student = new TlStudent();
            _student.Fullname = inputFullname.Text;
            _student.Username = inputUsername.Text;
            _student.Password = inputPassword.Text;
            _studentRepository.AddStudent(_student);
            // exit with status ok
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
