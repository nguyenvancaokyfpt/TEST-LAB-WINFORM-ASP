namespace TestLabManagerApp.ChildForm
{
    partial class frmCourse
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
            pnCourseHeader = new Panel();
            lblSearch = new Label();
            inputCourseSearch = new TextBox();
            pnCourseHeaderSearch = new Panel();
            btnCourseSearch = new FontAwesome.Sharp.IconButton();
            pnCourseToolBox = new Panel();
            btnCourseDelete = new FontAwesome.Sharp.IconButton();
            btnStudentCourse = new FontAwesome.Sharp.IconButton();
            btnAddCourse = new FontAwesome.Sharp.IconButton();
            pnCourseView = new Panel();
            dgvCourse = new DataGridView();
            pnCourseHeader.SuspendLayout();
            pnCourseHeaderSearch.SuspendLayout();
            pnCourseToolBox.SuspendLayout();
            pnCourseView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            SuspendLayout();
            // 
            // pnCourseHeader
            // 
            pnCourseHeader.Controls.Add(lblSearch);
            pnCourseHeader.Controls.Add(inputCourseSearch);
            pnCourseHeader.Controls.Add(pnCourseHeaderSearch);
            pnCourseHeader.Dock = DockStyle.Top;
            pnCourseHeader.Location = new Point(0, 0);
            pnCourseHeader.Name = "pnCourseHeader";
            pnCourseHeader.Size = new Size(949, 63);
            pnCourseHeader.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(10, 9);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(92, 16);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Search Course";
            lblSearch.Click += lblSearch_Click;
            // 
            // inputCourseSearch
            // 
            inputCourseSearch.Location = new Point(10, 29);
            inputCourseSearch.Name = "inputCourseSearch";
            inputCourseSearch.Size = new Size(777, 23);
            inputCourseSearch.TabIndex = 2;
            inputCourseSearch.TextChanged += inputCourseSearch_TextChanged;
            // 
            // pnCourseHeaderSearch
            // 
            pnCourseHeaderSearch.Controls.Add(btnCourseSearch);
            pnCourseHeaderSearch.Dock = DockStyle.Right;
            pnCourseHeaderSearch.Location = new Point(787, 0);
            pnCourseHeaderSearch.Name = "pnCourseHeaderSearch";
            pnCourseHeaderSearch.Size = new Size(162, 63);
            pnCourseHeaderSearch.TabIndex = 0;
            // 
            // btnCourseSearch
            // 
            btnCourseSearch.BackColor = Color.FromArgb(46, 81, 163);
            btnCourseSearch.Cursor = Cursors.Hand;
            btnCourseSearch.FlatAppearance.BorderSize = 0;
            btnCourseSearch.FlatStyle = FlatStyle.Flat;
            btnCourseSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCourseSearch.ForeColor = Color.White;
            btnCourseSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnCourseSearch.IconColor = Color.White;
            btnCourseSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCourseSearch.IconSize = 22;
            btnCourseSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnCourseSearch.Location = new Point(12, 29);
            btnCourseSearch.Name = "btnCourseSearch";
            btnCourseSearch.Size = new Size(138, 23);
            btnCourseSearch.TabIndex = 3;
            btnCourseSearch.Text = "Search";
            btnCourseSearch.UseVisualStyleBackColor = false;
            btnCourseSearch.Click += btnCourseSearch_Click;
            // 
            // pnCourseToolBox
            // 
            pnCourseToolBox.Controls.Add(btnCourseDelete);
            pnCourseToolBox.Controls.Add(btnStudentCourse);
            pnCourseToolBox.Controls.Add(btnAddCourse);
            pnCourseToolBox.Dock = DockStyle.Right;
            pnCourseToolBox.Location = new Point(787, 63);
            pnCourseToolBox.Name = "pnCourseToolBox";
            pnCourseToolBox.Size = new Size(162, 499);
            pnCourseToolBox.TabIndex = 1;
            // 
            // btnCourseDelete
            // 
            btnCourseDelete.BackColor = Color.FromArgb(235, 70, 96);
            btnCourseDelete.Cursor = Cursors.Hand;
            btnCourseDelete.FlatAppearance.BorderSize = 0;
            btnCourseDelete.FlatStyle = FlatStyle.Flat;
            btnCourseDelete.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCourseDelete.ForeColor = Color.White;
            btnCourseDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnCourseDelete.IconColor = Color.White;
            btnCourseDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCourseDelete.IconSize = 25;
            btnCourseDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnCourseDelete.Location = new Point(12, 199);
            btnCourseDelete.Name = "btnCourseDelete";
            btnCourseDelete.Size = new Size(138, 32);
            btnCourseDelete.TabIndex = 7;
            btnCourseDelete.Text = "Delete";
            btnCourseDelete.UseVisualStyleBackColor = false;
            btnCourseDelete.Click += btnCourseDelete_Click;
            // 
            // btnStudentCourse
            // 
            btnStudentCourse.BackColor = Color.FromArgb(255, 184, 77);
            btnStudentCourse.Cursor = Cursors.Hand;
            btnStudentCourse.FlatAppearance.BorderSize = 0;
            btnStudentCourse.FlatStyle = FlatStyle.Flat;
            btnStudentCourse.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudentCourse.ForeColor = Color.White;
            btnStudentCourse.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btnStudentCourse.IconColor = Color.White;
            btnStudentCourse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStudentCourse.IconSize = 25;
            btnStudentCourse.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudentCourse.Location = new Point(12, 151);
            btnStudentCourse.Name = "btnStudentCourse";
            btnStudentCourse.Size = new Size(138, 32);
            btnStudentCourse.TabIndex = 6;
            btnStudentCourse.Text = "Edit";
            btnStudentCourse.UseVisualStyleBackColor = false;
            btnStudentCourse.Click += btnStudentCourse_Click;
            // 
            // btnAddCourse
            // 
            btnAddCourse.BackColor = Color.FromArgb(125, 185, 182);
            btnAddCourse.Cursor = Cursors.Hand;
            btnAddCourse.FlatAppearance.BorderSize = 0;
            btnAddCourse.FlatStyle = FlatStyle.Flat;
            btnAddCourse.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCourse.ForeColor = Color.White;
            btnAddCourse.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAddCourse.IconColor = Color.White;
            btnAddCourse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddCourse.IconSize = 25;
            btnAddCourse.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddCourse.Location = new Point(12, 103);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(138, 32);
            btnAddCourse.TabIndex = 5;
            btnAddCourse.Text = "Add";
            btnAddCourse.UseVisualStyleBackColor = false;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // pnCourseView
            // 
            pnCourseView.Controls.Add(dgvCourse);
            pnCourseView.Dock = DockStyle.Fill;
            pnCourseView.Location = new Point(0, 63);
            pnCourseView.Name = "pnCourseView";
            pnCourseView.Size = new Size(787, 499);
            pnCourseView.TabIndex = 2;
            // 
            // dgvCourse
            // 
            dgvCourse.AllowUserToOrderColumns = true;
            dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.Dock = DockStyle.Fill;
            dgvCourse.Location = new Point(0, 0);
            dgvCourse.Name = "dgvCourse";
            dgvCourse.RowHeadersWidth = 51;
            dgvCourse.RowTemplate.Height = 29;
            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.Size = new Size(787, 499);
            dgvCourse.TabIndex = 0;
            dgvCourse.Click += dgvCourse_Click;
            dgvCourse.DoubleClick += dgvCourse_DoubleClick;
            // 
            // frmCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 562);
            Controls.Add(pnCourseView);
            Controls.Add(pnCourseToolBox);
            Controls.Add(pnCourseHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCourse";
            Text = "Course";
            pnCourseHeader.ResumeLayout(false);
            pnCourseHeader.PerformLayout();
            pnCourseHeaderSearch.ResumeLayout(false);
            pnCourseToolBox.ResumeLayout(false);
            pnCourseView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnCourseHeader;
        private Panel pnCourseToolBox;
        private Panel pnCourseHeaderSearch;
        private Panel pnCourseView;
        private FontAwesome.Sharp.IconButton btnCourseSearch;
        private TextBox inputCourseSearch;
        private Label lblSearch;
        private FontAwesome.Sharp.IconButton btnCourseDelete;
        private FontAwesome.Sharp.IconButton btnStudentCourse;
        private FontAwesome.Sharp.IconButton btnAddCourse;
        private DataGridView dgvCourse;
    }
}