namespace TestLabManagerApp
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            txtTitle = new Label();
            inputPassword = new TextBox();
            label1 = new Label();
            inputUsername = new TextBox();
            label2 = new Label();
            btnSignIn = new Button();
            btnExit = new PictureBox();
            bntMinisize = new PictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bntMinisize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._20944201;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 550);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.BackColor = Color.Transparent;
            txtTitle.Font = new Font("Century Gothic", 17F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.ForeColor = Color.FromArgb(254, 112, 98);
            txtTitle.Location = new Point(569, 104);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(287, 27);
            txtTitle.TabIndex = 1;
            txtTitle.Text = "TestLab Manager System";
            // 
            // inputPassword
            // 
            inputPassword.AutoCompleteCustomSource.AddRange(new string[] { "admin" });
            inputPassword.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            inputPassword.BackColor = Color.FromArgb(209, 224, 255);
            inputPassword.BorderStyle = BorderStyle.None;
            inputPassword.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputPassword.Location = new Point(551, 313);
            inputPassword.Multiline = true;
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '●';
            inputPassword.Size = new Size(305, 30);
            inputPassword.TabIndex = 6;
            inputPassword.Enter += inputPassword_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(73, 75, 244);
            label1.Location = new Point(551, 213);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // inputUsername
            // 
            inputUsername.AutoCompleteCustomSource.AddRange(new string[] { "admin" });
            inputUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            inputUsername.BackColor = Color.FromArgb(209, 224, 255);
            inputUsername.BorderStyle = BorderStyle.None;
            inputUsername.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputUsername.Location = new Point(551, 235);
            inputUsername.Multiline = true;
            inputUsername.Name = "inputUsername";
            inputUsername.Size = new Size(305, 30);
            inputUsername.TabIndex = 5;
            inputUsername.Enter += inputUsername_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(73, 75, 244);
            label2.Location = new Point(551, 291);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(79, 82, 255);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderColor = Color.White;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(621, 390);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(160, 38);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(866, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(24, 24);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 8;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // bntMinisize
            // 
            bntMinisize.Image = (Image)resources.GetObject("bntMinisize.Image");
            bntMinisize.Location = new Point(832, 12);
            bntMinisize.Name = "bntMinisize";
            bntMinisize.Size = new Size(24, 24);
            bntMinisize.SizeMode = PictureBoxSizeMode.StretchImage;
            bntMinisize.TabIndex = 9;
            bntMinisize.TabStop = false;
            bntMinisize.Click += bntMinisize_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.Black;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.Black;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 23;
            iconPictureBox1.Location = new Point(522, 239);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(23, 30);
            iconPictureBox1.TabIndex = 10;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = Color.Black;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPictureBox2.IconColor = Color.Black;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 23;
            iconPictureBox2.Location = new Point(522, 318);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(23, 30);
            iconPictureBox2.TabIndex = 11;
            iconPictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(902, 549);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox1);
            Controls.Add(bntMinisize);
            Controls.Add(btnExit);
            Controls.Add(btnSignIn);
            Controls.Add(label2);
            Controls.Add(inputUsername);
            Controls.Add(label1);
            Controls.Add(inputPassword);
            Controls.Add(txtTitle);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "Form1";
            MouseDown += frmLogin_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)bntMinisize).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label txtTitle;
        private TextBox inputPassword;
        private Label label1;
        private TextBox inputUsername;
        private Label label2;
        private Button btnSignIn;
        private PictureBox btnExit;
        private PictureBox bntMinisize;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}