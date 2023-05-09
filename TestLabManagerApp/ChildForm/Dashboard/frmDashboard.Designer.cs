namespace TestLabManagerApp.ChildForm
{
    partial class frmDashboard
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
            btnTestPaper = new FontAwesome.Sharp.IconButton();
            btnQuestion = new FontAwesome.Sharp.IconButton();
            btnChapter = new FontAwesome.Sharp.IconButton();
            btnCourse = new FontAwesome.Sharp.IconButton();
            btnStudent = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTestPaper);
            panel1.Controls.Add(btnQuestion);
            panel1.Controls.Add(btnChapter);
            panel1.Controls.Add(btnCourse);
            panel1.Controls.Add(btnStudent);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 332);
            panel1.TabIndex = 0;
            // 
            // btnTestPaper
            // 
            btnTestPaper.BackColor = Color.FromArgb(241, 104, 104);
            btnTestPaper.Cursor = Cursors.Hand;
            btnTestPaper.FlatStyle = FlatStyle.Flat;
            btnTestPaper.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTestPaper.ForeColor = Color.White;
            btnTestPaper.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            btnTestPaper.IconColor = Color.White;
            btnTestPaper.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTestPaper.ImageAlign = ContentAlignment.MiddleLeft;
            btnTestPaper.Location = new Point(353, 186);
            btnTestPaper.Margin = new Padding(3, 2, 3, 2);
            btnTestPaper.Name = "btnTestPaper";
            btnTestPaper.Size = new Size(253, 86);
            btnTestPaper.TabIndex = 4;
            btnTestPaper.Text = "3 Test Paper";
            btnTestPaper.UseVisualStyleBackColor = false;
            // 
            // btnQuestion
            // 
            btnQuestion.BackColor = Color.FromArgb(255, 184, 77);
            btnQuestion.Cursor = Cursors.Hand;
            btnQuestion.FlatStyle = FlatStyle.Flat;
            btnQuestion.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuestion.ForeColor = Color.White;
            btnQuestion.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            btnQuestion.IconColor = Color.White;
            btnQuestion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuestion.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuestion.Location = new Point(46, 186);
            btnQuestion.Margin = new Padding(3, 2, 3, 2);
            btnQuestion.Name = "btnQuestion";
            btnQuestion.Size = new Size(253, 86);
            btnQuestion.TabIndex = 3;
            btnQuestion.Text = "120 Question";
            btnQuestion.UseVisualStyleBackColor = false;
            // 
            // btnChapter
            // 
            btnChapter.BackColor = Color.FromArgb(59, 152, 185);
            btnChapter.Cursor = Cursors.Hand;
            btnChapter.FlatStyle = FlatStyle.Flat;
            btnChapter.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnChapter.ForeColor = Color.White;
            btnChapter.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            btnChapter.IconColor = Color.White;
            btnChapter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChapter.ImageAlign = ContentAlignment.MiddleLeft;
            btnChapter.Location = new Point(660, 40);
            btnChapter.Margin = new Padding(3, 2, 3, 2);
            btnChapter.Name = "btnChapter";
            btnChapter.Size = new Size(253, 86);
            btnChapter.TabIndex = 2;
            btnChapter.Text = "24 Chapter";
            btnChapter.UseVisualStyleBackColor = false;
            // 
            // btnCourse
            // 
            btnCourse.BackColor = Color.FromArgb(164, 90, 209);
            btnCourse.Cursor = Cursors.Hand;
            btnCourse.FlatStyle = FlatStyle.Flat;
            btnCourse.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCourse.ForeColor = Color.White;
            btnCourse.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            btnCourse.IconColor = Color.White;
            btnCourse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCourse.ImageAlign = ContentAlignment.MiddleLeft;
            btnCourse.Location = new Point(353, 40);
            btnCourse.Margin = new Padding(3, 2, 3, 2);
            btnCourse.Name = "btnCourse";
            btnCourse.Size = new Size(253, 86);
            btnCourse.TabIndex = 1;
            btnCourse.Text = "12 Course";
            btnCourse.UseVisualStyleBackColor = false;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.FromArgb(114, 134, 211);
            btnStudent.Cursor = Cursors.Hand;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudent.ForeColor = Color.White;
            btnStudent.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnStudent.IconColor = Color.White;
            btnStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudent.Location = new Point(46, 40);
            btnStudent.Margin = new Padding(3, 2, 3, 2);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(253, 86);
            btnStudent.TabIndex = 0;
            btnStudent.Text = "30 Student";
            btnStudent.UseVisualStyleBackColor = false;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 562);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnTestPaper;
        private FontAwesome.Sharp.IconButton btnQuestion;
        private FontAwesome.Sharp.IconButton btnChapter;
        private FontAwesome.Sharp.IconButton btnCourse;
        private FontAwesome.Sharp.IconButton btnStudent;
    }
}