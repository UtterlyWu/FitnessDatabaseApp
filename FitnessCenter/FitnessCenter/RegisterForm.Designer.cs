namespace FitnessCenter
{
    partial class RegisterForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            option_member = new CheckBox();
            option_trainer = new CheckBox();
            option_admin = new CheckBox();
            ErrorText = new Label();
            Register = new Button();
            username = new TextBox();
            password = new TextBox();
            firstname = new TextBox();
            lastname = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 36);
            label1.Name = "label1";
            label1.Size = new Size(254, 20);
            label1.TabIndex = 0;
            label1.Text = "We're gonna need some information:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 182);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 223);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(41, 264);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 3;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(41, 305);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 4;
            label5.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 350);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 88);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 6;
            label7.Text = "Register as a:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(163, 72);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(249, 72);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(327, 72);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 9;
            // 
            // option_member
            // 
            option_member.AutoSize = true;
            option_member.Location = new Point(143, 88);
            option_member.Name = "option_member";
            option_member.Size = new Size(87, 24);
            option_member.TabIndex = 10;
            option_member.Text = "Member";
            option_member.UseVisualStyleBackColor = true;
            option_member.CheckedChanged += option_member_CheckedChanged;
            // 
            // option_trainer
            // 
            option_trainer.AutoSize = true;
            option_trainer.Location = new Point(143, 118);
            option_trainer.Name = "option_trainer";
            option_trainer.Size = new Size(76, 24);
            option_trainer.TabIndex = 11;
            option_trainer.Text = "Trainer";
            option_trainer.UseVisualStyleBackColor = true;
            option_trainer.CheckedChanged += option_trainer_CheckedChanged;
            // 
            // option_admin
            // 
            option_admin.AutoSize = true;
            option_admin.Location = new Point(143, 148);
            option_admin.Name = "option_admin";
            option_admin.Size = new Size(75, 24);
            option_admin.TabIndex = 12;
            option_admin.Text = "Admin";
            option_admin.UseVisualStyleBackColor = true;
            option_admin.CheckedChanged += option_admin_CheckedChanged;
            // 
            // ErrorText
            // 
            ErrorText.AutoSize = true;
            ErrorText.ForeColor = Color.Red;
            ErrorText.Location = new Point(136, 335);
            ErrorText.Name = "ErrorText";
            ErrorText.Size = new Size(87, 20);
            ErrorText.TabIndex = 13;
            ErrorText.Text = "ERRORTEXT";
            // 
            // Register
            // 
            Register.Location = new Point(136, 358);
            Register.Name = "Register";
            Register.Size = new Size(94, 29);
            Register.TabIndex = 14;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            username.Location = new Point(122, 179);
            username.Name = "username";
            username.Size = new Size(125, 27);
            username.TabIndex = 15;
            // 
            // password
            // 
            password.Location = new Point(122, 223);
            password.Name = "password";
            password.Size = new Size(125, 27);
            password.TabIndex = 16;
            // 
            // firstname
            // 
            firstname.Location = new Point(122, 264);
            firstname.Name = "firstname";
            firstname.Size = new Size(125, 27);
            firstname.TabIndex = 17;
            // 
            // lastname
            // 
            lastname.Location = new Point(122, 302);
            lastname.Name = "lastname";
            lastname.Size = new Size(125, 27);
            lastname.TabIndex = 18;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 408);
            Controls.Add(lastname);
            Controls.Add(firstname);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(Register);
            Controls.Add(ErrorText);
            Controls.Add(option_admin);
            Controls.Add(option_trainer);
            Controls.Add(option_member);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private CheckBox option_member;
        private CheckBox option_trainer;
        private CheckBox option_admin;
        private Label ErrorText;
        private Button Register;
        private TextBox username;
        private TextBox password;
        private TextBox firstname;
        private TextBox lastname;
    }
}