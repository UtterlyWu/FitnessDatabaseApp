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
            tabPage2 = new TabPage();
            usernameLabel = new Label();
            openFileDialog1 = new OpenFileDialog();
            trainerNameLabel = new Label();
            logout = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            addTimeButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(197, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(591, 438);
            tabControl1.TabIndex = 29;
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
            achievementListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(583, 410);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Availability";
            tabPage2.UseVisualStyleBackColor = true;
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 180);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(156, 229);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(423, 85);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(154, 319);
            listBox2.TabIndex = 1;
            // 
            // addTimeButton
            // 
            addTimeButton.Location = new Point(16, 151);
            addTimeButton.Name = "addTimeButton";
            addTimeButton.Size = new Size(75, 23);
            addTimeButton.TabIndex = 2;
            addTimeButton.Text = "Add Time";
            addTimeButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(16, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(156, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(97, 151);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Del. Time";
            button2.UseVisualStyleBackColor = true;
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
            Controls.Add(button2);
            Controls.Add(addTimeButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(trainerNameLabel);
            Controls.Add(listBox1);
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
            tabPage2.ResumeLayout(false);
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
        private TabPage tabPage2;
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
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Button addTimeButton;
        private ListBox listBox2;
        private ListBox listBox1;
        private Label label3;
    }
}