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

namespace TestLabManagerApp.ChildForm.Question
{
    public partial class frmQuestionAddEdit : Form
    {
        TlQuestion _question = new TlQuestion();
        int IdCourseSelected = 1;
        int IdChapterSelected = 1;
        int IdAnswerSelected = 1;
        List<TlAnswer> _answers = new List<TlAnswer>();
        IQuestionRepository _questionRepository;
        TlAdmin ad = null;
        public frmQuestionAddEdit(int qId, IQuestionRepository rp, TlAdmin ad, int cid = 1, int chid = 1)
        {
            InitializeComponent();
            this._questionRepository = rp;
            this.ad = ad;
            this.IdCourseSelected = cid;
            this.IdChapterSelected = chid;
            SetColums();
            isEdit(qId);
            LoadCourseFilter();
            LoadChapterFilter();
        }

        public void SetColums()
        {
            dgvAnswer.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.Visible = false;
            dgvAnswer.Columns.Add(colId);

            DataGridViewTextBoxColumn colAnswerText = new DataGridViewTextBoxColumn();
            colAnswerText.DataPropertyName = "AnswerText";
            colAnswerText.HeaderText = "Answer Text";
            colAnswerText.Name = "colAnswerText";
            colAnswerText.ReadOnly = true;
            dgvAnswer.Columns.Add(colAnswerText);

            DataGridViewCheckBoxColumn colIsCorrect = new DataGridViewCheckBoxColumn();
            colIsCorrect.DataPropertyName = "IsCorrect";
            colIsCorrect.HeaderText = "Is Correct";
            colIsCorrect.Name = "colIsCorrect";
            dgvAnswer.Columns.Add(colIsCorrect);

        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            try
            {
                if (blob != null)
                {
                    MemoryStream mStream = new MemoryStream();
                    byte[] pData = blob;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    Bitmap bm = new Bitmap(mStream, false);
                    mStream.Dispose();
                    return bm;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                throw;
            }
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public void isEdit(int qId)
        {
            if (qId != -1)
            {
                _question = _questionRepository.GetQuestion(qId);
                if (_question != null)
                {
                    inputQuestionText.Text = _question.QuestionText;
                    IdCourseSelected = _question.CourseId;
                    IdChapterSelected = _question.ChapterId;
                    _answers = _questionRepository.GetAnswers(qId);
                    dgvAnswer.DataSource = _answers;
                    try
                    {
                        pbQuestionImage.Image = ByteToImage(_question.QuestionImage);
                    }
                    catch
                    {

                    }
                }
            }
        }

        public void LoadCourseFilter()
        {
            var courses = _questionRepository.GetCourses();
            if (courses.Count > 0)
            {
                cbCourse.DataSource = courses;
                cbCourse.DisplayMember = "CourseName";
                cbCourse.ValueMember = "Id";
                cbCourse.SelectedValue = IdCourseSelected;
            }
            else
            {
                cbCourse.DataSource = null;
            }
        }

        public void LoadChapterFilter()
        {
            var chapters = _questionRepository.GetChapters(0, 999, IdCourseSelected);
            if (chapters.Count > 0)
            {
                cbChapter.DataSource = chapters;
                cbChapter.DisplayMember = "ChapterName";
                cbChapter.ValueMember = "Id";
                if (IdChapterSelected != -1)
                {
                    cbChapter.SelectedValue = IdChapterSelected;
                }
                else
                {
                    cbChapter.SelectedIndex = chapters[0].Id;
                }
            }
            else
            {
                cbChapter.DataSource = null;
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            frmQuestionAnswerAddEdit frm = new frmQuestionAnswerAddEdit(-1);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _answers.Add(frm.answer);
                dgvAnswer.DataSource = null;
                dgvAnswer.DataSource = _answers;
            }
        }

        private void btnDeleteAnswer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete all slected Answer?", "Delete answer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvAnswer.SelectedRows)
                {
                    int id = (int)row.Cells["colId"].Value;
                    if (id > 0)
                    {
                        _questionRepository.DeleteAnswer(id);
                    }
                    _answers.Remove(_answers.Where(x => x.Id == id).FirstOrDefault());
                }
            }
            dgvAnswer.DataSource = null;
            dgvAnswer.DataSource = _answers;
        }

        private void dgvAnswer_Click(object sender, EventArgs e)
        {
            if (dgvAnswer.SelectedRows.Count > 0)
            {
                IdAnswerSelected = Convert.ToInt32(dgvAnswer.SelectedRows[0].Cells["colId"].Value);
            }
        }

        private void dgvAnswer_DoubleClick(object sender, EventArgs e)
        {

        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            _question.QuestionText = inputQuestionText.Text;
            _question.CourseId = IdCourseSelected;
            _question.ChapterId = IdChapterSelected;
            _question.QuestionImage = pbQuestionImage.Image == null ? null : ImageToByteArray(pbQuestionImage.Image);
            if (_question.Id > 0)
            {
                _questionRepository.UpdateQuestion(_question);
                foreach (var item in _answers)
                {
                    if (item.Id > 0)
                    {
                        _questionRepository.UpdateAnswer(item);
                    }
                    else
                    {
                        TlAnswer newA = new TlAnswer();
                        newA.AnswerText = item.AnswerText;
                        newA.IsCorrect = item.IsCorrect;
                        newA.QuestionId = _question.Id;
                        newA.CreateBy = ad.Id;
                        _questionRepository.AddAnswer(newA);
                    }
                }
            }
            else
            {
                TlQuestion newQ = new TlQuestion();
                newQ.QuestionText = _question.QuestionText;
                newQ.CourseId = _question.CourseId;
                newQ.ChapterId = _question.ChapterId;
                newQ.QuestionImage = _question.QuestionImage;
                newQ.CreateBy = ad.Id;
                int id = _questionRepository.AddQuestion(newQ);
                foreach (var item in _answers)
                {
                    TlAnswer newA = new TlAnswer();
                    newA.AnswerText = item.AnswerText;
                    newA.IsCorrect = item.IsCorrect;
                    newA.QuestionId = id;
                    newA.CreateBy = ad.Id;
                    _questionRepository.AddAnswer(newA);
                }
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdCourseSelected = Convert.ToInt32(cbCourse.SelectedValue);
            }
            catch
            {

            }
            LoadChapterFilter();
        }

        private void cbChapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdChapterSelected = Convert.ToInt32(cbChapter.SelectedValue);
            }
            catch
            {

            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbQuestionImage.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
