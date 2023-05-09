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
    public partial class frmTestPaperAddEdit : Form
    {
        IPaperRepository _paperRepository;
        IQuestionRepository _questionRepository;
        int IdPaperSelected = 0;
        int IdCourseSelected = 0;
        TlAdmin admin;
        List<TlQuestion> questons = new List<TlQuestion>();
        public frmTestPaperAddEdit(int IdPaperSelected, int IdCourseSelected, IPaperRepository _paperRepository, IQuestionRepository _questionRepository, TlAdmin admin)
        {
            InitializeComponent();
            this.IdPaperSelected = IdPaperSelected;
            this.IdCourseSelected = IdCourseSelected;
            this._paperRepository = _paperRepository;
            this._questionRepository = _questionRepository;
            this.admin = admin;
            SetColums();
            isEdit(IdPaperSelected);
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

        public void isEdit(int IdPaperSelected)
        {
            if (IdPaperSelected > 0)
            {
                var paper = _paperRepository.GetPaper(IdPaperSelected);
                inputPaperName.Text = paper.PaperName;
                inputPaperCode.Text = paper.PaperCode;
                inputDuration.Text = paper.Duration.ToString();
                inputQuestionNum.Text = paper.QuestionNum.ToString();
                dtStartTime.Value = (DateTime)paper.StartTime;
                dtEndTime.Value = (DateTime)paper.EndTime;
                checkIsOpent.Checked = paper.IsOpen;
                questons = _questionRepository.GetQuestionsByPaperId(IdPaperSelected);
                lblCountQuestion.Text = questons.Count.ToString();
                dgvQuestion.DataSource = null;
                dgvQuestion.DataSource = questons;
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmTestPaperAddQuestion frm = new frmTestPaperAddQuestion(IdCourseSelected, _questionRepository);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<int> listIdQuestion = frm.id_questions;
                foreach (var item in listIdQuestion)
                {
                    // check question is exist
                    if (questons.Where(x => x.Id == item).Count() == 0)
                    {
                        var question = _questionRepository.GetQuestion(item);
                        questons.Add(question);
                    }
                }
                dgvQuestion.DataSource = null;
                dgvQuestion.DataSource = questons;
                lblCountQuestion.Text = dgvQuestion.Rows.Count.ToString();
            }
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete all slected question?", "Delete question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvQuestion.SelectedRows)
                {
                    // Delete answer of question
                    int id = (int)row.Cells["colId"].Value;
                    questons.Remove(questons.Where(x => x.Id == id).FirstOrDefault());
                }
            }
            dgvQuestion.DataSource = null;
            dgvQuestion.DataSource = questons;
            lblCountQuestion.Text = dgvQuestion.Rows.Count.ToString();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            if (IdPaperSelected > 0)
            {
                var paper = _paperRepository.GetPaper(IdPaperSelected);
                paper.PaperName = inputPaperName.Text;
                paper.PaperCode = inputPaperCode.Text;
                paper.Duration = int.Parse(inputDuration.Text);
                paper.QuestionNum = int.Parse(inputQuestionNum.Text);
                paper.StartTime = dtStartTime.Value;
                paper.EndTime = dtEndTime.Value;
                paper.IsOpen = checkIsOpent.Checked;
                paper.CourseId = IdCourseSelected;
                if (paper.QuestionNum > questons.Count)
                {
                    paper.QuestionNum = questons.Count;
                }
                _paperRepository.UpdatePaper(paper);
                _questionRepository.DeleteAllQuestionByPaperId(IdPaperSelected);
                foreach (var item in questons)
                {
                    _questionRepository.AddQuestionToPaper(item.Id, IdPaperSelected);
                }
                this.Close();
            }
            else
            {
                TlPaper paper = new TlPaper();
                paper.PaperName = inputPaperName.Text;
                paper.PaperCode = inputPaperCode.Text;
                paper.Duration = int.Parse(inputDuration.Text);
                paper.QuestionNum = int.Parse(inputQuestionNum.Text);
                paper.StartTime = dtStartTime.Value;
                paper.EndTime = dtEndTime.Value;
                paper.IsOpen = checkIsOpent.Checked;
                paper.CourseId = IdCourseSelected;
                if (paper.QuestionNum > questons.Count)
                {
                    paper.QuestionNum = questons.Count;
                }
                paper.CreateBy = admin.Id;
                int id = _paperRepository.AddPaper(paper);
                foreach (var item in questons)
                {
                    _questionRepository.AddQuestionToPaper(item.Id, id);
                }
            }
            this.Close();
        }

        private void dgvQuestion_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lblCountQuestion.Text = dgvQuestion.Rows.Count.ToString();
        }
    }
}
