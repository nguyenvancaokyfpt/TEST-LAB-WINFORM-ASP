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

namespace TestLabManagerApp.ChildForm.Course
{
    public partial class frmCourseAdd : Form
    {
        private IQuestionRepository _questionRepository;
        private TlAdmin _admin;
        public frmCourseAdd(IQuestionRepository rp, TlAdmin admin)
        {
            InitializeComponent();
            _questionRepository = rp;
            _admin = admin;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            TlCourse course = new TlCourse();
            course.CourseName = inputCourse.Text;
            course.CreateBy = _admin.Id;
            _questionRepository.AddCourse(course);
            // close with result OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
