namespace FitnessCenter
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            usernameTB = new TextBox();
            passwordTB = new TextBox();
            login = new Button();
            label4 = new Label();
            Register = new Button();
            ErrorText = new Label();
            Option_Member = new CheckBox();
            Option_Trainer = new CheckBox();
            Option_Admin = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 21);
            label1.Name = "label1";
            label1.Size = new Size(323, 20);
            label1.TabIndex = 0;
            label1.Text = "Welcome! Please enter username and password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 86);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 133);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(136, 86);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(125, 27);
            usernameTB.TabIndex = 3;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(136, 130);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(125, 27);
            passwordTB.TabIndex = 4;
            // 
            // login
            // 
            login.Location = new Point(149, 205);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 5;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 73);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 6;
            label4.Text = "OR";
            // 
            // Register
            // 
            Register.Location = new Point(299, 107);
            Register.Name = "Register";
            Register.Size = new Size(94, 29);
            Register.TabIndex = 7;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click;
            // 
            // ErrorText
            // 
            ErrorText.AutoSize = true;
            ErrorText.ForeColor = Color.Red;
            ErrorText.Location = new Point(149, 182);
            ErrorText.Name = "ErrorText";
            ErrorText.Size = new Size(15, 20);
            ErrorText.TabIndex = 8;
            ErrorText.Text = "\\";
            // 
            // Option_Member
            // 
            Option_Member.AutoSize = true;
            Option_Member.Location = new Point(47, 50);
            Option_Member.Name = "Option_Member";
            Option_Member.Size = new Size(87, 24);
            Option_Member.TabIndex = 9;
            Option_Member.Text = "Member";
            Option_Member.UseVisualStyleBackColor = true;
            Option_Member.CheckedChanged += Option_Member_CheckedChanged;
            // 
            // Option_Trainer
            // 
            Option_Trainer.AutoSize = true;
            Option_Trainer.Location = new Point(140, 50);
            Option_Trainer.Name = "Option_Trainer";
            Option_Trainer.Size = new Size(76, 24);
            Option_Trainer.TabIndex = 10;
            Option_Trainer.Text = "Trainer";
            Option_Trainer.UseVisualStyleBackColor = true;
            Option_Trainer.CheckedChanged += Option_Trainer_CheckedChanged;
            // 
            // Option_Admin
            // 
            Option_Admin.AutoSize = true;
            Option_Admin.Location = new Point(222, 50);
            Option_Admin.Name = "Option_Admin";
            Option_Admin.Size = new Size(75, 24);
            Option_Admin.TabIndex = 11;
            Option_Admin.Text = "Admin";
            Option_Admin.UseVisualStyleBackColor = true;
            Option_Admin.CheckedChanged += Option_Admin_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 285);
            Controls.Add(Option_Admin);
            Controls.Add(Option_Trainer);
            Controls.Add(Option_Member);
            Controls.Add(ErrorText);
            Controls.Add(Register);
            Controls.Add(label4);
            Controls.Add(login);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usernameTB;
        private TextBox passwordTB;
        private Button login;
        private Label label4;
        private Button Register;
        private Label ErrorText;
        private CheckBox Option_Member;
        private CheckBox Option_Trainer;
        private CheckBox Option_Admin;
    }
}
