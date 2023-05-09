namespace TestLabManagerApp.ChildForm.Course
{
    partial class frmCourseEdit
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
            lblCourseName = new Label();
            inputCourse = new TextBox();
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
            btnCancel.Location = new Point(250, 96);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 31);
            btnCancel.TabIndex = 19;
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
            bntAdd.Location = new Point(48, 96);
            bntAdd.Margin = new Padding(3, 2, 3, 2);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(98, 31);
            bntAdd.TabIndex = 18;
            bntAdd.Text = "Save";
            bntAdd.UseVisualStyleBackColor = false;
            bntAdd.Click += bntAdd_Click;
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCourseName.Location = new Point(48, 30);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(101, 19);
            lblCourseName.TabIndex = 17;
            lblCourseName.Text = "Course name";
            // 
            // inputCourse
            // 
            inputCourse.Location = new Point(48, 50);
            inputCourse.Margin = new Padding(3, 2, 3, 2);
            inputCourse.Name = "inputCourse";
            inputCourse.Size = new Size(301, 23);
            inputCourse.TabIndex = 16;
            // 
            // frmCourseEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 150);
            Controls.Add(btnCancel);
            Controls.Add(bntAdd);
            Controls.Add(lblCourseName);
            Controls.Add(inputCourse);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCourseEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Course Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton bntAdd;
        private Label lblCourseName;
        private TextBox inputCourse;
    }
}