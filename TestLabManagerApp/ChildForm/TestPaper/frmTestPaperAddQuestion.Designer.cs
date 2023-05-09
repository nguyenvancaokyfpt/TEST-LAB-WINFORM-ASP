namespace TestLabManagerApp.ChildForm.TestPaper
{
    partial class frmTestPaperAddQuestion
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
            panel1 = new Panel();
            cbChapter = new ComboBox();
            label2 = new Label();
            cbCourse = new ComboBox();
            label1 = new Label();
            btnStudentSearch = new FontAwesome.Sharp.IconButton();
            inputStudentSearch = new TextBox();
            lblSearch = new Label();
            panel2 = new Panel();
            btnAddStudent = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            dgvQuestion = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbChapter);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbCourse);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnStudentSearch);
            panel1.Controls.Add(inputStudentSearch);
            panel1.Controls.Add(lblSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 56);
            panel1.TabIndex = 0;
            // 
            // cbChapter
            // 
            cbChapter.FormattingEnabled = true;
            cbChapter.Location = new Point(652, 22);
            cbChapter.Margin = new Padding(3, 2, 3, 2);
            cbChapter.Name = "cbChapter";
            cbChapter.Size = new Size(201, 23);
            cbChapter.TabIndex = 9;
            cbChapter.SelectedIndexChanged += cbChapter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(652, 7);
            label2.Name = "label2";
            label2.Size = new Size(84, 16);
            label2.TabIndex = 8;
            label2.Text = "Chapter Filter";
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(437, 22);
            cbCourse.Margin = new Padding(3, 2, 3, 2);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(201, 23);
            cbCourse.TabIndex = 7;
            cbCourse.SelectedIndexChanged += cbCourse_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(437, 7);
            label1.Name = "label1";
            label1.Size = new Size(78, 16);
            label1.TabIndex = 6;
            label1.Text = "Course Filter";
            // 
            // btnStudentSearch
            // 
            btnStudentSearch.BackColor = Color.FromArgb(46, 81, 163);
            btnStudentSearch.Cursor = Cursors.Hand;
            btnStudentSearch.FlatAppearance.BorderSize = 0;
            btnStudentSearch.FlatStyle = FlatStyle.Flat;
            btnStudentSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudentSearch.ForeColor = Color.White;
            btnStudentSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnStudentSearch.IconColor = Color.White;
            btnStudentSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStudentSearch.IconSize = 22;
            btnStudentSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudentSearch.Location = new Point(318, 24);
            btnStudentSearch.Name = "btnStudentSearch";
            btnStudentSearch.Size = new Size(102, 23);
            btnStudentSearch.TabIndex = 5;
            btnStudentSearch.Text = "Search";
            btnStudentSearch.UseVisualStyleBackColor = false;
            btnStudentSearch.Click += btnStudentSearch_Click;
            // 
            // inputStudentSearch
            // 
            inputStudentSearch.Location = new Point(10, 24);
            inputStudentSearch.Name = "inputStudentSearch";
            inputStudentSearch.Size = new Size(303, 23);
            inputStudentSearch.TabIndex = 4;
            inputStudentSearch.TextChanged += inputStudentSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(8, 5);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(102, 16);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search Question";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAddStudent);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 377);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(904, 46);
            panel2.TabIndex = 1;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddStudent.BackColor = Color.FromArgb(125, 185, 182);
            btnAddStudent.Cursor = Cursors.Hand;
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAddStudent.IconColor = Color.White;
            btnAddStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddStudent.IconSize = 25;
            btnAddStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddStudent.Location = new Point(384, 5);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(138, 32);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvQuestion);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 56);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(904, 321);
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
            dgvQuestion.Size = new Size(904, 321);
            dgvQuestion.TabIndex = 0;
            // 
            // frmTestPaperAddQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 423);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTestPaperAddQuestion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Question To Test";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ComboBox cbChapter;
        private Label label2;
        private ComboBox cbCourse;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnStudentSearch;
        private TextBox inputStudentSearch;
        private Label lblSearch;
        private FontAwesome.Sharp.IconButton btnAddStudent;
        private DataGridView dgvQuestion;
    }
}