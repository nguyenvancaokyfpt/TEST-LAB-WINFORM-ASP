namespace TestLabManagerApp.ChildForm.Question
{
    partial class frmQuestionAnswerAddEdit
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
            lblAnswer = new Label();
            panel1 = new Panel();
            inputAnswers = new RichTextBox();
            panel1.SuspendLayout();
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
            btnCancel.Location = new Point(392, 2);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 36);
            btnCancel.TabIndex = 23;
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
            bntAdd.Location = new Point(157, 2);
            bntAdd.Margin = new Padding(3, 2, 3, 2);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(98, 36);
            bntAdd.TabIndex = 22;
            bntAdd.Text = "Save";
            bntAdd.UseVisualStyleBackColor = false;
            bntAdd.Click += bntAdd_Click;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnswer.Location = new Point(26, 12);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(61, 19);
            lblAnswer.TabIndex = 21;
            lblAnswer.Text = "Answer:";
            // 
            // panel1
            // 
            panel1.Controls.Add(bntAdd);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 209);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 46);
            panel1.TabIndex = 24;
            // 
            // inputAnswers
            // 
            inputAnswers.Location = new Point(26, 37);
            inputAnswers.Margin = new Padding(3, 2, 3, 2);
            inputAnswers.Name = "inputAnswers";
            inputAnswers.Size = new Size(649, 152);
            inputAnswers.TabIndex = 25;
            inputAnswers.Text = "";
            // 
            // frmQuestionAnswerAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 255);
            Controls.Add(inputAnswers);
            Controls.Add(panel1);
            Controls.Add(lblAnswer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmQuestionAnswerAddEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Answer";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton bntAdd;
        private Label lblAnswer;
        private Panel panel1;
        private RichTextBox inputAnswers;
    }
}