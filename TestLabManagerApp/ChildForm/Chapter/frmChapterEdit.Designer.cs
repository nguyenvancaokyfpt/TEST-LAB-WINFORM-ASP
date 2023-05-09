namespace TestLabManagerApp.ChildForm.Chapter
{
    partial class frmChapterEdit
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
            lblCourse = new Label();
            cbCourse = new ComboBox();
            btnCancel = new FontAwesome.Sharp.IconButton();
            bntSave = new FontAwesome.Sharp.IconButton();
            lblChapterName = new Label();
            inputCourse = new TextBox();
            SuspendLayout();
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCourse.Location = new Point(29, 65);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(56, 19);
            lblCourse.TabIndex = 23;
            lblCourse.Text = "Course";
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(29, 87);
            cbCourse.Margin = new Padding(3, 2, 3, 2);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(301, 23);
            cbCourse.TabIndex = 22;
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
            btnCancel.Location = new Point(231, 139);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 31);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // bntSave
            // 
            bntSave.BackColor = Color.FromArgb(142, 167, 233);
            bntSave.Cursor = Cursors.Hand;
            bntSave.FlatAppearance.BorderSize = 0;
            bntSave.FlatStyle = FlatStyle.Flat;
            bntSave.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bntSave.ForeColor = Color.White;
            bntSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            bntSave.IconColor = Color.White;
            bntSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntSave.IconSize = 23;
            bntSave.ImageAlign = ContentAlignment.MiddleLeft;
            bntSave.Location = new Point(29, 139);
            bntSave.Margin = new Padding(3, 2, 3, 2);
            bntSave.Name = "bntSave";
            bntSave.Size = new Size(98, 31);
            bntSave.TabIndex = 20;
            bntSave.Text = "Save";
            bntSave.UseVisualStyleBackColor = false;
            bntSave.Click += bntSave_Click;
            // 
            // lblChapterName
            // 
            lblChapterName.AutoSize = true;
            lblChapterName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblChapterName.Location = new Point(29, 16);
            lblChapterName.Name = "lblChapterName";
            lblChapterName.Size = new Size(113, 19);
            lblChapterName.TabIndex = 19;
            lblChapterName.Text = "Chapter Name";
            // 
            // inputCourse
            // 
            inputCourse.Location = new Point(29, 38);
            inputCourse.Margin = new Padding(3, 2, 3, 2);
            inputCourse.Name = "inputCourse";
            inputCourse.Size = new Size(301, 23);
            inputCourse.TabIndex = 18;
            // 
            // frmChapterEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 190);
            Controls.Add(lblCourse);
            Controls.Add(cbCourse);
            Controls.Add(btnCancel);
            Controls.Add(bntSave);
            Controls.Add(lblChapterName);
            Controls.Add(inputCourse);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmChapterEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chapter Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCourse;
        private ComboBox cbCourse;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton bntSave;
        private Label lblChapterName;
        private TextBox inputCourse;
    }
}