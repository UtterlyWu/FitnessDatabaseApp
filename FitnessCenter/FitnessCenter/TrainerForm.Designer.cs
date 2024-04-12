namespace FitnessCenter
{
    partial class TrainerForm
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
            usernameTextBox = new TextBox();
            nameLabel = new Label();
            label4 = new Label();
            curWeightLabel = new Label();
            sexLabel = new Label();
            desiredWeightLabel = new Label();
            joinDateLabel = new Label();
            heightLabel = new Label();
            submitUsername = new Button();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label15 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            viewAchievementButton = new Button();
            deleteAchivementButton = new Button();
            achievementDescriptionBox = new TextBox();
            label2 = new Label();
            achievementNameBox = new TextBox();
            submitAchievement = new Button();
            achievementListBox = new ListBox();
            sessionPage = new TabPage();
            refreshSessions = new Button();
            sessionListBox = new ListBox();
            label14 = new Label();
            sesCapacityLabel = new Label();
            attendingUserList = new ListBox();
            label9 = new Label();
            sesLocationLabel = new Label();
            sesDateLabel = new Label();
            sesTypeLabel = new Label();
            sesNameLabel = new Label();
            sesDescriptionTxt = new TextBox();
            usernameLabel = new Label();
            openFileDialog1 = new OpenFileDialog();
            trainerNameLabel = new Label();
            logout = new Button();
            label1 = new Label();
            availabilityListBox = new ListBox();
            addTimeButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            deleteTimeButton = new Button();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            sessionPage.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(346, 46);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Member username...";
            usernameTextBox.Size = new Size(150, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(346, 71);
            nameLabel.Name = "nameLabel";
            nameLabel.Padding = new Padding(0, 10, 0, 10);
            nameLabel.Size = new Size(42, 35);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 174);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 4;
            // 
            // curWeightLabel
            // 
            curWeightLabel.AutoSize = true;
            curWeightLabel.Location = new Point(346, 131);
            curWeightLabel.Name = "curWeightLabel";
            curWeightLabel.Padding = new Padding(0, 0, 0, 10);
            curWeightLabel.Size = new Size(91, 25);
            curWeightLabel.TabIndex = 5;
            curWeightLabel.Text = "Current Weight:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new Point(346, 106);
            sexLabel.Name = "sexLabel";
            sexLabel.Padding = new Padding(0, 0, 0, 10);
            sexLabel.Size = new Size(28, 25);
            sexLabel.TabIndex = 6;
            sexLabel.Text = "Sex:";
            // 
            // desiredWeightLabel
            // 
            desiredWeightLabel.AutoSize = true;
            desiredWeightLabel.Location = new Point(346, 156);
            desiredWeightLabel.Name = "desiredWeightLabel";
            desiredWeightLabel.Padding = new Padding(0, 0, 0, 10);
            desiredWeightLabel.Size = new Size(90, 25);
            desiredWeightLabel.TabIndex = 7;
            desiredWeightLabel.Text = "Desired Weight:";
            // 
            // joinDateLabel
            // 
            joinDateLabel.AutoSize = true;
            joinDateLabel.Location = new Point(346, 181);
            joinDateLabel.Name = "joinDateLabel";
            joinDateLabel.Padding = new Padding(0, 0, 0, 10);
            joinDateLabel.Size = new Size(58, 25);
            joinDateLabel.TabIndex = 8;
            joinDateLabel.Text = "Join Date:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(346, 205);
            heightLabel.Name = "heightLabel";
            heightLabel.Padding = new Padding(0, 0, 0, 10);
            heightLabel.Size = new Size(46, 25);
            heightLabel.TabIndex = 10;
            heightLabel.Text = "Height:";
            // 
            // submitUsername
            // 
            submitUsername.Location = new Point(502, 45);
            submitUsername.Name = "submitUsername";
            submitUsername.Size = new Size(75, 23);
            submitUsername.TabIndex = 12;
            submitUsername.Text = "Submit";
            submitUsername.UseVisualStyleBackColor = true;
            submitUsername.Click += submitUsername_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 3);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 10, 0, 15);
            label10.Size = new Size(197, 42);
            label10.TabIndex = 15;
            label10.Text = "Selected Member Achievements:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(263, 52);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(263, 108);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 19;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label15.Location = new Point(346, 3);
            label15.Name = "label15";
            label15.Padding = new Padding(0, 10, 0, 15);
            label15.Size = new Size(96, 42);
            label15.TabIndex = 21;
            label15.Text = "Select Member";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(sessionPage);
            tabControl1.Location = new Point(197, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(591, 438);
            tabControl1.TabIndex = 29;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(viewAchievementButton);
            tabPage1.Controls.Add(deleteAchivementButton);
            tabPage1.Controls.Add(achievementDescriptionBox);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(achievementNameBox);
            tabPage1.Controls.Add(submitAchievement);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(achievementListBox);
            tabPage1.Controls.Add(desiredWeightLabel);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(usernameTextBox);
            tabPage1.Controls.Add(nameLabel);
            tabPage1.Controls.Add(joinDateLabel);
            tabPage1.Controls.Add(heightLabel);
            tabPage1.Controls.Add(submitUsername);
            tabPage1.Controls.Add(curWeightLabel);
            tabPage1.Controls.Add(sexLabel);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(583, 410);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Achievements";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // viewAchievementButton
            // 
            viewAchievementButton.Location = new Point(6, 208);
            viewAchievementButton.Name = "viewAchievementButton";
            viewAchievementButton.Size = new Size(150, 23);
            viewAchievementButton.TabIndex = 28;
            viewAchievementButton.Text = "View Achievement";
            viewAchievementButton.UseVisualStyleBackColor = true;
            viewAchievementButton.Click += viewAchievementButton_Click;
            // 
            // deleteAchivementButton
            // 
            deleteAchivementButton.Location = new Point(162, 206);
            deleteAchivementButton.Name = "deleteAchivementButton";
            deleteAchivementButton.Size = new Size(150, 23);
            deleteAchivementButton.TabIndex = 27;
            deleteAchivementButton.Text = "Delete Achievement";
            deleteAchivementButton.UseVisualStyleBackColor = true;
            deleteAchivementButton.Click += deleteAchivementButton_Click;
            // 
            // achievementDescriptionBox
            // 
            achievementDescriptionBox.Location = new Point(6, 277);
            achievementDescriptionBox.Multiline = true;
            achievementDescriptionBox.Name = "achievementDescriptionBox";
            achievementDescriptionBox.PlaceholderText = "Achievement description...";
            achievementDescriptionBox.Size = new Size(571, 98);
            achievementDescriptionBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(6, 234);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 15);
            label2.Size = new Size(248, 42);
            label2.TabIndex = 25;
            label2.Text = "Award Achievement to Selected Member:";
            // 
            // achievementNameBox
            // 
            achievementNameBox.Location = new Point(6, 381);
            achievementNameBox.Name = "achievementNameBox";
            achievementNameBox.PlaceholderText = "Achievement name...";
            achievementNameBox.Size = new Size(150, 23);
            achievementNameBox.TabIndex = 24;
            // 
            // submitAchievement
            // 
            submitAchievement.Location = new Point(162, 380);
            submitAchievement.Name = "submitAchievement";
            submitAchievement.Size = new Size(75, 23);
            submitAchievement.TabIndex = 23;
            submitAchievement.Text = "Award";
            submitAchievement.UseVisualStyleBackColor = true;
            submitAchievement.Click += submitAchievement_Click;
            // 
            // achievementListBox
            // 
            achievementListBox.FormattingEnabled = true;
            achievementListBox.ItemHeight = 15;
            achievementListBox.Location = new Point(6, 46);
            achievementListBox.Name = "achievementListBox";
            achievementListBox.Size = new Size(306, 154);
            achievementListBox.TabIndex = 11;
            // 
            // sessionPage
            // 
            sessionPage.Controls.Add(refreshSessions);
            sessionPage.Controls.Add(sessionListBox);
            sessionPage.Controls.Add(label14);
            sessionPage.Controls.Add(sesCapacityLabel);
            sessionPage.Controls.Add(attendingUserList);
            sessionPage.Controls.Add(label9);
            sessionPage.Controls.Add(sesLocationLabel);
            sessionPage.Controls.Add(sesDateLabel);
            sessionPage.Controls.Add(sesTypeLabel);
            sessionPage.Controls.Add(sesNameLabel);
            sessionPage.Controls.Add(sesDescriptionTxt);
            sessionPage.Location = new Point(4, 24);
            sessionPage.Name = "sessionPage";
            sessionPage.Padding = new Padding(3);
            sessionPage.Size = new Size(583, 410);
            sessionPage.TabIndex = 1;
            sessionPage.Text = "Availability";
            sessionPage.UseVisualStyleBackColor = true;
            // 
            // refreshSessions
            // 
            refreshSessions.Location = new Point(502, 205);
            refreshSessions.Name = "refreshSessions";
            refreshSessions.Size = new Size(75, 23);
            refreshSessions.TabIndex = 13;
            refreshSessions.Text = "Refresh";
            refreshSessions.UseVisualStyleBackColor = true;
            refreshSessions.Click += refreshSessions_Click;
            // 
            // sessionListBox
            // 
            sessionListBox.FormattingEnabled = true;
            sessionListBox.ItemHeight = 15;
            sessionListBox.Location = new Point(218, 205);
            sessionListBox.Name = "sessionListBox";
            sessionListBox.Size = new Size(278, 199);
            sessionListBox.TabIndex = 12;
            sessionListBox.SelectedIndexChanged += sessionListBox_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(218, 162);
            label14.Name = "label14";
            label14.Padding = new Padding(0, 10, 0, 15);
            label14.Size = new Size(134, 40);
            label14.TabIndex = 11;
            label14.Text = "Select a Session to View:";
            // 
            // sesCapacityLabel
            // 
            sesCapacityLabel.AutoSize = true;
            sesCapacityLabel.Location = new Point(6, 163);
            sesCapacityLabel.Name = "sesCapacityLabel";
            sesCapacityLabel.Padding = new Padding(0, 10, 0, 15);
            sesCapacityLabel.Size = new Size(116, 40);
            sesCapacityLabel.TabIndex = 10;
            sesCapacityLabel.Text = "Attending Members:";
            // 
            // attendingUserList
            // 
            attendingUserList.FormattingEnabled = true;
            attendingUserList.ItemHeight = 15;
            attendingUserList.Location = new Point(6, 205);
            attendingUserList.Name = "attendingUserList";
            attendingUserList.Size = new Size(206, 199);
            attendingUserList.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(218, 3);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 10, 0, 15);
            label9.Size = new Size(112, 40);
            label9.TabIndex = 7;
            label9.Text = "Session Description:";
            // 
            // sesLocationLabel
            // 
            sesLocationLabel.AutoSize = true;
            sesLocationLabel.Location = new Point(6, 123);
            sesLocationLabel.Name = "sesLocationLabel";
            sesLocationLabel.Padding = new Padding(0, 10, 0, 15);
            sesLocationLabel.Size = new Size(89, 40);
            sesLocationLabel.TabIndex = 6;
            sesLocationLabel.Text = "Room Number:";
            // 
            // sesDateLabel
            // 
            sesDateLabel.AutoSize = true;
            sesDateLabel.Location = new Point(6, 83);
            sesDateLabel.Name = "sesDateLabel";
            sesDateLabel.Padding = new Padding(0, 10, 0, 15);
            sesDateLabel.Size = new Size(76, 40);
            sesDateLabel.TabIndex = 5;
            sesDateLabel.Text = "Session Date:";
            // 
            // sesTypeLabel
            // 
            sesTypeLabel.AutoSize = true;
            sesTypeLabel.Location = new Point(6, 43);
            sesTypeLabel.Name = "sesTypeLabel";
            sesTypeLabel.Padding = new Padding(0, 10, 0, 15);
            sesTypeLabel.Size = new Size(76, 40);
            sesTypeLabel.TabIndex = 4;
            sesTypeLabel.Text = "Session Type:";
            // 
            // sesNameLabel
            // 
            sesNameLabel.AutoSize = true;
            sesNameLabel.Location = new Point(6, 3);
            sesNameLabel.Name = "sesNameLabel";
            sesNameLabel.Padding = new Padding(0, 10, 0, 15);
            sesNameLabel.Size = new Size(84, 40);
            sesNameLabel.TabIndex = 3;
            sesNameLabel.Text = "Session Name:";
            // 
            // sesDescriptionTxt
            // 
            sesDescriptionTxt.Location = new Point(218, 43);
            sesDescriptionTxt.Multiline = true;
            sesDescriptionTxt.Name = "sesDescriptionTxt";
            sesDescriptionTxt.ReadOnly = true;
            sesDescriptionTxt.Size = new Size(359, 107);
            sesDescriptionTxt.TabIndex = 2;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(16, 24);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Padding = new Padding(0, 0, 0, 15);
            usernameLabel.Size = new Size(77, 30);
            usernameLabel.TabIndex = 25;
            usernameLabel.Text = "Logged in as:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // trainerNameLabel
            // 
            trainerNameLabel.AutoSize = true;
            trainerNameLabel.Location = new Point(16, 54);
            trainerNameLabel.Name = "trainerNameLabel";
            trainerNameLabel.Padding = new Padding(0, 0, 0, 15);
            trainerNameLabel.Size = new Size(42, 30);
            trainerNameLabel.TabIndex = 31;
            trainerNameLabel.Text = "Name:";
            // 
            // logout
            // 
            logout.Location = new Point(18, 415);
            logout.Name = "logout";
            logout.Size = new Size(75, 23);
            logout.TabIndex = 26;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 130);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 32;
            // 
            // availabilityListBox
            // 
            availabilityListBox.FormattingEnabled = true;
            availabilityListBox.ItemHeight = 15;
            availabilityListBox.Location = new Point(16, 180);
            availabilityListBox.Name = "availabilityListBox";
            availabilityListBox.Size = new Size(156, 229);
            availabilityListBox.TabIndex = 0;
            // 
            // addTimeButton
            // 
            addTimeButton.Location = new Point(16, 151);
            addTimeButton.Name = "addTimeButton";
            addTimeButton.Size = new Size(75, 23);
            addTimeButton.TabIndex = 2;
            addTimeButton.Text = "Add Time";
            addTimeButton.UseVisualStyleBackColor = true;
            addTimeButton.Click += addTimeButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(16, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(156, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // deleteTimeButton
            // 
            deleteTimeButton.Location = new Point(97, 151);
            deleteTimeButton.Name = "deleteTimeButton";
            deleteTimeButton.Size = new Size(75, 23);
            deleteTimeButton.TabIndex = 4;
            deleteTimeButton.Text = "Del. Time";
            deleteTimeButton.UseVisualStyleBackColor = true;
            deleteTimeButton.Click += deleteTimeButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 84);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 15);
            label3.Size = new Size(91, 32);
            label3.TabIndex = 29;
            label3.Text = "Set Availability";
            // 
            // TrainerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(logout);
            Controls.Add(deleteTimeButton);
            Controls.Add(addTimeButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(trainerNameLabel);
            Controls.Add(availabilityListBox);
            Controls.Add(tabControl1);
            Controls.Add(usernameLabel);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label4);
            Name = "TrainerForm";
            Text = "TrainerForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            sessionPage.ResumeLayout(false);
            sessionPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private Label nameLabel;
        private Label label4;
        private Label curWeightLabel;
        private Label sexLabel;
        private Label desiredWeightLabel;
        private Label joinDateLabel;
        private Label heightLabel;
        private Button submitUsername;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label15;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage sessionPage;
        private Label usernameLabel;
        private Label label2;
        private TextBox achievementNameBox;
        private Button submitAchievement;
        private OpenFileDialog openFileDialog1;
        private Label trainerNameLabel;
        private Button logout;
        private TextBox achievementDescriptionBox;
        private Button viewAchievementButton;
        private Button deleteAchivementButton;
        private ListBox achievementListBox;
        private Label label1;
        private Button deleteTimeButton;
        private DateTimePicker dateTimePicker1;
        private Button addTimeButton;
        private ListBox availabilityListBox;
        private Label label3;
        private TextBox sesDescriptionTxt;
        private Label sesLocationLabel;
        private Label sesDateLabel;
        private Label sesTypeLabel;
        private Label sesNameLabel;
        private Label label9;
        private Label sesCapacityLabel;
        private ListBox attendingUserList;
        private ListBox sessionListBox;
        private Label label14;
        private Button refreshSessions;
    }
}