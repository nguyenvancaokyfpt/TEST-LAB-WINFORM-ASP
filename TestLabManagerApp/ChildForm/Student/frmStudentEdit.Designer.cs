namespace TestLabManagerApp.ChildForm.Student
{
    partial class frmStudentEdit
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
            bntSave = new FontAwesome.Sharp.IconButton();
            lblFullname = new Label();
            inputFullname = new TextBox();
            lblPassword = new Label();
            inputPassword = new TextBox();
            lblUsername = new Label();
            inputUsername = new TextBox();
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
            btnCancel.Location = new Point(250, 200);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 31);
            btnCancel.TabIndex = 15;
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
            bntSave.Location = new Point(48, 200);
            bntSave.Name = "bntSave";
            bntSave.RightToLeft = RightToLeft.No;
            bntSave.Size = new Size(98, 31);
            bntSave.TabIndex = 14;
            bntSave.Text = "Save";
            bntSave.UseVisualStyleBackColor = false;
            bntSave.Click += bntSave_Click;
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblFullname.Location = new Point(48, 25);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(72, 19);
            lblFullname.TabIndex = 13;
            lblFullname.Text = "Fullname";
            // 
            // inputFullname
            // 
            inputFullname.Location = new Point(48, 45);
            inputFullname.Margin = new Padding(3, 2, 3, 2);
            inputFullname.Name = "inputFullname";
            inputFullname.Size = new Size(301, 23);
            inputFullname.TabIndex = 12;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(48, 136);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(72, 19);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(48, 156);
            inputPassword.Margin = new Padding(3, 2, 3, 2);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(301, 23);
            inputPassword.TabIndex = 10;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(48, 79);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(77, 19);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username";
            // 
            // inputUsername
            // 
            inputUsername.Location = new Point(48, 100);
            inputUsername.Margin = new Padding(3, 2, 3, 2);
            inputUsername.Name = "inputUsername";
            inputUsername.Size = new Size(301, 23);
            inputUsername.TabIndex = 8;
            // 
            // frmStudentEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 259);
            Controls.Add(btnCancel);
            Controls.Add(bntSave);
            Controls.Add(lblFullname);
            Controls.Add(inputFullname);
            Controls.Add(lblPassword);
            Controls.Add(inputPassword);
            Controls.Add(lblUsername);
            Controls.Add(inputUsername);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmStudentEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Student Edit";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton bntSave;
        private Label lblFullname;
        private TextBox inputFullname;
        private Label lblPassword;
        private TextBox inputPassword;
        private Label lblUsername;
        private TextBox inputUsername;
    }
}