namespace TestLabManagerApp.ChildForm.TestPaper
{
    partial class frmTestPaperAddEdit
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
            lblPaperName = new Label();
            inputPaperName = new TextBox();
            pnTestPaperAddHeader = new Panel();
            inputDuration = new TextBox();
            lblDuration = new Label();
            dtEndTime = new DateTimePicker();
            lblEndTime = new Label();
            dtStartTime = new DateTimePicker();
            lblStartTime = new Label();
            checkIsOpent = new CheckBox();
            inputQuestionNum = new TextBox();
            lblNumberQuestion = new Label();
            inputPaperCode = new TextBox();
            lblPaperCode = new Label();
            pnTestPaperToolBox = new Panel();
            bntAdd = new FontAwesome.Sharp.IconButton();
            btnStudentDelete = new FontAwesome.Sharp.IconButton();
            btnAddStudent = new FontAwesome.Sharp.IconButton();
            pnTestPaperView = new Panel();
            dgvQuestion = new DataGridView();
            pnTestPaperViewHeader = new Panel();
            lblCountQuestion = new Label();
            lblCount = new Label();
            lblLQOT = new Label();
            pnTestPaperAddHeader.SuspendLayout();
            pnTestPaperToolBox.SuspendLayout();
            pnTestPaperView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).BeginInit();
            pnTestPaperViewHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblPaperName
            // 
            lblPaperName.AutoSize = true;
            lblPaperName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaperName.Location = new Point(10, 10);
            lblPaperName.Name = "lblPaperName";
            lblPaperName.Size = new Size(96, 19);
            lblPaperName.TabIndex = 15;
            lblPaperName.Text = "Paper Name";
            // 
            // inputPaperName
            // 
            inputPaperName.Location = new Point(10, 27);
            inputPaperName.Margin = new Padding(3, 2, 3, 2);
            inputPaperName.Name = "inputPaperName";
            inputPaperName.Size = new Size(263, 23);
            inputPaperName.TabIndex = 14;
            // 
            // pnTestPaperAddHeader
            // 
            pnTestPaperAddHeader.Controls.Add(inputDuration);
            pnTestPaperAddHeader.Controls.Add(lblDuration);
            pnTestPaperAddHeader.Controls.Add(dtEndTime);
            pnTestPaperAddHeader.Controls.Add(lblEndTime);
            pnTestPaperAddHeader.Controls.Add(dtStartTime);
            pnTestPaperAddHeader.Controls.Add(lblStartTime);
            pnTestPaperAddHeader.Controls.Add(checkIsOpent);
            pnTestPaperAddHeader.Controls.Add(inputQuestionNum);
            pnTestPaperAddHeader.Controls.Add(lblNumberQuestion);
            pnTestPaperAddHeader.Controls.Add(inputPaperCode);
            pnTestPaperAddHeader.Controls.Add(lblPaperCode);
            pnTestPaperAddHeader.Controls.Add(inputPaperName);
            pnTestPaperAddHeader.Controls.Add(lblPaperName);
            pnTestPaperAddHeader.Dock = DockStyle.Top;
            pnTestPaperAddHeader.Location = new Point(0, 0);
            pnTestPaperAddHeader.Margin = new Padding(3, 2, 3, 2);
            pnTestPaperAddHeader.Name = "pnTestPaperAddHeader";
            pnTestPaperAddHeader.Size = new Size(970, 108);
            pnTestPaperAddHeader.TabIndex = 16;
            // 
            // inputDuration
            // 
            inputDuration.Location = new Point(640, 71);
            inputDuration.Margin = new Padding(3, 2, 3, 2);
            inputDuration.Name = "inputDuration";
            inputDuration.Size = new Size(136, 23);
            inputDuration.TabIndex = 26;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDuration.Location = new Point(640, 54);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(68, 19);
            lblDuration.TabIndex = 27;
            lblDuration.Text = "Duration";
            // 
            // dtEndTime
            // 
            dtEndTime.CustomFormat = "MM/dd/yyyy - hh:mm:ss";
            dtEndTime.Format = DateTimePickerFormat.Custom;
            dtEndTime.Location = new Point(327, 71);
            dtEndTime.Margin = new Padding(3, 2, 3, 2);
            dtEndTime.Name = "dtEndTime";
            dtEndTime.Size = new Size(263, 23);
            dtEndTime.TabIndex = 25;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndTime.Location = new Point(327, 53);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(70, 19);
            lblEndTime.TabIndex = 24;
            lblEndTime.Text = "End Time";
            // 
            // dtStartTime
            // 
            dtStartTime.CustomFormat = "MM/dd/yyyy - hh:mm:ss";
            dtStartTime.Format = DateTimePickerFormat.Custom;
            dtStartTime.Location = new Point(10, 71);
            dtStartTime.Margin = new Padding(3, 2, 3, 2);
            dtStartTime.Name = "dtStartTime";
            dtStartTime.Size = new Size(263, 23);
            dtStartTime.TabIndex = 23;
            dtStartTime.Value = new DateTime(2023, 3, 9, 0, 0, 0, 0);
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblStartTime.Location = new Point(10, 53);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(74, 19);
            lblStartTime.TabIndex = 22;
            lblStartTime.Text = "Start Time";
            // 
            // checkIsOpent
            // 
            checkIsOpent.AutoSize = true;
            checkIsOpent.Location = new Point(836, 76);
            checkIsOpent.Margin = new Padding(3, 2, 3, 2);
            checkIsOpent.Name = "checkIsOpent";
            checkIsOpent.Size = new Size(66, 19);
            checkIsOpent.TabIndex = 20;
            checkIsOpent.Text = "Is Open";
            checkIsOpent.UseVisualStyleBackColor = true;
            // 
            // inputQuestionNum
            // 
            inputQuestionNum.Location = new Point(640, 27);
            inputQuestionNum.Margin = new Padding(3, 2, 3, 2);
            inputQuestionNum.Name = "inputQuestionNum";
            inputQuestionNum.Size = new Size(136, 23);
            inputQuestionNum.TabIndex = 18;
            // 
            // lblNumberQuestion
            // 
            lblNumberQuestion.AutoSize = true;
            lblNumberQuestion.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumberQuestion.Location = new Point(640, 10);
            lblNumberQuestion.Name = "lblNumberQuestion";
            lblNumberQuestion.Size = new Size(129, 19);
            lblNumberQuestion.TabIndex = 19;
            lblNumberQuestion.Text = "Number Question";
            // 
            // inputPaperCode
            // 
            inputPaperCode.Location = new Point(327, 27);
            inputPaperCode.Margin = new Padding(3, 2, 3, 2);
            inputPaperCode.Name = "inputPaperCode";
            inputPaperCode.Size = new Size(263, 23);
            inputPaperCode.TabIndex = 16;
            // 
            // lblPaperCode
            // 
            lblPaperCode.AutoSize = true;
            lblPaperCode.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaperCode.Location = new Point(327, 10);
            lblPaperCode.Name = "lblPaperCode";
            lblPaperCode.Size = new Size(93, 19);
            lblPaperCode.TabIndex = 17;
            lblPaperCode.Text = "Paper Code";
            // 
            // pnTestPaperToolBox
            // 
            pnTestPaperToolBox.BorderStyle = BorderStyle.FixedSingle;
            pnTestPaperToolBox.Controls.Add(bntAdd);
            pnTestPaperToolBox.Controls.Add(btnStudentDelete);
            pnTestPaperToolBox.Controls.Add(btnAddStudent);
            pnTestPaperToolBox.Dock = DockStyle.Right;
            pnTestPaperToolBox.Location = new Point(762, 108);
            pnTestPaperToolBox.Margin = new Padding(3, 2, 3, 2);
            pnTestPaperToolBox.Name = "pnTestPaperToolBox";
            pnTestPaperToolBox.Size = new Size(208, 406);
            pnTestPaperToolBox.TabIndex = 17;
            // 
            // bntAdd
            // 
            bntAdd.BackColor = Color.FromArgb(142, 167, 233);
            bntAdd.Cursor = Cursors.Hand;
            bntAdd.FlatAppearance.BorderSize = 0;
            bntAdd.FlatStyle = FlatStyle.Flat;
            bntAdd.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bntAdd.ForeColor = Color.White;
            bntAdd.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            bntAdd.IconColor = Color.White;
            bntAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntAdd.IconSize = 25;
            bntAdd.ImageAlign = ContentAlignment.MiddleLeft;
            bntAdd.Location = new Point(29, 111);
            bntAdd.Margin = new Padding(3, 2, 3, 2);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(138, 34);
            bntAdd.TabIndex = 7;
            bntAdd.Text = "Save";
            bntAdd.UseVisualStyleBackColor = false;
            bntAdd.Click += bntAdd_Click;
            // 
            // btnStudentDelete
            // 
            btnStudentDelete.BackColor = Color.FromArgb(235, 70, 96);
            btnStudentDelete.Cursor = Cursors.Hand;
            btnStudentDelete.FlatAppearance.BorderSize = 0;
            btnStudentDelete.FlatStyle = FlatStyle.Flat;
            btnStudentDelete.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudentDelete.ForeColor = Color.White;
            btnStudentDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnStudentDelete.IconColor = Color.White;
            btnStudentDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStudentDelete.IconSize = 25;
            btnStudentDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudentDelete.Location = new Point(29, 64);
            btnStudentDelete.Name = "btnStudentDelete";
            btnStudentDelete.Size = new Size(138, 32);
            btnStudentDelete.TabIndex = 4;
            btnStudentDelete.Text = "Delete";
            btnStudentDelete.UseVisualStyleBackColor = false;
            btnStudentDelete.Click += btnStudentDelete_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(125, 185, 182);
            btnAddStudent.Cursor = Cursors.Hand;
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAddStudent.IconColor = Color.White;
            btnAddStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddStudent.IconSize = 25;
            btnAddStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddStudent.Location = new Point(29, 17);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(138, 32);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Add Question";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // pnTestPaperView
            // 
            pnTestPaperView.Controls.Add(dgvQuestion);
            pnTestPaperView.Controls.Add(pnTestPaperViewHeader);
            pnTestPaperView.Dock = DockStyle.Fill;
            pnTestPaperView.Location = new Point(0, 108);
            pnTestPaperView.Margin = new Padding(3, 2, 3, 2);
            pnTestPaperView.Name = "pnTestPaperView";
            pnTestPaperView.Size = new Size(762, 406);
            pnTestPaperView.TabIndex = 18;
            // 
            // dgvQuestion
            // 
            dgvQuestion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestion.Dock = DockStyle.Fill;
            dgvQuestion.Location = new Point(0, 30);
            dgvQuestion.Name = "dgvQuestion";
            dgvQuestion.RowTemplate.Height = 25;
            dgvQuestion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuestion.Size = new Size(762, 376);
            dgvQuestion.TabIndex = 1;
            dgvQuestion.CellValueChanged += dgvQuestion_CellValueChanged;
            // 
            // pnTestPaperViewHeader
            // 
            pnTestPaperViewHeader.BorderStyle = BorderStyle.FixedSingle;
            pnTestPaperViewHeader.Controls.Add(lblCountQuestion);
            pnTestPaperViewHeader.Controls.Add(lblCount);
            pnTestPaperViewHeader.Controls.Add(lblLQOT);
            pnTestPaperViewHeader.Dock = DockStyle.Top;
            pnTestPaperViewHeader.Location = new Point(0, 0);
            pnTestPaperViewHeader.Margin = new Padding(3, 2, 3, 2);
            pnTestPaperViewHeader.Name = "pnTestPaperViewHeader";
            pnTestPaperViewHeader.Size = new Size(762, 30);
            pnTestPaperViewHeader.TabIndex = 0;
            // 
            // lblCountQuestion
            // 
            lblCountQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCountQuestion.AutoSize = true;
            lblCountQuestion.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCountQuestion.Location = new Point(698, 6);
            lblCountQuestion.Name = "lblCountQuestion";
            lblCountQuestion.Size = new Size(17, 19);
            lblCountQuestion.TabIndex = 29;
            lblCountQuestion.Text = "0";
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCount.Location = new Point(640, 6);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(60, 19);
            lblCount.TabIndex = 28;
            lblCount.Text = "Count: ";
            // 
            // lblLQOT
            // 
            lblLQOT.AutoSize = true;
            lblLQOT.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblLQOT.Location = new Point(10, 6);
            lblLQOT.Name = "lblLQOT";
            lblLQOT.Size = new Size(141, 19);
            lblLQOT.TabIndex = 28;
            lblLQOT.Text = "List Question Of Test";
            // 
            // frmTestPaperAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 514);
            Controls.Add(pnTestPaperView);
            Controls.Add(pnTestPaperToolBox);
            Controls.Add(pnTestPaperAddHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTestPaperAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test Paper";
            pnTestPaperAddHeader.ResumeLayout(false);
            pnTestPaperAddHeader.PerformLayout();
            pnTestPaperToolBox.ResumeLayout(false);
            pnTestPaperView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).EndInit();
            pnTestPaperViewHeader.ResumeLayout(false);
            pnTestPaperViewHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPaperName;
        private TextBox inputPaperName;
        private Panel pnTestPaperAddHeader;
        private CheckBox checkIsOpent;
        private TextBox inputQuestionNum;
        private Label lblNumberQuestion;
        private TextBox inputPaperCode;
        private Label lblPaperCode;
        private TextBox inputDuration;
        private Label lblDuration;
        private DateTimePicker dtEndTime;
        private Label lblEndTime;
        private DateTimePicker dtStartTime;
        private Label lblStartTime;
        private Panel pnTestPaperToolBox;
        private Panel pnTestPaperView;
        private FontAwesome.Sharp.IconButton btnStudentDelete;
        private FontAwesome.Sharp.IconButton btnAddStudent;
        private Panel pnTestPaperViewHeader;
        private Label lblCount;
        private Label lblLQOT;
        private Label lblCountQuestion;
        private FontAwesome.Sharp.IconButton bntAdd;
        private DataGridView dgvQuestion;
    }
}