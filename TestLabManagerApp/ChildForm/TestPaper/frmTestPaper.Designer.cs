namespace TestLabManagerApp.ChildForm
{
    partial class frmTestPaper
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
            pnTestPaperHeader = new Panel();
            lblFilerByCourse = new Label();
            cbFilterByCourse = new ComboBox();
            lblSearch = new Label();
            inputQuestionSearch = new TextBox();
            btnQuestionSearch = new FontAwesome.Sharp.IconButton();
            pnTestPaperToolBox = new Panel();
            btnTestPaperDelete = new FontAwesome.Sharp.IconButton();
            btnEditTestPaper = new FontAwesome.Sharp.IconButton();
            btnAddTestPaper = new FontAwesome.Sharp.IconButton();
            pnTestPaperView = new Panel();
            dgvTestPaper = new DataGridView();
            pnTestPaperHeader.SuspendLayout();
            pnTestPaperToolBox.SuspendLayout();
            pnTestPaperView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTestPaper).BeginInit();
            SuspendLayout();
            // 
            // pnTestPaperHeader
            // 
            pnTestPaperHeader.Controls.Add(lblFilerByCourse);
            pnTestPaperHeader.Controls.Add(cbFilterByCourse);
            pnTestPaperHeader.Controls.Add(lblSearch);
            pnTestPaperHeader.Controls.Add(inputQuestionSearch);
            pnTestPaperHeader.Controls.Add(btnQuestionSearch);
            pnTestPaperHeader.Dock = DockStyle.Top;
            pnTestPaperHeader.Location = new Point(0, 0);
            pnTestPaperHeader.Name = "pnTestPaperHeader";
            pnTestPaperHeader.Size = new Size(1186, 63);
            pnTestPaperHeader.TabIndex = 0;
            pnTestPaperHeader.Paint += pnTestPaperHeader_Paint;
            // 
            // lblFilerByCourse
            // 
            lblFilerByCourse.AutoSize = true;
            lblFilerByCourse.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFilerByCourse.Location = new Point(589, 5);
            lblFilerByCourse.Name = "lblFilerByCourse";
            lblFilerByCourse.Size = new Size(96, 16);
            lblFilerByCourse.TabIndex = 18;
            lblFilerByCourse.Text = "Filter by Course";
            // 
            // cbFilterByCourse
            // 
            cbFilterByCourse.FormattingEnabled = true;
            cbFilterByCourse.Location = new Point(589, 25);
            cbFilterByCourse.Name = "cbFilterByCourse";
            cbFilterByCourse.Size = new Size(303, 23);
            cbFilterByCourse.TabIndex = 17;
            cbFilterByCourse.SelectedIndexChanged += cbFilterByCourse_SelectedIndexChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(12, 6);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(111, 16);
            lblSearch.TabIndex = 16;
            lblSearch.Text = "Search Test Paper";
            // 
            // inputQuestionSearch
            // 
            inputQuestionSearch.Location = new Point(10, 25);
            inputQuestionSearch.Name = "inputQuestionSearch";
            inputQuestionSearch.Size = new Size(395, 23);
            inputQuestionSearch.TabIndex = 15;
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
            btnQuestionSearch.Location = new Point(411, 25);
            btnQuestionSearch.Name = "btnQuestionSearch";
            btnQuestionSearch.Size = new Size(138, 23);
            btnQuestionSearch.TabIndex = 14;
            btnQuestionSearch.Text = "Search";
            btnQuestionSearch.UseVisualStyleBackColor = false;
            btnQuestionSearch.Click += btnQuestionSearch_Click;
            // 
            // pnTestPaperToolBox
            // 
            pnTestPaperToolBox.Controls.Add(btnTestPaperDelete);
            pnTestPaperToolBox.Controls.Add(btnEditTestPaper);
            pnTestPaperToolBox.Controls.Add(btnAddTestPaper);
            pnTestPaperToolBox.Dock = DockStyle.Right;
            pnTestPaperToolBox.Location = new Point(1024, 63);
            pnTestPaperToolBox.Name = "pnTestPaperToolBox";
            pnTestPaperToolBox.Size = new Size(162, 640);
            pnTestPaperToolBox.TabIndex = 1;
            // 
            // btnTestPaperDelete
            // 
            btnTestPaperDelete.BackColor = Color.FromArgb(235, 70, 96);
            btnTestPaperDelete.Cursor = Cursors.Hand;
            btnTestPaperDelete.FlatAppearance.BorderSize = 0;
            btnTestPaperDelete.FlatStyle = FlatStyle.Flat;
            btnTestPaperDelete.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTestPaperDelete.ForeColor = Color.White;
            btnTestPaperDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnTestPaperDelete.IconColor = Color.White;
            btnTestPaperDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTestPaperDelete.IconSize = 25;
            btnTestPaperDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnTestPaperDelete.Location = new Point(12, 200);
            btnTestPaperDelete.Name = "btnTestPaperDelete";
            btnTestPaperDelete.Size = new Size(138, 32);
            btnTestPaperDelete.TabIndex = 13;
            btnTestPaperDelete.Text = "Delete";
            btnTestPaperDelete.UseVisualStyleBackColor = false;
            btnTestPaperDelete.Click += btnTestPaperDelete_Click;
            // 
            // btnEditTestPaper
            // 
            btnEditTestPaper.BackColor = Color.FromArgb(255, 184, 77);
            btnEditTestPaper.Cursor = Cursors.Hand;
            btnEditTestPaper.FlatAppearance.BorderSize = 0;
            btnEditTestPaper.FlatStyle = FlatStyle.Flat;
            btnEditTestPaper.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditTestPaper.ForeColor = Color.White;
            btnEditTestPaper.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btnEditTestPaper.IconColor = Color.White;
            btnEditTestPaper.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditTestPaper.IconSize = 25;
            btnEditTestPaper.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditTestPaper.Location = new Point(12, 152);
            btnEditTestPaper.Name = "btnEditTestPaper";
            btnEditTestPaper.Size = new Size(138, 32);
            btnEditTestPaper.TabIndex = 12;
            btnEditTestPaper.Text = "Edit";
            btnEditTestPaper.UseVisualStyleBackColor = false;
            btnEditTestPaper.Click += btnEditTestPaper_Click;
            // 
            // btnAddTestPaper
            // 
            btnAddTestPaper.BackColor = Color.FromArgb(125, 185, 182);
            btnAddTestPaper.Cursor = Cursors.Hand;
            btnAddTestPaper.FlatAppearance.BorderSize = 0;
            btnAddTestPaper.FlatStyle = FlatStyle.Flat;
            btnAddTestPaper.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddTestPaper.ForeColor = Color.White;
            btnAddTestPaper.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAddTestPaper.IconColor = Color.White;
            btnAddTestPaper.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddTestPaper.IconSize = 25;
            btnAddTestPaper.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddTestPaper.Location = new Point(12, 104);
            btnAddTestPaper.Name = "btnAddTestPaper";
            btnAddTestPaper.Size = new Size(138, 32);
            btnAddTestPaper.TabIndex = 11;
            btnAddTestPaper.Text = "Add";
            btnAddTestPaper.UseVisualStyleBackColor = false;
            btnAddTestPaper.Click += btnAddTestPaper_Click;
            // 
            // pnTestPaperView
            // 
            pnTestPaperView.Controls.Add(dgvTestPaper);
            pnTestPaperView.Dock = DockStyle.Fill;
            pnTestPaperView.Location = new Point(0, 63);
            pnTestPaperView.Name = "pnTestPaperView";
            pnTestPaperView.Size = new Size(1024, 640);
            pnTestPaperView.TabIndex = 2;
            // 
            // dgvTestPaper
            // 
            dgvTestPaper.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTestPaper.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestPaper.Dock = DockStyle.Fill;
            dgvTestPaper.Location = new Point(0, 0);
            dgvTestPaper.Name = "dgvTestPaper";
            dgvTestPaper.RowTemplate.Height = 25;
            dgvTestPaper.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTestPaper.Size = new Size(1024, 640);
            dgvTestPaper.TabIndex = 0;
            dgvTestPaper.Click += dgvTestPaper_Click;
            dgvTestPaper.DoubleClick += dgvTestPaper_DoubleClick;
            // 
            // frmTestPaper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 703);
            Controls.Add(pnTestPaperView);
            Controls.Add(pnTestPaperToolBox);
            Controls.Add(pnTestPaperHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTestPaper";
            Text = "Test Paper";
            pnTestPaperHeader.ResumeLayout(false);
            pnTestPaperHeader.PerformLayout();
            pnTestPaperToolBox.ResumeLayout(false);
            pnTestPaperView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTestPaper).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTestPaperHeader;
        private Panel pnTestPaperToolBox;
        private Panel pnTestPaperView;
        private FontAwesome.Sharp.IconButton btnTestPaperDelete;
        private FontAwesome.Sharp.IconButton btnEditTestPaper;
        private FontAwesome.Sharp.IconButton btnAddTestPaper;
        private FontAwesome.Sharp.IconButton btnQuestionSearch;
        private TextBox inputQuestionSearch;
        private Label lblSearch;
        private Label lblFilerByCourse;
        private ComboBox cbFilterByCourse;
        private DataGridView dgvTestPaper;
    }
}