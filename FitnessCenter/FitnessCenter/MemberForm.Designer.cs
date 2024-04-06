namespace FitnessCenter
{
    partial class MemberForm
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
            logout = new Button();
            usernameLabel = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            username = new Label();
            name = new Label();
            Sessions = new ListBox();
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            errorText = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // logout
            // 
            logout.Location = new Point(12, 151);
            logout.Margin = new Padding(3, 4, 3, 4);
            logout.Name = "logout";
            logout.Size = new Size(86, 31);
            logout.TabIndex = 33;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(12, 19);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Padding = new Padding(0, 0, 0, 20);
            usernameLabel.Size = new Size(97, 40);
            usernameLabel.TabIndex = 32;
            usernameLabel.Text = "Logged in as:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(152, 14);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(571, 463);
            tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(errorText);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(monthCalendar1);
            tabPage1.Controls.Add(Sessions);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(563, 430);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(683, 430);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(12, 59);
            username.Name = "username";
            username.Size = new Size(50, 20);
            username.TabIndex = 36;
            username.Text = "label1";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(12, 99);
            name.Name = "name";
            name.Size = new Size(50, 20);
            name.TabIndex = 37;
            name.Text = "label2";
            // 
            // Sessions
            // 
            Sessions.FormattingEnabled = true;
            Sessions.Location = new Point(20, 16);
            Sessions.Name = "Sessions";
            Sessions.Size = new Size(201, 384);
            Sessions.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(255, 16);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(319, 323);
            button1.Name = "button1";
            button1.Size = new Size(138, 54);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // errorText
            // 
            errorText.AutoSize = true;
            errorText.ForeColor = Color.Red;
            errorText.Location = new Point(361, 290);
            errorText.Name = "errorText";
            errorText.Size = new Size(50, 20);
            errorText.TabIndex = 3;
            errorText.Text = "label1";
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 490);
            Controls.Add(name);
            Controls.Add(username);
            Controls.Add(tabControl1);
            Controls.Add(logout);
            Controls.Add(usernameLabel);
            Name = "MemberForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logout;
        private Label usernameLabel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label username;
        private Label name;
        private MonthCalendar monthCalendar1;
        private ListBox Sessions;
        private Label errorText;
        private Button button1;
    }
}