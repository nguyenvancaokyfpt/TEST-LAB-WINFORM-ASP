namespace TestLabManagerApp.ChildForm.Chapter
{
    partial class frmChapterAdd
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
            btnCancel = new FontAwesome.Sharp.IconButton();
            bntAdd = new FontAwesome.Sharp.IconButton();
            lblChapterName = new Label();
            inputCourse = new TextBox();
            cbCourse = new ComboBox();
            lblCourse = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(245, 81, 81);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            btnCancel.IconColor = Color.White;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 23;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(228, 140);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 32);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            bntAdd.IconSize = 23;
            bntAdd.ImageAlign = ContentAlignment.MiddleLeft;
            bntAdd.Location = new Point(26, 140);
            bntAdd.Margin = new Padding(3, 2, 3, 2);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(98, 32);
            bntAdd.TabIndex = 14;
            bntAdd.Text = "Add";
            bntAdd.UseVisualStyleBackColor = false;
            bntAdd.Click += bntAdd_Click;
            // 
            // lblChapterName
            // 
            lblChapterName.AutoSize = true;
            lblChapterName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblChapterName.Location = new Point(26, 17);
            lblChapterName.Name = "lblChapterName";
            lblChapterName.Size = new Size(113, 19);
            lblChapterName.TabIndex = 9;
            lblChapterName.Text = "Chapter Name";
            // 
            // inputCourse
            // 
            inputCourse.Location = new Point(26, 40);
            inputCourse.Margin = new Padding(3, 2, 3, 2);
            inputCourse.Name = "inputCourse";
            inputCourse.Size = new Size(301, 23);
            inputCourse.TabIndex = 8;
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(26, 89);
            cbCourse.Margin = new Padding(3, 2, 3, 2);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(301, 23);
            cbCourse.TabIndex = 16;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCourse.Location = new Point(26, 68);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(56, 19);
            lblCourse.TabIndex = 17;
            lblCourse.Text = "Course";
            // 
            // frmChapterAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 190);
            Controls.Add(lblCourse);
            Controls.Add(cbCourse);
            Controls.Add(btnCancel);
            Controls.Add(bntAdd);
            Controls.Add(lblChapterName);
            Controls.Add(inputCourse);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmChapterAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chapter Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton bntAdd;
        private Label lblChapterName;
        private TextBox inputCourse;
        private ComboBox cbCourse;
        private Label lblCourse;
    }
}