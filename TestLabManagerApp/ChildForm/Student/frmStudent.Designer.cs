namespace TestLabManagerApp.ChildForm
{
    partial class frmStudent
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
            pnStudentHeader = new Panel();
            btnStudentSearch = new FontAwesome.Sharp.IconButton();
            inputStudentSearch = new TextBox();
            lblSearch = new Label();
            pnStudentToolBox = new Panel();
            btnStudentDelete = new FontAwesome.Sharp.IconButton();
            btnStudentEdit = new FontAwesome.Sharp.IconButton();
            btnAddStudent = new FontAwesome.Sharp.IconButton();
            pnStudentView = new Panel();
            dgvStudents = new DataGridView();
            pnStudentHeader.SuspendLayout();
            pnStudentToolBox.SuspendLayout();
            pnStudentView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // pnStudentHeader
            // 
            pnStudentHeader.BackColor = SystemColors.ButtonFace;
            pnStudentHeader.Controls.Add(btnStudentSearch);
            pnStudentHeader.Controls.Add(inputStudentSearch);
            pnStudentHeader.Controls.Add(lblSearch);
            pnStudentHeader.Dock = DockStyle.Top;
            pnStudentHeader.Location = new Point(0, 0);
            pnStudentHeader.Name = "pnStudentHeader";
            pnStudentHeader.Size = new Size(949, 63);
            pnStudentHeader.TabIndex = 0;
            // 
            // btnStudentSearch
            // 
            btnStudentSearch.BackColor = Color.FromArgb(46, 81, 163);
            btnStudentSearch.FlatAppearance.BorderSize = 0;
            btnStudentSearch.FlatStyle = FlatStyle.Flat;
            btnStudentSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudentSearch.ForeColor = Color.White;
            btnStudentSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnStudentSearch.IconColor = Color.White;
            btnStudentSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStudentSearch.IconSize = 22;
            btnStudentSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudentSearch.Location = new Point(799, 28);
            btnStudentSearch.Name = "btnStudentSearch";
            btnStudentSearch.Size = new Size(138, 23);
            btnStudentSearch.TabIndex = 2;
            btnStudentSearch.Text = "Search";
            btnStudentSearch.UseVisualStyleBackColor = false;
            btnStudentSearch.Click += btnStudentSearch_Click;
            // 
            // inputStudentSearch
            // 
            inputStudentSearch.Location = new Point(16, 28);
            inputStudentSearch.Name = "inputStudentSearch";
            inputStudentSearch.Size = new Size(771, 23);
            inputStudentSearch.TabIndex = 1;
            inputStudentSearch.TextChanged += inputStudentSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(13, 9);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(93, 16);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Student";
            // 
            // pnStudentToolBox
            // 
            pnStudentToolBox.Controls.Add(btnStudentDelete);
            pnStudentToolBox.Controls.Add(btnStudentEdit);
            pnStudentToolBox.Controls.Add(btnAddStudent);
            pnStudentToolBox.Dock = DockStyle.Right;
            pnStudentToolBox.Location = new Point(787, 63);
            pnStudentToolBox.Name = "pnStudentToolBox";
            pnStudentToolBox.Size = new Size(162, 499);
            pnStudentToolBox.TabIndex = 1;
            // 
            // btnStudentDelete
            // 
            btnStudentDelete.BackColor = Color.FromArgb(235, 70, 96);
            btnStudentDelete.FlatAppearance.BorderSize = 0;
            btnStudentDelete.FlatStyle = FlatStyle.Flat;
            btnStudentDelete.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudentDelete.ForeColor = Color.White;
            btnStudentDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnStudentDelete.IconColor = Color.White;
            btnStudentDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStudentDelete.IconSize = 25;
            btnStudentDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudentDelete.Location = new Point(12, 199);
            btnStudentDelete.Name = "btnStudentDelete";
            btnStudentDelete.Size = new Size(138, 32);
            btnStudentDelete.TabIndex = 2;
            btnStudentDelete.Text = "Delete";
            btnStudentDelete.UseVisualStyleBackColor = false;
            btnStudentDelete.Click += btnStudentDelete_Click;
            // 
            // btnStudentEdit
            // 
            btnStudentEdit.BackColor = Color.FromArgb(255, 184, 77);
            btnStudentEdit.FlatAppearance.BorderSize = 0;
            btnStudentEdit.FlatStyle = FlatStyle.Flat;
            btnStudentEdit.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudentEdit.ForeColor = Color.White;
            btnStudentEdit.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btnStudentEdit.IconColor = Color.White;
            btnStudentEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStudentEdit.IconSize = 25;
            btnStudentEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudentEdit.Location = new Point(12, 151);
            btnStudentEdit.Name = "btnStudentEdit";
            btnStudentEdit.Size = new Size(138, 32);
            btnStudentEdit.TabIndex = 1;
            btnStudentEdit.Text = "Edit";
            btnStudentEdit.UseVisualStyleBackColor = false;
            btnStudentEdit.Click += btnStudentEdit_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(125, 185, 182);
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAddStudent.IconColor = Color.White;
            btnAddStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddStudent.IconSize = 25;
            btnAddStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddStudent.Location = new Point(12, 103);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(138, 32);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // pnStudentView
            // 
            pnStudentView.Controls.Add(dgvStudents);
            pnStudentView.Dock = DockStyle.Fill;
            pnStudentView.Location = new Point(0, 63);
            pnStudentView.Name = "pnStudentView";
            pnStudentView.Size = new Size(787, 499);
            pnStudentView.TabIndex = 2;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToOrderColumns = true;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.Location = new Point(0, 0);
            dgvStudents.Margin = new Padding(3, 2, 3, 2);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.RowTemplate.Height = 29;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(787, 499);
            dgvStudents.TabIndex = 0;
            dgvStudents.Click += dgvStudents_Click;
            dgvStudents.DoubleClick += dgvStudents_DoubleClick;
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 562);
            Controls.Add(pnStudentView);
            Controls.Add(pnStudentToolBox);
            Controls.Add(pnStudentHeader);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStudent";
            Text = "Student";
            pnStudentHeader.ResumeLayout(false);
            pnStudentHeader.PerformLayout();
            pnStudentToolBox.ResumeLayout(false);
            pnStudentView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnStudentHeader;
        private TextBox inputStudentSearch;
        private Label lblSearch;
        private Panel pnStudentToolBox;
        private FontAwesome.Sharp.IconButton btnAddStudent;
        private Panel pnStudentView;
        private FontAwesome.Sharp.IconButton btnStudentDelete;
        private FontAwesome.Sharp.IconButton btnStudentEdit;
        private FontAwesome.Sharp.IconButton btnStudentSearch;
        private DataGridView dgvStudents;
    }
}