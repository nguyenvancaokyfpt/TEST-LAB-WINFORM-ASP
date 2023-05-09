namespace TestLabManagerApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnMenu = new Panel();
            btnTestPaper = new FontAwesome.Sharp.IconButton();
            btnQuestion = new FontAwesome.Sharp.IconButton();
            btnChapter = new FontAwesome.Sharp.IconButton();
            btnCourse = new FontAwesome.Sharp.IconButton();
            btnStudent = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            pnLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            bntMaximize = new FontAwesome.Sharp.IconButton();
            btnMinisize = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            lblCurrentChildTitle = new Label();
            currentChildIcon = new FontAwesome.Sharp.IconPictureBox();
            pnShadow = new Panel();
            pnDesktop = new Panel();
            btnSubmitPaper = new FontAwesome.Sharp.IconButton();
            pnMenu.SuspendLayout();
            pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)currentChildIcon).BeginInit();
            SuspendLayout();
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.FromArgb(23, 44, 123);
            pnMenu.Controls.Add(btnSubmitPaper);
            pnMenu.Controls.Add(btnTestPaper);
            pnMenu.Controls.Add(btnQuestion);
            pnMenu.Controls.Add(btnChapter);
            pnMenu.Controls.Add(btnCourse);
            pnMenu.Controls.Add(btnStudent);
            pnMenu.Controls.Add(btnDashboard);
            pnMenu.Controls.Add(pnLogo);
            pnMenu.Dock = DockStyle.Left;
            pnMenu.Location = new Point(0, 0);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(249, 751);
            pnMenu.TabIndex = 0;
            // 
            // btnTestPaper
            // 
            btnTestPaper.Cursor = Cursors.Hand;
            btnTestPaper.Dock = DockStyle.Top;
            btnTestPaper.FlatAppearance.BorderSize = 0;
            btnTestPaper.FlatStyle = FlatStyle.Flat;
            btnTestPaper.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnTestPaper.ForeColor = SystemColors.ButtonHighlight;
            btnTestPaper.IconChar = FontAwesome.Sharp.IconChar.File;
            btnTestPaper.IconColor = Color.White;
            btnTestPaper.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTestPaper.IconSize = 32;
            btnTestPaper.ImageAlign = ContentAlignment.MiddleLeft;
            btnTestPaper.Location = new Point(0, 469);
            btnTestPaper.Name = "btnTestPaper";
            btnTestPaper.Size = new Size(249, 65);
            btnTestPaper.TabIndex = 6;
            btnTestPaper.Text = "Test Paper";
            btnTestPaper.TextAlign = ContentAlignment.MiddleLeft;
            btnTestPaper.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTestPaper.UseVisualStyleBackColor = true;
            btnTestPaper.Click += btnTestPaper_Click;
            // 
            // btnQuestion
            // 
            btnQuestion.Cursor = Cursors.Hand;
            btnQuestion.Dock = DockStyle.Top;
            btnQuestion.FlatAppearance.BorderSize = 0;
            btnQuestion.FlatStyle = FlatStyle.Flat;
            btnQuestion.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuestion.ForeColor = SystemColors.ButtonHighlight;
            btnQuestion.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            btnQuestion.IconColor = Color.White;
            btnQuestion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuestion.IconSize = 32;
            btnQuestion.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuestion.Location = new Point(0, 404);
            btnQuestion.Name = "btnQuestion";
            btnQuestion.Size = new Size(249, 65);
            btnQuestion.TabIndex = 5;
            btnQuestion.Text = "Question";
            btnQuestion.TextAlign = ContentAlignment.MiddleLeft;
            btnQuestion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuestion.UseVisualStyleBackColor = true;
            btnQuestion.Click += btnQuestion_Click;
            // 
            // btnChapter
            // 
            btnChapter.Cursor = Cursors.Hand;
            btnChapter.Dock = DockStyle.Top;
            btnChapter.FlatAppearance.BorderSize = 0;
            btnChapter.FlatStyle = FlatStyle.Flat;
            btnChapter.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnChapter.ForeColor = SystemColors.ButtonHighlight;
            btnChapter.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            btnChapter.IconColor = Color.White;
            btnChapter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChapter.IconSize = 32;
            btnChapter.ImageAlign = ContentAlignment.MiddleLeft;
            btnChapter.Location = new Point(0, 339);
            btnChapter.Name = "btnChapter";
            btnChapter.Size = new Size(249, 65);
            btnChapter.TabIndex = 4;
            btnChapter.Text = "Chapter";
            btnChapter.TextAlign = ContentAlignment.MiddleLeft;
            btnChapter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChapter.UseVisualStyleBackColor = true;
            btnChapter.Click += btnChapter_Click;
            // 
            // btnCourse
            // 
            btnCourse.Cursor = Cursors.Hand;
            btnCourse.Dock = DockStyle.Top;
            btnCourse.FlatAppearance.BorderSize = 0;
            btnCourse.FlatStyle = FlatStyle.Flat;
            btnCourse.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCourse.ForeColor = SystemColors.ButtonHighlight;
            btnCourse.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            btnCourse.IconColor = Color.White;
            btnCourse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCourse.IconSize = 32;
            btnCourse.ImageAlign = ContentAlignment.MiddleLeft;
            btnCourse.Location = new Point(0, 274);
            btnCourse.Name = "btnCourse";
            btnCourse.Size = new Size(249, 65);
            btnCourse.TabIndex = 3;
            btnCourse.Text = "Course";
            btnCourse.TextAlign = ContentAlignment.MiddleLeft;
            btnCourse.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCourse.UseVisualStyleBackColor = true;
            btnCourse.Click += btnCourse_Click;
            // 
            // btnStudent
            // 
            btnStudent.Cursor = Cursors.Hand;
            btnStudent.Dock = DockStyle.Top;
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudent.ForeColor = SystemColors.ButtonHighlight;
            btnStudent.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnStudent.IconColor = Color.White;
            btnStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStudent.IconSize = 32;
            btnStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudent.Location = new Point(0, 209);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(249, 65);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Student";
            btnStudent.TextAlign = ContentAlignment.MiddleLeft;
            btnStudent.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = SystemColors.ButtonHighlight;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Cube;
            btnDashboard.IconColor = Color.White;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 32;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 144);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(249, 65);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.White;
            pnLogo.Controls.Add(pictureBox1);
            pnLogo.Dock = DockStyle.Top;
            pnLogo.Location = new Point(0, 0);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(249, 144);
            pnLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 44, 123);
            panel1.Controls.Add(bntMaximize);
            panel1.Controls.Add(btnMinisize);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(lblCurrentChildTitle);
            panel1.Controls.Add(currentChildIcon);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(249, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 70);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // bntMaximize
            // 
            bntMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntMaximize.BackColor = Color.Transparent;
            bntMaximize.FlatAppearance.BorderSize = 0;
            bntMaximize.FlatStyle = FlatStyle.Flat;
            bntMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            bntMaximize.IconColor = Color.DodgerBlue;
            bntMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntMaximize.IconSize = 25;
            bntMaximize.Location = new Point(897, 3);
            bntMaximize.Name = "bntMaximize";
            bntMaximize.Size = new Size(23, 21);
            bntMaximize.TabIndex = 4;
            bntMaximize.UseVisualStyleBackColor = false;
            bntMaximize.Click += bntMaximize_Click;
            // 
            // btnMinisize
            // 
            btnMinisize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinisize.BackColor = Color.Transparent;
            btnMinisize.FlatAppearance.BorderSize = 0;
            btnMinisize.FlatStyle = FlatStyle.Flat;
            btnMinisize.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            btnMinisize.IconColor = Color.DodgerBlue;
            btnMinisize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinisize.IconSize = 25;
            btnMinisize.Location = new Point(868, 3);
            btnMinisize.Name = "btnMinisize";
            btnMinisize.Size = new Size(23, 21);
            btnMinisize.TabIndex = 3;
            btnMinisize.UseVisualStyleBackColor = false;
            btnMinisize.Click += btnMinisize_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            btnExit.IconColor = Color.IndianRed;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 25;
            btnExit.Location = new Point(924, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(23, 21);
            btnExit.TabIndex = 2;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblCurrentChildTitle
            // 
            lblCurrentChildTitle.AutoSize = true;
            lblCurrentChildTitle.BackColor = Color.Transparent;
            lblCurrentChildTitle.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentChildTitle.ForeColor = Color.White;
            lblCurrentChildTitle.Location = new Point(51, 30);
            lblCurrentChildTitle.Name = "lblCurrentChildTitle";
            lblCurrentChildTitle.Size = new Size(52, 18);
            lblCurrentChildTitle.TabIndex = 1;
            lblCurrentChildTitle.Text = "Home";
            // 
            // currentChildIcon
            // 
            currentChildIcon.BackColor = Color.FromArgb(23, 44, 123);
            currentChildIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            currentChildIcon.IconColor = Color.White;
            currentChildIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            currentChildIcon.Location = new Point(13, 19);
            currentChildIcon.Name = "currentChildIcon";
            currentChildIcon.Size = new Size(32, 32);
            currentChildIcon.TabIndex = 0;
            currentChildIcon.TabStop = false;
            // 
            // pnShadow
            // 
            pnShadow.BackColor = Color.FromArgb(11, 26, 91);
            pnShadow.Dock = DockStyle.Top;
            pnShadow.Location = new Point(249, 70);
            pnShadow.Name = "pnShadow";
            pnShadow.Size = new Size(950, 10);
            pnShadow.TabIndex = 2;
            // 
            // pnDesktop
            // 
            pnDesktop.BackColor = Color.FromArgb(46, 81, 163);
            pnDesktop.Dock = DockStyle.Fill;
            pnDesktop.Location = new Point(249, 80);
            pnDesktop.Name = "pnDesktop";
            pnDesktop.Size = new Size(950, 671);
            pnDesktop.TabIndex = 3;
            // 
            // btnSubmitPaper
            // 
            btnSubmitPaper.Cursor = Cursors.Hand;
            btnSubmitPaper.Dock = DockStyle.Top;
            btnSubmitPaper.FlatAppearance.BorderSize = 0;
            btnSubmitPaper.FlatStyle = FlatStyle.Flat;
            btnSubmitPaper.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitPaper.ForeColor = SystemColors.ButtonHighlight;
            btnSubmitPaper.IconChar = FontAwesome.Sharp.IconChar.FileLines;
            btnSubmitPaper.IconColor = Color.White;
            btnSubmitPaper.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSubmitPaper.IconSize = 32;
            btnSubmitPaper.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmitPaper.Location = new Point(0, 534);
            btnSubmitPaper.Name = "btnSubmitPaper";
            btnSubmitPaper.Size = new Size(249, 65);
            btnSubmitPaper.TabIndex = 7;
            btnSubmitPaper.Text = "Submit Paper";
            btnSubmitPaper.TextAlign = ContentAlignment.MiddleLeft;
            btnSubmitPaper.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSubmitPaper.UseVisualStyleBackColor = true;
            btnSubmitPaper.Click += btnSubmitPaper_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 751);
            Controls.Add(pnDesktop);
            Controls.Add(pnShadow);
            Controls.Add(panel1);
            Controls.Add(pnMenu);
            Name = "frmMain";
            Text = "frmDashboard";
            pnMenu.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)currentChildIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMenu;
        private Panel pnLogo;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnQuestion;
        private FontAwesome.Sharp.IconButton btnChapter;
        private FontAwesome.Sharp.IconButton btnCourse;
        private FontAwesome.Sharp.IconButton btnStudent;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnTestPaper;
        private Panel panel1;
        private Label lblCurrentChildTitle;
        private FontAwesome.Sharp.IconPictureBox currentChildIcon;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinisize;
        private FontAwesome.Sharp.IconButton bntMaximize;
        private Panel pnShadow;
        private Panel pnDesktop;
        private FontAwesome.Sharp.IconButton btnSubmitPaper;
    }
}