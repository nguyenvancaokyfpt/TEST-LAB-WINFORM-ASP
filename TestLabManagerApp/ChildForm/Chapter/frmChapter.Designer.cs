namespace TestLabManagerApp.ChildForm
{
    partial class frmChapter
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
            pnChapterHeader = new Panel();
            lblFilerByCourse = new Label();
            cbFilterByCourse = new ComboBox();
            lblSearch = new Label();
            inputChapterSearch = new TextBox();
            btnChapterSearch = new FontAwesome.Sharp.IconButton();
            pnChapterToolBox = new Panel();
            btnChapterDelete = new FontAwesome.Sharp.IconButton();
            btnChapterCourse = new FontAwesome.Sharp.IconButton();
            btnAddChapter = new FontAwesome.Sharp.IconButton();
            pnChapterView = new Panel();
            dgvChapter = new DataGridView();
            pnChapterHeader.SuspendLayout();
            pnChapterToolBox.SuspendLayout();
            pnChapterView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChapter).BeginInit();
            SuspendLayout();
            // 
            // pnChapterHeader
            // 
            pnChapterHeader.Controls.Add(lblFilerByCourse);
            pnChapterHeader.Controls.Add(cbFilterByCourse);
            pnChapterHeader.Controls.Add(lblSearch);
            pnChapterHeader.Controls.Add(inputChapterSearch);
            pnChapterHeader.Controls.Add(btnChapterSearch);
            pnChapterHeader.Dock = DockStyle.Top;
            pnChapterHeader.Location = new Point(0, 0);
            pnChapterHeader.Name = "pnChapterHeader";
            pnChapterHeader.Size = new Size(949, 63);
            pnChapterHeader.TabIndex = 0;
            // 
            // lblFilerByCourse
            // 
            lblFilerByCourse.AutoSize = true;
            lblFilerByCourse.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFilerByCourse.Location = new Point(634, 9);
            lblFilerByCourse.Name = "lblFilerByCourse";
            lblFilerByCourse.Size = new Size(96, 16);
            lblFilerByCourse.TabIndex = 15;
            lblFilerByCourse.Text = "Filter by Course";
            // 
            // cbFilterByCourse
            // 
            cbFilterByCourse.FormattingEnabled = true;
            cbFilterByCourse.Location = new Point(634, 29);
            cbFilterByCourse.Name = "cbFilterByCourse";
            cbFilterByCourse.Size = new Size(303, 23);
            cbFilterByCourse.TabIndex = 14;
            cbFilterByCourse.SelectedIndexChanged += cbFilterByCourse_SelectedIndexChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(8, 9);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(98, 16);
            lblSearch.TabIndex = 13;
            lblSearch.Text = "Search Chapter";
            // 
            // inputChapterSearch
            // 
            inputChapterSearch.Location = new Point(9, 29);
            inputChapterSearch.Name = "inputChapterSearch";
            inputChapterSearch.Size = new Size(440, 23);
            inputChapterSearch.TabIndex = 12;
            inputChapterSearch.TextChanged += inputChapterSearch_TextChanged;
            // 
            // btnChapterSearch
            // 
            btnChapterSearch.BackColor = Color.FromArgb(46, 81, 163);
            btnChapterSearch.Cursor = Cursors.Hand;
            btnChapterSearch.FlatAppearance.BorderSize = 0;
            btnChapterSearch.FlatStyle = FlatStyle.Flat;
            btnChapterSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChapterSearch.ForeColor = Color.White;
            btnChapterSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnChapterSearch.IconColor = Color.White;
            btnChapterSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChapterSearch.IconSize = 22;
            btnChapterSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnChapterSearch.Location = new Point(467, 29);
            btnChapterSearch.Name = "btnChapterSearch";
            btnChapterSearch.Size = new Size(138, 23);
            btnChapterSearch.TabIndex = 11;
            btnChapterSearch.Text = "Search";
            btnChapterSearch.UseVisualStyleBackColor = false;
            btnChapterSearch.Click += btnChapterSearch_Click;
            // 
            // pnChapterToolBox
            // 
            pnChapterToolBox.Controls.Add(btnChapterDelete);
            pnChapterToolBox.Controls.Add(btnChapterCourse);
            pnChapterToolBox.Controls.Add(btnAddChapter);
            pnChapterToolBox.Dock = DockStyle.Right;
            pnChapterToolBox.Location = new Point(787, 63);
            pnChapterToolBox.Name = "pnChapterToolBox";
            pnChapterToolBox.Size = new Size(162, 499);
            pnChapterToolBox.TabIndex = 1;
            // 
            // btnChapterDelete
            // 
            btnChapterDelete.BackColor = Color.FromArgb(235, 70, 96);
            btnChapterDelete.Cursor = Cursors.Hand;
            btnChapterDelete.FlatAppearance.BorderSize = 0;
            btnChapterDelete.FlatStyle = FlatStyle.Flat;
            btnChapterDelete.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnChapterDelete.ForeColor = Color.White;
            btnChapterDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnChapterDelete.IconColor = Color.White;
            btnChapterDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChapterDelete.IconSize = 25;
            btnChapterDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnChapterDelete.Location = new Point(12, 199);
            btnChapterDelete.Name = "btnChapterDelete";
            btnChapterDelete.Size = new Size(138, 32);
            btnChapterDelete.TabIndex = 10;
            btnChapterDelete.Text = "Delete";
            btnChapterDelete.UseVisualStyleBackColor = false;
            btnChapterDelete.Click += btnChapterDelete_Click;
            // 
            // btnChapterCourse
            // 
            btnChapterCourse.BackColor = Color.FromArgb(255, 184, 77);
            btnChapterCourse.Cursor = Cursors.Hand;
            btnChapterCourse.FlatAppearance.BorderSize = 0;
            btnChapterCourse.FlatStyle = FlatStyle.Flat;
            btnChapterCourse.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnChapterCourse.ForeColor = Color.White;
            btnChapterCourse.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btnChapterCourse.IconColor = Color.White;
            btnChapterCourse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChapterCourse.IconSize = 25;
            btnChapterCourse.ImageAlign = ContentAlignment.MiddleLeft;
            btnChapterCourse.Location = new Point(12, 151);
            btnChapterCourse.Name = "btnChapterCourse";
            btnChapterCourse.Size = new Size(138, 32);
            btnChapterCourse.TabIndex = 9;
            btnChapterCourse.Text = "Edit";
            btnChapterCourse.UseVisualStyleBackColor = false;
            btnChapterCourse.Click += btnChapterCourse_Click;
            // 
            // btnAddChapter
            // 
            btnAddChapter.BackColor = Color.FromArgb(125, 185, 182);
            btnAddChapter.Cursor = Cursors.Hand;
            btnAddChapter.FlatAppearance.BorderSize = 0;
            btnAddChapter.FlatStyle = FlatStyle.Flat;
            btnAddChapter.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddChapter.ForeColor = Color.White;
            btnAddChapter.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAddChapter.IconColor = Color.White;
            btnAddChapter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddChapter.IconSize = 25;
            btnAddChapter.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddChapter.Location = new Point(12, 103);
            btnAddChapter.Name = "btnAddChapter";
            btnAddChapter.Size = new Size(138, 32);
            btnAddChapter.TabIndex = 8;
            btnAddChapter.Text = "Add";
            btnAddChapter.UseVisualStyleBackColor = false;
            btnAddChapter.Click += btnAddChapter_Click;
            // 
            // pnChapterView
            // 
            pnChapterView.Controls.Add(dgvChapter);
            pnChapterView.Dock = DockStyle.Fill;
            pnChapterView.Location = new Point(0, 63);
            pnChapterView.Name = "pnChapterView";
            pnChapterView.Size = new Size(787, 499);
            pnChapterView.TabIndex = 2;
            // 
            // dgvChapter
            // 
            dgvChapter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChapter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChapter.Dock = DockStyle.Fill;
            dgvChapter.Location = new Point(0, 0);
            dgvChapter.Name = "dgvChapter";
            dgvChapter.ReadOnly = true;
            dgvChapter.RowTemplate.Height = 25;
            dgvChapter.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChapter.Size = new Size(787, 499);
            dgvChapter.TabIndex = 0;
            dgvChapter.Click += dgvChapter_Click;
            dgvChapter.DoubleClick += dgvChapter_DoubleClick;
            // 
            // frmChapter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 562);
            Controls.Add(pnChapterView);
            Controls.Add(pnChapterToolBox);
            Controls.Add(pnChapterHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmChapter";
            Text = "Chapter";
            pnChapterHeader.ResumeLayout(false);
            pnChapterHeader.PerformLayout();
            pnChapterToolBox.ResumeLayout(false);
            pnChapterView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChapter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnChapterHeader;
        private Panel pnChapterToolBox;
        private Panel pnChapterView;
        private FontAwesome.Sharp.IconButton btnChapterDelete;
        private FontAwesome.Sharp.IconButton btnChapterCourse;
        private FontAwesome.Sharp.IconButton btnAddChapter;
        private FontAwesome.Sharp.IconButton btnChapterSearch;
        private TextBox inputChapterSearch;
        private Label lblSearch;
        private Label lblFilerByCourse;
        private ComboBox cbFilterByCourse;
        private DataGridView dgvChapter;
    }
}