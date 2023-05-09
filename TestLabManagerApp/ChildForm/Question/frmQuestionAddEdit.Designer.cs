namespace TestLabManagerApp.ChildForm.Question
{
    partial class frmQuestionAddEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnQuestionTextAndImage = new Panel();
            splitContainer1 = new SplitContainer();
            inputQuestionText = new RichTextBox();
            pnHeaderQuestionText = new Panel();
            lblQuestionText = new Label();
            pnImage = new Panel();
            pbQuestionImage = new PictureBox();
            pnQuestionImageHeader = new Panel();
            btnChooseImage = new FontAwesome.Sharp.IconButton();
            lblQuestionImage = new Label();
            pnQuestionImage = new Panel();
            pnHeaderQuestionDetail = new Panel();
            pnlvAnswers = new Panel();
            dgvAnswer = new DataGridView();
            pnAnswerToolBox = new Panel();
            bntSave = new FontAwesome.Sharp.IconButton();
            btnDeleteAnswer = new FontAwesome.Sharp.IconButton();
            btnAddAnswer = new FontAwesome.Sharp.IconButton();
            pnDetailAnswerHeader = new Panel();
            lblAnswerList = new Label();
            pnQuestionDetail = new Panel();
            cbChapter = new ComboBox();
            lblChapter = new Label();
            cbCourse = new ComboBox();
            lblCourse = new Label();
            pnQuestionTextAndImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pnHeaderQuestionText.SuspendLayout();
            pnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQuestionImage).BeginInit();
            pnQuestionImageHeader.SuspendLayout();
            pnQuestionImage.SuspendLayout();
            pnHeaderQuestionDetail.SuspendLayout();
            pnlvAnswers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnswer).BeginInit();
            pnAnswerToolBox.SuspendLayout();
            pnDetailAnswerHeader.SuspendLayout();
            pnQuestionDetail.SuspendLayout();
            SuspendLayout();
            // 
            // pnQuestionTextAndImage
            // 
            pnQuestionTextAndImage.Controls.Add(splitContainer1);
            pnQuestionTextAndImage.Dock = DockStyle.Top;
            pnQuestionTextAndImage.Location = new Point(0, 0);
            pnQuestionTextAndImage.Margin = new Padding(3, 2, 3, 2);
            pnQuestionTextAndImage.Name = "pnQuestionTextAndImage";
            pnQuestionTextAndImage.Size = new Size(1074, 472);
            pnQuestionTextAndImage.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(inputQuestionText);
            splitContainer1.Panel1.Controls.Add(pnHeaderQuestionText);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Controls.Add(pnImage);
            splitContainer1.Panel2.Controls.Add(pnQuestionImageHeader);
            splitContainer1.Size = new Size(1074, 472);
            splitContainer1.SplitterDistance = 528;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // inputQuestionText
            // 
            inputQuestionText.Dock = DockStyle.Fill;
            inputQuestionText.Location = new Point(0, 25);
            inputQuestionText.Margin = new Padding(3, 2, 3, 2);
            inputQuestionText.Name = "inputQuestionText";
            inputQuestionText.Size = new Size(526, 445);
            inputQuestionText.TabIndex = 1;
            inputQuestionText.Text = "";
            // 
            // pnHeaderQuestionText
            // 
            pnHeaderQuestionText.BorderStyle = BorderStyle.FixedSingle;
            pnHeaderQuestionText.Controls.Add(lblQuestionText);
            pnHeaderQuestionText.Dock = DockStyle.Top;
            pnHeaderQuestionText.Location = new Point(0, 0);
            pnHeaderQuestionText.Margin = new Padding(3, 2, 3, 2);
            pnHeaderQuestionText.Name = "pnHeaderQuestionText";
            pnHeaderQuestionText.Size = new Size(526, 25);
            pnHeaderQuestionText.TabIndex = 0;
            // 
            // lblQuestionText
            // 
            lblQuestionText.AutoSize = true;
            lblQuestionText.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestionText.Location = new Point(10, 6);
            lblQuestionText.Name = "lblQuestionText";
            lblQuestionText.Size = new Size(91, 16);
            lblQuestionText.TabIndex = 14;
            lblQuestionText.Text = "Question Text: ";
            // 
            // pnImage
            // 
            pnImage.AutoScroll = true;
            pnImage.Controls.Add(pbQuestionImage);
            pnImage.Dock = DockStyle.Fill;
            pnImage.Location = new Point(0, 25);
            pnImage.Margin = new Padding(3, 2, 3, 2);
            pnImage.Name = "pnImage";
            pnImage.Size = new Size(540, 445);
            pnImage.TabIndex = 1;
            // 
            // pbQuestionImage
            // 
            pbQuestionImage.BorderStyle = BorderStyle.Fixed3D;
            pbQuestionImage.Location = new Point(0, 0);
            pbQuestionImage.Margin = new Padding(3, 2, 3, 2);
            pbQuestionImage.Name = "pbQuestionImage";
            pbQuestionImage.Size = new Size(1924, 1084);
            pbQuestionImage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbQuestionImage.TabIndex = 0;
            pbQuestionImage.TabStop = false;
            // 
            // pnQuestionImageHeader
            // 
            pnQuestionImageHeader.BorderStyle = BorderStyle.FixedSingle;
            pnQuestionImageHeader.Controls.Add(btnChooseImage);
            pnQuestionImageHeader.Controls.Add(lblQuestionImage);
            pnQuestionImageHeader.Dock = DockStyle.Top;
            pnQuestionImageHeader.Location = new Point(0, 0);
            pnQuestionImageHeader.Margin = new Padding(3, 2, 3, 2);
            pnQuestionImageHeader.Name = "pnQuestionImageHeader";
            pnQuestionImageHeader.Size = new Size(540, 25);
            pnQuestionImageHeader.TabIndex = 0;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChooseImage.BackColor = Color.FromArgb(191, 219, 57);
            btnChooseImage.Cursor = Cursors.Hand;
            btnChooseImage.FlatAppearance.BorderSize = 0;
            btnChooseImage.FlatStyle = FlatStyle.Flat;
            btnChooseImage.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChooseImage.ForeColor = Color.White;
            btnChooseImage.IconChar = FontAwesome.Sharp.IconChar.Image;
            btnChooseImage.IconColor = Color.White;
            btnChooseImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChooseImage.IconSize = 22;
            btnChooseImage.ImageAlign = ContentAlignment.MiddleRight;
            btnChooseImage.Location = new Point(398, 1);
            btnChooseImage.Margin = new Padding(3, 2, 3, 2);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(132, 22);
            btnChooseImage.TabIndex = 16;
            btnChooseImage.Text = "Choose Image";
            btnChooseImage.TextAlign = ContentAlignment.MiddleLeft;
            btnChooseImage.UseVisualStyleBackColor = false;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // lblQuestionImage
            // 
            lblQuestionImage.AutoSize = true;
            lblQuestionImage.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestionImage.Location = new Point(10, 5);
            lblQuestionImage.Name = "lblQuestionImage";
            lblQuestionImage.Size = new Size(103, 16);
            lblQuestionImage.TabIndex = 15;
            lblQuestionImage.Text = "Question Image:";
            // 
            // pnQuestionImage
            // 
            pnQuestionImage.BorderStyle = BorderStyle.FixedSingle;
            pnQuestionImage.Controls.Add(pnHeaderQuestionDetail);
            pnQuestionImage.Controls.Add(pnQuestionDetail);
            pnQuestionImage.Dock = DockStyle.Fill;
            pnQuestionImage.Location = new Point(0, 472);
            pnQuestionImage.Margin = new Padding(3, 2, 3, 2);
            pnQuestionImage.Name = "pnQuestionImage";
            pnQuestionImage.Size = new Size(1074, 271);
            pnQuestionImage.TabIndex = 1;
            // 
            // pnHeaderQuestionDetail
            // 
            pnHeaderQuestionDetail.Controls.Add(pnlvAnswers);
            pnHeaderQuestionDetail.Controls.Add(pnAnswerToolBox);
            pnHeaderQuestionDetail.Controls.Add(pnDetailAnswerHeader);
            pnHeaderQuestionDetail.Dock = DockStyle.Fill;
            pnHeaderQuestionDetail.Location = new Point(226, 0);
            pnHeaderQuestionDetail.Margin = new Padding(3, 2, 3, 2);
            pnHeaderQuestionDetail.Name = "pnHeaderQuestionDetail";
            pnHeaderQuestionDetail.Size = new Size(846, 269);
            pnHeaderQuestionDetail.TabIndex = 1;
            // 
            // pnlvAnswers
            // 
            pnlvAnswers.BorderStyle = BorderStyle.Fixed3D;
            pnlvAnswers.Controls.Add(dgvAnswer);
            pnlvAnswers.Dock = DockStyle.Fill;
            pnlvAnswers.Location = new Point(0, 29);
            pnlvAnswers.Margin = new Padding(3, 2, 3, 2);
            pnlvAnswers.Name = "pnlvAnswers";
            pnlvAnswers.Size = new Size(627, 240);
            pnlvAnswers.TabIndex = 2;
            // 
            // dgvAnswer
            // 
            dgvAnswer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnswer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnswer.Dock = DockStyle.Fill;
            dgvAnswer.Location = new Point(0, 0);
            dgvAnswer.Name = "dgvAnswer";
            dgvAnswer.RowTemplate.Height = 25;
            dgvAnswer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnswer.Size = new Size(623, 236);
            dgvAnswer.TabIndex = 0;
            dgvAnswer.Click += dgvAnswer_Click;
            dgvAnswer.DoubleClick += dgvAnswer_DoubleClick;
            // 
            // pnAnswerToolBox
            // 
            pnAnswerToolBox.BorderStyle = BorderStyle.Fixed3D;
            pnAnswerToolBox.Controls.Add(bntSave);
            pnAnswerToolBox.Controls.Add(btnDeleteAnswer);
            pnAnswerToolBox.Controls.Add(btnAddAnswer);
            pnAnswerToolBox.Dock = DockStyle.Right;
            pnAnswerToolBox.Location = new Point(627, 29);
            pnAnswerToolBox.Margin = new Padding(3, 2, 3, 2);
            pnAnswerToolBox.Name = "pnAnswerToolBox";
            pnAnswerToolBox.Size = new Size(219, 240);
            pnAnswerToolBox.TabIndex = 1;
            // 
            // bntSave
            // 
            bntSave.BackColor = Color.FromArgb(142, 167, 233);
            bntSave.Cursor = Cursors.Hand;
            bntSave.FlatAppearance.BorderSize = 0;
            bntSave.FlatStyle = FlatStyle.Flat;
            bntSave.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            bntSave.ForeColor = Color.White;
            bntSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            bntSave.IconColor = Color.White;
            bntSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntSave.IconSize = 30;
            bntSave.ImageAlign = ContentAlignment.MiddleLeft;
            bntSave.Location = new Point(18, 104);
            bntSave.Margin = new Padding(3, 2, 3, 2);
            bntSave.Name = "bntSave";
            bntSave.Size = new Size(164, 43);
            bntSave.TabIndex = 21;
            bntSave.Text = "Save Question";
            bntSave.TextAlign = ContentAlignment.MiddleRight;
            bntSave.UseVisualStyleBackColor = false;
            bntSave.Click += bntSave_Click;
            // 
            // btnDeleteAnswer
            // 
            btnDeleteAnswer.BackColor = Color.FromArgb(235, 70, 96);
            btnDeleteAnswer.Cursor = Cursors.Hand;
            btnDeleteAnswer.FlatAppearance.BorderSize = 0;
            btnDeleteAnswer.FlatStyle = FlatStyle.Flat;
            btnDeleteAnswer.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteAnswer.ForeColor = Color.White;
            btnDeleteAnswer.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnDeleteAnswer.IconColor = Color.White;
            btnDeleteAnswer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeleteAnswer.IconSize = 25;
            btnDeleteAnswer.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteAnswer.Location = new Point(30, 42);
            btnDeleteAnswer.Name = "btnDeleteAnswer";
            btnDeleteAnswer.Size = new Size(138, 32);
            btnDeleteAnswer.TabIndex = 12;
            btnDeleteAnswer.Text = "Delete";
            btnDeleteAnswer.UseVisualStyleBackColor = false;
            btnDeleteAnswer.Click += btnDeleteAnswer_Click;
            // 
            // btnAddAnswer
            // 
            btnAddAnswer.BackColor = Color.FromArgb(125, 185, 182);
            btnAddAnswer.Cursor = Cursors.Hand;
            btnAddAnswer.FlatAppearance.BorderSize = 0;
            btnAddAnswer.FlatStyle = FlatStyle.Flat;
            btnAddAnswer.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddAnswer.ForeColor = Color.White;
            btnAddAnswer.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAddAnswer.IconColor = Color.White;
            btnAddAnswer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddAnswer.IconSize = 25;
            btnAddAnswer.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddAnswer.Location = new Point(30, 4);
            btnAddAnswer.Name = "btnAddAnswer";
            btnAddAnswer.Size = new Size(138, 32);
            btnAddAnswer.TabIndex = 11;
            btnAddAnswer.Text = "Add";
            btnAddAnswer.UseVisualStyleBackColor = false;
            btnAddAnswer.Click += btnAddAnswer_Click;
            // 
            // pnDetailAnswerHeader
            // 
            pnDetailAnswerHeader.BorderStyle = BorderStyle.Fixed3D;
            pnDetailAnswerHeader.Controls.Add(lblAnswerList);
            pnDetailAnswerHeader.Dock = DockStyle.Top;
            pnDetailAnswerHeader.Location = new Point(0, 0);
            pnDetailAnswerHeader.Margin = new Padding(3, 2, 3, 2);
            pnDetailAnswerHeader.Name = "pnDetailAnswerHeader";
            pnDetailAnswerHeader.Size = new Size(846, 29);
            pnDetailAnswerHeader.TabIndex = 0;
            // 
            // lblAnswerList
            // 
            lblAnswerList.AutoSize = true;
            lblAnswerList.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnswerList.Location = new Point(4, 8);
            lblAnswerList.Name = "lblAnswerList";
            lblAnswerList.Size = new Size(128, 16);
            lblAnswerList.TabIndex = 19;
            lblAnswerList.Text = "Answer list ( Max 7 ) :";
            // 
            // pnQuestionDetail
            // 
            pnQuestionDetail.BorderStyle = BorderStyle.FixedSingle;
            pnQuestionDetail.Controls.Add(cbChapter);
            pnQuestionDetail.Controls.Add(lblChapter);
            pnQuestionDetail.Controls.Add(cbCourse);
            pnQuestionDetail.Controls.Add(lblCourse);
            pnQuestionDetail.Dock = DockStyle.Left;
            pnQuestionDetail.Location = new Point(0, 0);
            pnQuestionDetail.Margin = new Padding(3, 2, 3, 2);
            pnQuestionDetail.Name = "pnQuestionDetail";
            pnQuestionDetail.Size = new Size(226, 269);
            pnQuestionDetail.TabIndex = 0;
            // 
            // cbChapter
            // 
            cbChapter.FormattingEnabled = true;
            cbChapter.Location = new Point(10, 71);
            cbChapter.Margin = new Padding(3, 2, 3, 2);
            cbChapter.Name = "cbChapter";
            cbChapter.Size = new Size(206, 23);
            cbChapter.TabIndex = 18;
            cbChapter.SelectedIndexChanged += cbChapter_SelectedIndexChanged;
            // 
            // lblChapter
            // 
            lblChapter.AutoSize = true;
            lblChapter.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblChapter.Location = new Point(10, 56);
            lblChapter.Name = "lblChapter";
            lblChapter.Size = new Size(57, 16);
            lblChapter.TabIndex = 17;
            lblChapter.Text = "Chapter:";
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(10, 24);
            cbCourse.Margin = new Padding(3, 2, 3, 2);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(206, 23);
            cbCourse.TabIndex = 16;
            cbCourse.SelectedIndexChanged += cbCourse_SelectedIndexChanged;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCourse.Location = new Point(10, 8);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(51, 16);
            lblCourse.TabIndex = 15;
            lblCourse.Text = "Course:";
            // 
            // frmQuestionAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 743);
            Controls.Add(pnQuestionImage);
            Controls.Add(pnQuestionTextAndImage);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmQuestionAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Question";
            pnQuestionTextAndImage.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pnHeaderQuestionText.ResumeLayout(false);
            pnHeaderQuestionText.PerformLayout();
            pnImage.ResumeLayout(false);
            pnImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbQuestionImage).EndInit();
            pnQuestionImageHeader.ResumeLayout(false);
            pnQuestionImageHeader.PerformLayout();
            pnQuestionImage.ResumeLayout(false);
            pnHeaderQuestionDetail.ResumeLayout(false);
            pnlvAnswers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAnswer).EndInit();
            pnAnswerToolBox.ResumeLayout(false);
            pnDetailAnswerHeader.ResumeLayout(false);
            pnDetailAnswerHeader.PerformLayout();
            pnQuestionDetail.ResumeLayout(false);
            pnQuestionDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnQuestionTextAndImage;
        private SplitContainer splitContainer1;
        private Panel pnHeaderQuestionText;
        private RichTextBox inputQuestionText;
        private Label lblQuestionText;
        private Panel pnQuestionImageHeader;
        private Label lblQuestionImage;
        private FontAwesome.Sharp.IconButton btnChooseImage;
        private Panel pnQuestionImage;
        private Panel pnImage;
        private PictureBox pbQuestionImage;
        private Panel pnQuestionDetail;
        private ComboBox cbChapter;
        private Label lblChapter;
        private ComboBox cbCourse;
        private Label lblCourse;
        private Panel pnHeaderQuestionDetail;
        private Panel pnlvAnswers;
        private Panel pnAnswerToolBox;
        private Panel pnDetailAnswerHeader;
        private Label lblAnswerList;
        private FontAwesome.Sharp.IconButton btnDeleteAnswer;
        private FontAwesome.Sharp.IconButton btnAddAnswer;
        private FontAwesome.Sharp.IconButton bntSave;
        private DataGridView dgvAnswer;
    }
}