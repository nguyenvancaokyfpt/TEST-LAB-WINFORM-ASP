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
using TestLabManagerApp.ChildForm.TestPaper;

namespace TestLabManagerApp.ChildForm
{
    public partial class frmTestPaper : Form
    {
        IPaperRepository _paperRepository;
        IQuestionRepository _questionRepository;
        int IdPaperSelected = 0;
        int IdCourseSelected = 1;
        string SearchValue = "";
        TlAdmin admin;
        public frmTestPaper(IRepository rp)
        {
            InitializeComponent();
            _paperRepository = rp.PaperRepository;
            _questionRepository = rp.QuestionRepository;
            admin = rp.Admin;
            SetColums();
            LoadCourseFilter();
            LoadData();
        }

        public void LoadCourseFilter()
        {
            var courses = _questionRepository.GetCourses();
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

        public void SetColums()
        {
            dgvTestPaper.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.Visible = false;
            dgvTestPaper.Columns.Add(colId);

            DataGridViewTextBoxColumn colPaperName = new DataGridViewTextBoxColumn();
            colPaperName.DataPropertyName = "PaperName";
            colPaperName.HeaderText = "Paper Name";
            colPaperName.Name = "colPaperName";
            dgvTestPaper.Columns.Add(colPaperName);

            DataGridViewTextBoxColumn colPaperCode = new DataGridViewTextBoxColumn();
            colPaperCode.DataPropertyName = "PaperCode";
            colPaperCode.HeaderText = "Paper Code";
            colPaperCode.Name = "colPaperCode";
            dgvTestPaper.Columns.Add(colPaperCode);

            DataGridViewTextBoxColumn colQuestionNum = new DataGridViewTextBoxColumn();
            colQuestionNum.DataPropertyName = "QuestionNum";
            colQuestionNum.HeaderText = "Question Num";
            colQuestionNum.Name = "colQuestionNum";
            dgvTestPaper.Columns.Add(colQuestionNum);

            DataGridViewTextBoxColumn colDuration = new DataGridViewTextBoxColumn();
            colDuration.DataPropertyName = "Duration";
            colDuration.HeaderText = "Duration";
            colDuration.Name = "colDuration";
            dgvTestPaper.Columns.Add(colDuration);

            DataGridViewTextBoxColumn colStartTime = new DataGridViewTextBoxColumn();
            colStartTime.DataPropertyName = "StartTime";
            colStartTime.HeaderText = "Start Time";
            colStartTime.Name = "colStartTime";
            dgvTestPaper.Columns.Add(colStartTime);

            DataGridViewTextBoxColumn colEndTime = new DataGridViewTextBoxColumn();
            colEndTime.DataPropertyName = "EndTime";
            colEndTime.HeaderText = "End Time";
            colEndTime.Name = "colEndTime";
            dgvTestPaper.Columns.Add(colEndTime);

            DataGridViewTextBoxColumn colIsOpen = new DataGridViewTextBoxColumn();
            colIsOpen.DataPropertyName = "IsOpen";
            colIsOpen.HeaderText = "Is Open";
            colIsOpen.Name = "colIsOpen";
            dgvTestPaper.Columns.Add(colIsOpen);


        }

        public void LoadData()
        {
            List<TlPaper> papers = _paperRepository.GetPapersByCourseId(IdCourseSelected, SearchValue);
            dgvTestPaper.DataSource = null;
            dgvTestPaper.DataSource = papers;
        }



        private void btnAddTestPaper_Click(object sender, EventArgs e)
        {
            frmTestPaperAddEdit frm = new frmTestPaperAddEdit(-1, IdCourseSelected, _paperRepository, _questionRepository, admin);
            frm.ShowDialog();
            LoadData();
        }

        private void btnEditTestPaper_Click(object sender, EventArgs e)
        {
            frmTestPaperAddEdit frm = new frmTestPaperAddEdit(IdPaperSelected, IdCourseSelected, _paperRepository, _questionRepository, admin);
            frm.ShowDialog();
            LoadData();
        }

        private void cbFilterByCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdCourseSelected = int.Parse(cbFilterByCourse.SelectedValue.ToString());
                LoadData();
            }
            catch (Exception ex)
            {

            }
        }

        private void inputQuestionSearch_TextChanged(object sender, EventArgs e)
        {
            SearchValue = inputQuestionSearch.Text;
            LoadData();
        }

        private void btnQuestionSearch_Click(object sender, EventArgs e)
        {
            SearchValue = inputQuestionSearch.Text;
            LoadData();
        }

        private void btnTestPaperDelete_Click(object sender, EventArgs e)
        {
            if (IdPaperSelected > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete this paper?", "Delete Paper", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _paperRepository.DeletePaper(IdPaperSelected);
                    LoadData();
                }
            }
        }

        private void dgvTestPaper_Click(object sender, EventArgs e)
        {
            if (dgvTestPaper.SelectedRows.Count > 0)
            {
                IdPaperSelected = Convert.ToInt32(dgvTestPaper.SelectedRows[0].Cells["colId"].Value);
            }
        }

        private void dgvTestPaper_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTestPaper.SelectedRows.Count > 0)
            {
                IdPaperSelected = Convert.ToInt32(dgvTestPaper.SelectedRows[0].Cells["colId"].Value);
                frmTestPaperAddEdit frm = new frmTestPaperAddEdit(IdPaperSelected, IdCourseSelected, _paperRepository, _questionRepository, admin);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void pnTestPaperHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
