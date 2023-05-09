namespace TestLabManagerApp.ChildForm
{
    partial class frmSubmitPaper
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
            lblFilerByCourse = new Label();
            inputStudent = new TextBox();
            cbFilterByPaper = new ComboBox();
            btnStudentSearch = new FontAwesome.Sharp.IconButton();
            lblSearch = new Label();
            panel2 = new Panel();
            btnDelete = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblFilerByCourse);
            panel1.Controls.Add(inputStudent);
            panel1.Controls.Add(cbFilterByPaper);
            panel1.Controls.Add(btnStudentSearch);
            panel1.Controls.Add(lblSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1166, 64);
            panel1.TabIndex = 0;
            // 
            // lblFilerByCourse
            // 
            lblFilerByCourse.AutoSize = true;
            lblFilerByCourse.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFilerByCourse.Location = new Point(591, 9);
            lblFilerByCourse.Name = "lblFilerByCourse";
            lblFilerByCourse.Size = new Size(90, 16);
            lblFilerByCourse.TabIndex = 23;
            lblFilerByCourse.Text = "Filter by Paper";
            // 
            // inputStudent
            // 
            inputStudent.Location = new Point(12, 29);
            inputStudent.Name = "inputStudent";
            inputStudent.Size = new Size(395, 23);
            inputStudent.TabIndex = 20;
            // 
            // cbFilterByPaper
            // 
            cbFilterByPaper.FormattingEnabled = true;
            cbFilterByPaper.Location = new Point(591, 29);
            cbFilterByPaper.Name = "cbFilterByPaper";
            cbFilterByPaper.Size = new Size(303, 23);
            cbFilterByPaper.TabIndex = 22;
            cbFilterByPaper.SelectedIndexChanged += cbFilterByPaper_SelectedIndexChanged;
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
            btnStudentSearch.Location = new Point(413, 29);
            btnStudentSearch.Name = "btnStudentSearch";
            btnStudentSearch.Size = new Size(138, 23);
            btnStudentSearch.TabIndex = 19;
            btnStudentSearch.Text = "Search";
            btnStudentSearch.UseVisualStyleBackColor = false;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(14, 10);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(93, 16);
            lblSearch.TabIndex = 21;
            lblSearch.Text = "Search Student";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDelete);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1004, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 590);
            panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(235, 70, 96);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnDelete.IconColor = Color.White;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 25;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(12, 98);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 32);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(1004, 590);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1004, 590);
            dataGridView1.TabIndex = 0;
            // 
            // frmSubmitPaper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 654);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSubmitPaper";
            Text = "frmSubmitPaper";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Label lblFilerByCourse;
        private TextBox inputStudent;
        private ComboBox cbFilterByPaper;
        private FontAwesome.Sharp.IconButton btnStudentSearch;
        private Label lblSearch;
        private FontAwesome.Sharp.IconButton btnDelete;
    }
}