namespace TestLabManagerApp.ChildForm
{
    partial class frmQuestion
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
            pnQuestionHeader = new Panel();
            cbChapter = new ComboBox();
            label2 = new Label();
            cbCourse = new ComboBox();
            label1 = new Label();
            lblSearch = new Label();
            inputQuestionSearch = new TextBox();
            btnQuestionSearch = new FontAwesome.Sharp.IconButton();
            pnQuestionToolBox = new Panel();
            btnQuestionDelete = new FontAwesome.Sharp.IconButton();
            btnEditCourse = new FontAwesome.Sharp.IconButton();
            btnAddQuestion = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            dgvQuestion = new DataGridView();
            pnQuestionHeader.SuspendLayout();
            pnQuestionToolBox.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).BeginInit();
            SuspendLayout();
            // 
            // pnQuestionHeader
            // 
            pnQuestionHeader.Controls.Add(cbChapter);
            pnQuestionHeader.Controls.Add(label2);
            pnQuestionHeader.Controls.Add(cbCourse);
            pnQuestionHeader.Controls.Add(label1);
            pnQuestionHeader.Controls.Add(lblSearch);
            pnQuestionHeader.Controls.Add(inputQuestionSearch);
            pnQuestionHeader.Controls.Add(btnQuestionSearch);
            pnQuestionHeader.Dock = DockStyle.Top;
            pnQuestionHeader.Location = new Point(0, 0);
            pnQuestionHeader.Name = "pnQuestionHeader";
            pnQuestionHeader.Size = new Size(949, 63);
            pnQuestionHeader.TabIndex = 0;
            // 
            // cbChapter
            // 
            cbChapter.FormattingEnabled = true;
            cbChapter.Location = new Point(681, 27);
            cbChapter.Name = "cbChapter";
            cbChapter.Size = new Size(209, 23);
            cbChapter.TabIndex = 17;
            cbChapter.SelectedIndexChanged += cbChapter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(681, 9);
            label2.Name = "label2";
            label2.Size = new Size(84, 16);
            label2.TabIndex = 16;
            label2.Text = "Chapter Filter";
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(491, 27);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(158, 23);
            cbCourse.TabIndex = 15;
            cbCourse.SelectedIndexChanged += cbCourse_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(491, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 16);
            label1.TabIndex = 14;
            label1.Text = "Course Filter";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(12, 8);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(102, 16);
            lblSearch.TabIndex = 13;
            lblSearch.Text = "Search Question";
            // 
            // inputQuestionSearch
            // 
            inputQuestionSearch.Location = new Point(12, 27);
            inputQuestionSearch.Name = "inputQuestionSearch";
            inputQuestionSearch.Size = new Size(294, 23);
            inputQuestionSearch.TabIndex = 12;
            inputQuestionSearch.TextChanged += inputQuestionSearch_TextChanged;
            // 
            // btnQuestionSearch
            // 
            btnQuestionSearch.BackColor = Color.FromArgb(46, 81, 163);
            btnQuestionSearch.Cursor = Cursors.Hand;
            btnQuestionSearch.FlatAppearance.BorderSize = 0;
            btnQuestionSearch.FlatStyle = FlatStyle.Flat;
            btnQuestionSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuestionSearch.ForeColor = Color.White;
            btnQuestionSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnQuestionSearch.IconColor = Color.White;
            btnQuestionSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuestionSearch.IconSize = 22;
            btnQuestionSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuestionSearch.Location = new Point(335, 27);
            btnQuestionSearch.Name = "btnQuestionSearch";
            btnQuestionSearch.Size = new Size(138, 23);
            btnQuestionSearch.TabIndex = 11;
            btnQuestionSearch.Text = "Search";
            btnQuestionSearch.UseVisualStyleBackColor = false;
            btnQuestionSearch.Click += btnQuestionSearch_Click;
            // 
            // pnQuestionToolBox
            // 
            pnQuestionToolBox.Controls.Add(btnQuestionDelete);
            pnQuestionToolBox.Controls.Add(btnEditCourse);
            pnQuestionToolBox.Controls.Add(btnAddQuestion);
            pnQuestionToolBox.Dock = DockStyle.Right;
            pnQuestionToolBox.Location = new Point(787, 63);
            pnQuestionToolBox.Name = "pnQuestionToolBox";
            pnQuestionToolBox.Size = new Size(162, 499);
            pnQuestionToolBox.TabIndex = 1;
            // 
            // btnQuestionDelete
            // 
            btnQuestionDelete.BackColor = Color.FromArgb(235, 70, 96);
            btnQuestionDelete.Cursor = Cursors.Hand;
            btnQuestionDelete.FlatAppearance.BorderSize = 0;
            btnQuestionDelete.FlatStyle = FlatStyle.Flat;
            btnQuestionDelete.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuestionDelete.ForeColor = Color.White;
            btnQuestionDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnQuestionDelete.IconColor = Color.White;
            btnQuestionDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuestionDelete.IconSize = 25;
            btnQuestionDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuestionDelete.Location = new Point(12, 201);
            btnQuestionDelete.Name = "btnQuestionDelete";
            btnQuestionDelete.Size = new Size(138, 32);
            btnQuestionDelete.TabIndex = 10;
            btnQuestionDelete.Text = "Delete";
            btnQuestionDelete.UseVisualStyleBackColor = false;
            btnQuestionDelete.Click += btnQuestionDelete_Click;
            // 
            // btnEditCourse
            // 
            btnEditCourse.BackColor = Color.FromArgb(255, 184, 77);
            btnEditCourse.Cursor = Cursors.Hand;
            btnEditCourse.FlatAppearance.BorderSize = 0;
            btnEditCourse.FlatStyle = FlatStyle.Flat;
            btnEditCourse.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditCourse.ForeColor = Color.White;
            btnEditCourse.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btnEditCourse.IconColor = Color.White;
            btnEditCourse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditCourse.IconSize = 25;
            btnEditCourse.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditCourse.Location = new Point(12, 153);
            btnEditCourse.Name = "btnEditCourse";
            btnEditCourse.Size = new Size(138, 32);
            btnEditCourse.TabIndex = 9;
            btnEditCourse.Text = "Edit";
            btnEditCourse.UseVisualStyleBackColor = false;
            btnEditCourse.Click += btnEditCourse_Click;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.BackColor = Color.FromArgb(125, 185, 182);
            btnAddQuestion.Cursor = Cursors.Hand;
            btnAddQuestion.FlatAppearance.BorderSize = 0;
            btnAddQuestion.FlatStyle = FlatStyle.Flat;
            btnAddQuestion.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddQuestion.ForeColor = Color.White;
            btnAddQuestion.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAddQuestion.IconColor = Color.White;
            btnAddQuestion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddQuestion.IconSize = 25;
            btnAddQuestion.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddQuestion.Location = new Point(12, 105);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(138, 32);
            btnAddQuestion.TabIndex = 8;
            btnAddQuestion.Text = "Add";
            btnAddQuestion.UseVisualStyleBackColor = false;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvQuestion);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(787, 499);
            panel3.TabIndex = 2;
            // 
            // dgvQuestion
            // 
            dgvQuestion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestion.Dock = DockStyle.Fill;
            dgvQuestion.Location = new Point(0, 0);
            dgvQuestion.Name = "dgvQuestion";
            dgvQuestion.RowTemplate.Height = 25;
            dgvQuestion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuestion.Size = new Size(787, 499);
            dgvQuestion.TabIndex = 0;
            dgvQuestion.Click += dgvQuestion_Click;
            dgvQuestion.DoubleClick += dgvQuestion_DoubleClick;
            // 
            // frmQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 562);
            Controls.Add(panel3);
            Controls.Add(pnQuestionToolBox);
            Controls.Add(pnQuestionHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQuestion";
            Text = "Question";
            pnQuestionHeader.ResumeLayout(false);
            pnQuestionHeader.PerformLayout();
            pnQuestionToolBox.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnQuestionHeader;
        private Panel pnQuestionToolBox;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnQuestionDelete;
        private FontAwesome.Sharp.IconButton btnEditCourse;
        private FontAwesome.Sharp.IconButton btnAddQuestion;
        private FontAwesome.Sharp.IconButton btnQuestionSearch;
        private TextBox inputQuestionSearch;
        private Label lblSearch;
        private DataGridView dgvQuestion;
        private ComboBox cbChapter;
        private Label label2;
        private ComboBox cbCourse;
        private Label label1;
    }
}