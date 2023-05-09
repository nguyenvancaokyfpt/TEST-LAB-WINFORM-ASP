namespace TestLabManagerApp.ChildForm.Student
{
    partial class frmStudentAdd
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
            inputUsername = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            inputPassword = new TextBox();
            lblFullname = new Label();
            inputFullname = new TextBox();
            bntAdd = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // inputUsername
            // 
            inputUsername.Location = new Point(49, 93);
            inputUsername.Margin = new Padding(3, 2, 3, 2);
            inputUsername.Name = "inputUsername";
            inputUsername.Size = new Size(301, 23);
            inputUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(49, 73);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(77, 19);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(49, 129);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(72, 19);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(49, 149);
            inputPassword.Margin = new Padding(3, 2, 3, 2);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(301, 23);
            inputPassword.TabIndex = 2;
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblFullname.Location = new Point(49, 18);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(72, 19);
            lblFullname.TabIndex = 5;
            lblFullname.Text = "Fullname";
            // 
            // inputFullname
            // 
            inputFullname.Location = new Point(49, 38);
            inputFullname.Margin = new Padding(3, 2, 3, 2);
            inputFullname.Name = "inputFullname";
            inputFullname.Size = new Size(301, 23);
            inputFullname.TabIndex = 4;
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
            bntAdd.Location = new Point(49, 202);
            bntAdd.Margin = new Padding(3, 2, 3, 2);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(98, 31);
            bntAdd.TabIndex = 6;
            bntAdd.Text = "Add";
            bntAdd.UseVisualStyleBackColor = false;
            bntAdd.Click += bntAdd_Click;
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
            btnCancel.Location = new Point(251, 202);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 31);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmStudentAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 259);
            Controls.Add(btnCancel);
            Controls.Add(bntAdd);
            Controls.Add(lblFullname);
            Controls.Add(inputFullname);
            Controls.Add(lblPassword);
            Controls.Add(inputPassword);
            Controls.Add(lblUsername);
            Controls.Add(inputUsername);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmStudentAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Student";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputUsername;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox inputPassword;
        private Label lblFullname;
        private TextBox inputFullname;
        private FontAwesome.Sharp.IconButton bntAdd;
        private FontAwesome.Sharp.IconButton btnCancel;
    }
}