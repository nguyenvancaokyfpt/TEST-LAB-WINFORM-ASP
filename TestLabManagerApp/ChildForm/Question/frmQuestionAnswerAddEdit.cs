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

namespace TestLabManagerApp.ChildForm.Question
{
    public partial class frmQuestionAnswerAddEdit : Form
    {
        public TlAnswer answer { get; set; }
        public frmQuestionAnswerAddEdit(int qId)
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            if (inputAnswers.Text == "")
            {
                MessageBox.Show("Please input answer text");
                return;
            }
            else
            {
                answer = new TlAnswer();
                answer.AnswerText = inputAnswers.Text;
                answer.IsCorrect = false;
                // Random id
                answer.Id = new Random().Next(-9999, -1);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
