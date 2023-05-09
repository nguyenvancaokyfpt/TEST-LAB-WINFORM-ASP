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
    public partial class frmCourseEdit : Form
    {
        IQuestionRepository _questionRepository;
        int CourseId = 0;
        public frmCourseEdit(IQuestionRepository rp, int id)
        {
            InitializeComponent();
            _questionRepository = rp;
            CourseId = id;
            LoadData();
        }

        public void LoadData()
        {
            TlCourse course = _questionRepository.GetCourseById(CourseId);
            inputCourse.Text = course.CourseName;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            TlCourse course = _questionRepository.GetCourseById(CourseId);
            if (course != null)
            {
                course.CourseName = inputCourse.Text;
                _questionRepository.UpdateCourse(course);
                // close with result OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Course not found");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
