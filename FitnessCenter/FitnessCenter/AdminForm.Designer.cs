namespace FitnessCenter
{
    partial class AdminForm
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
            tabControl1 = new TabControl();
            ScheduleClasses = new TabPage();
            Rooms = new ComboBox();
            typeComboBox = new ComboBox();
            button4 = new Button();
            deleteSessionButton = new Button();
            label5 = new Label();
            attendingUsersList = new ListBox();
            textBox2 = new TextBox();
            label4 = new Label();
            capacityTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            trainerTextBox = new TextBox();
            trainerLabel = new Label();
            button2 = new Button();
            button1 = new Button();
            nameTextBox = new TextBox();
            dateTextBox = new TextBox();
            sessionListBox = new ListBox();
            label9 = new Label();
            sesLocationLabel = new Label();
            sesDateLabel = new Label();
            sesTypeLabel = new Label();
            sesNameLabel = new Label();
            sesDescriptionTxt = new TextBox();
            Billings = new TabPage();
            dateLabel = new Label();
            purposeLabel = new Label();
            cardNumberLabel = new Label();
            memberLabel = new Label();
            amountLabel = new Label();
            billingIdLabel = new Label();
            billingsListBox = new ListBox();
            tabPage1 = new TabPage();
            deleteMachineButton = new Button();
            button5 = new Button();
            button6 = new Button();
            statusTextBox = new TextBox();
            machineRoomCombo = new ComboBox();
            machineNameText = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            machineListBox = new ListBox();
            label1 = new Label();
            username = new Label();
            name = new Label();
            Logout = new Button();
            ErrorText = new Label();
            tabControl1.SuspendLayout();
            ScheduleClasses.SuspendLayout();
            Billings.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ScheduleClasses);
            tabControl1.Controls.Add(Billings);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(122, 15);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(738, 643);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // ScheduleClasses
            // 
            ScheduleClasses.Controls.Add(Rooms);
            ScheduleClasses.Controls.Add(typeComboBox);
            ScheduleClasses.Controls.Add(button4);
            ScheduleClasses.Controls.Add(deleteSessionButton);
            ScheduleClasses.Controls.Add(label5);
            ScheduleClasses.Controls.Add(attendingUsersList);
            ScheduleClasses.Controls.Add(textBox2);
            ScheduleClasses.Controls.Add(label4);
            ScheduleClasses.Controls.Add(capacityTextBox);
            ScheduleClasses.Controls.Add(label3);
            ScheduleClasses.Controls.Add(label2);
            ScheduleClasses.Controls.Add(trainerTextBox);
            ScheduleClasses.Controls.Add(trainerLabel);
            ScheduleClasses.Controls.Add(button2);
            ScheduleClasses.Controls.Add(button1);
            ScheduleClasses.Controls.Add(nameTextBox);
            ScheduleClasses.Controls.Add(dateTextBox);
            ScheduleClasses.Controls.Add(sessionListBox);
            ScheduleClasses.Controls.Add(label9);
            ScheduleClasses.Controls.Add(sesLocationLabel);
            ScheduleClasses.Controls.Add(sesDateLabel);
            ScheduleClasses.Controls.Add(sesTypeLabel);
            ScheduleClasses.Controls.Add(sesNameLabel);
            ScheduleClasses.Controls.Add(sesDescriptionTxt);
            ScheduleClasses.Location = new Point(4, 29);
            ScheduleClasses.Name = "ScheduleClasses";
            ScheduleClasses.Padding = new Padding(3, 3, 3, 3);
            ScheduleClasses.Size = new Size(730, 610);
            ScheduleClasses.TabIndex = 0;
            ScheduleClasses.Text = "Scheduling";
            ScheduleClasses.UseVisualStyleBackColor = true;
            // 
            // Rooms
            // 
            Rooms.FormattingEnabled = true;
            Rooms.Location = new Point(146, 176);
            Rooms.Name = "Rooms";
            Rooms.Size = new Size(114, 28);
            Rooms.TabIndex = 44;
            // 
            // typeComboBox
            // 
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Items.AddRange(new object[] { "Single", "Group" });
            typeComboBox.Location = new Point(146, 71);
            typeComboBox.Margin = new Padding(3, 4, 3, 4);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(114, 28);
            typeComboBox.TabIndex = 43;
            // 
            // button4
            // 
            button4.Location = new Point(146, 399);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(114, 31);
            button4.TabIndex = 42;
            button4.Text = "Kick User";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // deleteSessionButton
            // 
            deleteSessionButton.Location = new Point(640, 128);
            deleteSessionButton.Margin = new Padding(3, 4, 3, 4);
            deleteSessionButton.Name = "deleteSessionButton";
            deleteSessionButton.Size = new Size(86, 31);
            deleteSessionButton.TabIndex = 41;
            deleteSessionButton.Text = "Delete";
            deleteSessionButton.UseVisualStyleBackColor = true;
            deleteSessionButton.Click += deleteSessionButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 396);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 7, 0, 7);
            label5.Size = new Size(117, 34);
            label5.TabIndex = 40;
            label5.Text = "Attending Users:";
            // 
            // attendingUsersList
            // 
            attendingUsersList.FormattingEnabled = true;
            attendingUsersList.Location = new Point(9, 433);
            attendingUsersList.Margin = new Padding(3, 4, 3, 4);
            attendingUsersList.Name = "attendingUsersList";
            attendingUsersList.Size = new Size(251, 164);
            attendingUsersList.TabIndex = 39;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 328);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 323);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 13, 0, 20);
            label4.Size = new Size(94, 53);
            label4.TabIndex = 37;
            label4.Text = "Session Cost:";
            // 
            // capacityTextBox
            // 
            capacityTextBox.Location = new Point(146, 275);
            capacityTextBox.Margin = new Padding(3, 4, 3, 4);
            capacityTextBox.Name = "capacityTextBox";
            capacityTextBox.Size = new Size(114, 27);
            capacityTextBox.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 269);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 13, 0, 20);
            label3.Size = new Size(122, 53);
            label3.TabIndex = 35;
            label3.Text = "Session Capacity:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 275);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 13, 0, 20);
            label2.Size = new Size(114, 53);
            label2.TabIndex = 33;
            label2.Text = "Select a Session";
            // 
            // trainerTextBox
            // 
            trainerTextBox.Location = new Point(146, 224);
            trainerTextBox.Margin = new Padding(3, 4, 3, 4);
            trainerTextBox.Name = "trainerTextBox";
            trainerTextBox.Size = new Size(114, 27);
            trainerTextBox.TabIndex = 32;
            // 
            // trainerLabel
            // 
            trainerLabel.AutoSize = true;
            trainerLabel.Location = new Point(7, 216);
            trainerLabel.Name = "trainerLabel";
            trainerLabel.Padding = new Padding(0, 13, 0, 20);
            trainerLabel.Size = new Size(110, 53);
            trainerLabel.TabIndex = 31;
            trainerLabel.Text = "Session Trainer:";
            // 
            // button2
            // 
            button2.Location = new Point(640, 89);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 30;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(640, 51);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 29;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(146, 19);
            nameTextBox.Margin = new Padding(3, 4, 3, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(114, 27);
            nameTextBox.TabIndex = 28;
            nameTextBox.TextChanged += textBox5_TextChanged;
            // 
            // dateTextBox
            // 
            dateTextBox.Location = new Point(146, 117);
            dateTextBox.Margin = new Padding(3, 4, 3, 4);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(114, 27);
            dateTextBox.TabIndex = 26;
            dateTextBox.TextChanged += textBox3_TextChanged;
            // 
            // sessionListBox
            // 
            sessionListBox.FormattingEnabled = true;
            sessionListBox.Location = new Point(293, 332);
            sessionListBox.Margin = new Padding(3, 4, 3, 4);
            sessionListBox.Name = "sessionListBox";
            sessionListBox.Size = new Size(429, 264);
            sessionListBox.TabIndex = 23;
            sessionListBox.SelectedIndexChanged += sessionListBox_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(293, 3);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 13, 0, 20);
            label9.Size = new Size(141, 53);
            label9.TabIndex = 19;
            label9.Text = "Session Description:";
            // 
            // sesLocationLabel
            // 
            sesLocationLabel.AutoSize = true;
            sesLocationLabel.Location = new Point(7, 163);
            sesLocationLabel.Name = "sesLocationLabel";
            sesLocationLabel.Padding = new Padding(0, 13, 0, 20);
            sesLocationLabel.Size = new Size(110, 53);
            sesLocationLabel.TabIndex = 18;
            sesLocationLabel.Text = "Room Number:";
            // 
            // sesDateLabel
            // 
            sesDateLabel.AutoSize = true;
            sesDateLabel.Location = new Point(9, 109);
            sesDateLabel.Name = "sesDateLabel";
            sesDateLabel.Padding = new Padding(0, 13, 0, 20);
            sesDateLabel.Size = new Size(97, 53);
            sesDateLabel.TabIndex = 17;
            sesDateLabel.Text = "Session Date:";
            sesDateLabel.Click += sesDateLabel_Click;
            // 
            // sesTypeLabel
            // 
            sesTypeLabel.AutoSize = true;
            sesTypeLabel.Location = new Point(7, 56);
            sesTypeLabel.Name = "sesTypeLabel";
            sesTypeLabel.Padding = new Padding(0, 13, 0, 20);
            sesTypeLabel.Size = new Size(96, 53);
            sesTypeLabel.TabIndex = 16;
            sesTypeLabel.Text = "Session Type:";
            // 
            // sesNameLabel
            // 
            sesNameLabel.AutoSize = true;
            sesNameLabel.Location = new Point(7, 3);
            sesNameLabel.Name = "sesNameLabel";
            sesNameLabel.Padding = new Padding(0, 13, 0, 20);
            sesNameLabel.Size = new Size(105, 53);
            sesNameLabel.TabIndex = 15;
            sesNameLabel.Text = "Session Name:";
            // 
            // sesDescriptionTxt
            // 
            sesDescriptionTxt.Location = new Point(293, 56);
            sesDescriptionTxt.Margin = new Padding(3, 4, 3, 4);
            sesDescriptionTxt.Multiline = true;
            sesDescriptionTxt.Name = "sesDescriptionTxt";
            sesDescriptionTxt.Size = new Size(340, 197);
            sesDescriptionTxt.TabIndex = 14;
            sesDescriptionTxt.TextChanged += sesDescriptionTxt_TextChanged;
            // 
            // Billings
            // 
            Billings.Controls.Add(dateLabel);
            Billings.Controls.Add(purposeLabel);
            Billings.Controls.Add(cardNumberLabel);
            Billings.Controls.Add(memberLabel);
            Billings.Controls.Add(amountLabel);
            Billings.Controls.Add(billingIdLabel);
            Billings.Controls.Add(billingsListBox);
            Billings.Location = new Point(4, 29);
            Billings.Name = "Billings";
            Billings.Padding = new Padding(3, 3, 3, 3);
            Billings.Size = new Size(730, 610);
            Billings.TabIndex = 1;
            Billings.Text = "Manage Billings";
            Billings.UseVisualStyleBackColor = true;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(7, 275);
            dateLabel.Name = "dateLabel";
            dateLabel.Padding = new Padding(0, 13, 0, 20);
            dateLabel.Size = new Size(44, 53);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Date:";
            // 
            // purposeLabel
            // 
            purposeLabel.AutoSize = true;
            purposeLabel.Location = new Point(7, 221);
            purposeLabel.Name = "purposeLabel";
            purposeLabel.Padding = new Padding(0, 13, 0, 20);
            purposeLabel.Size = new Size(65, 53);
            purposeLabel.TabIndex = 5;
            purposeLabel.Text = "Purpose:";
            // 
            // cardNumberLabel
            // 
            cardNumberLabel.AutoSize = true;
            cardNumberLabel.Location = new Point(7, 168);
            cardNumberLabel.Name = "cardNumberLabel";
            cardNumberLabel.Padding = new Padding(0, 13, 0, 20);
            cardNumberLabel.Size = new Size(101, 53);
            cardNumberLabel.TabIndex = 4;
            cardNumberLabel.Text = "Card Number:";
            // 
            // memberLabel
            // 
            memberLabel.AutoSize = true;
            memberLabel.Location = new Point(6, 115);
            memberLabel.Name = "memberLabel";
            memberLabel.Padding = new Padding(0, 13, 0, 20);
            memberLabel.Size = new Size(72, 53);
            memberLabel.TabIndex = 3;
            memberLabel.Text = "Member: ";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(7, 61);
            amountLabel.Name = "amountLabel";
            amountLabel.Padding = new Padding(0, 13, 0, 20);
            amountLabel.Size = new Size(65, 53);
            amountLabel.TabIndex = 2;
            amountLabel.Text = "Amount:";
            // 
            // billingIdLabel
            // 
            billingIdLabel.AutoSize = true;
            billingIdLabel.Location = new Point(7, 8);
            billingIdLabel.Name = "billingIdLabel";
            billingIdLabel.Padding = new Padding(0, 13, 0, 20);
            billingIdLabel.Size = new Size(73, 53);
            billingIdLabel.TabIndex = 1;
            billingIdLabel.Text = "Billing ID:";
            // 
            // billingsListBox
            // 
            billingsListBox.FormattingEnabled = true;
            billingsListBox.Location = new Point(7, 333);
            billingsListBox.Margin = new Padding(3, 4, 3, 4);
            billingsListBox.Name = "billingsListBox";
            billingsListBox.Size = new Size(715, 264);
            billingsListBox.TabIndex = 0;
            billingsListBox.SelectedIndexChanged += billingsListBox_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(deleteMachineButton);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(statusTextBox);
            tabPage1.Controls.Add(machineRoomCombo);
            tabPage1.Controls.Add(machineNameText);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(machineListBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(730, 610);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Manage Building";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteMachineButton
            // 
            deleteMachineButton.Location = new Point(231, 525);
            deleteMachineButton.Name = "deleteMachineButton";
            deleteMachineButton.Size = new Size(75, 32);
            deleteMachineButton.TabIndex = 61;
            deleteMachineButton.Text = "Delete";
            deleteMachineButton.UseVisualStyleBackColor = true;
            deleteMachineButton.Click += deleteMachineButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(138, 527);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 31);
            button5.TabIndex = 60;
            button5.Text = "Create";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(38, 527);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 59;
            button6.Text = "Save";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(38, 205);
            statusTextBox.Margin = new Padding(3, 4, 3, 4);
            statusTextBox.Multiline = true;
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(268, 312);
            statusTextBox.TabIndex = 58;
            // 
            // machineRoomCombo
            // 
            machineRoomCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            machineRoomCombo.FormattingEnabled = true;
            machineRoomCombo.Location = new Point(177, 109);
            machineRoomCombo.Margin = new Padding(3, 4, 3, 4);
            machineRoomCombo.Name = "machineRoomCombo";
            machineRoomCombo.Size = new Size(114, 28);
            machineRoomCombo.TabIndex = 57;
            // 
            // machineNameText
            // 
            machineNameText.Location = new Point(177, 57);
            machineNameText.Margin = new Padding(3, 4, 3, 4);
            machineNameText.Name = "machineNameText";
            machineNameText.Size = new Size(114, 27);
            machineNameText.TabIndex = 50;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 148);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 13, 0, 20);
            label11.Size = new Size(109, 53);
            label11.TabIndex = 46;
            label11.Text = "Machine Status";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(38, 95);
            label12.Name = "label12";
            label12.Padding = new Padding(0, 13, 0, 20);
            label12.Size = new Size(112, 53);
            label12.TabIndex = 45;
            label12.Text = "Machine Room:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(38, 41);
            label13.Name = "label13";
            label13.Padding = new Padding(0, 13, 0, 20);
            label13.Size = new Size(112, 53);
            label13.TabIndex = 44;
            label13.Text = "Machine Name:";
            // 
            // machineListBox
            // 
            machineListBox.FormattingEnabled = true;
            machineListBox.Location = new Point(334, 52);
            machineListBox.Margin = new Padding(3, 4, 3, 4);
            machineListBox.Name = "machineListBox";
            machineListBox.Size = new Size(354, 504);
            machineListBox.TabIndex = 0;
            machineListBox.SelectedIndexChanged += machineListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 40);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "Logged in as:";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(11, 79);
            username.Name = "username";
            username.Size = new Size(73, 20);
            username.TabIndex = 2;
            username.Text = "username";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(11, 121);
            name.Name = "name";
            name.Size = new Size(50, 20);
            name.TabIndex = 3;
            name.Text = "label3";
            // 
            // Logout
            // 
            Logout.Location = new Point(11, 165);
            Logout.Name = "Logout";
            Logout.Size = new Size(94, 29);
            Logout.TabIndex = 4;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // ErrorText
            // 
            ErrorText.AutoSize = true;
            ErrorText.Location = new Point(14, 624);
            ErrorText.Name = "ErrorText";
            ErrorText.Size = new Size(15, 20);
            ErrorText.TabIndex = 5;
            ErrorText.Text = "/";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 672);
            Controls.Add(ErrorText);
            Controls.Add(Logout);
            Controls.Add(name);
            Controls.Add(username);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "AdminForm";
            Text = "Admin";
            tabControl1.ResumeLayout(false);
            ScheduleClasses.ResumeLayout(false);
            ScheduleClasses.PerformLayout();
            Billings.ResumeLayout(false);
            Billings.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ScheduleClasses;
        private TabPage Billings;
        private Label label1;
        private Label username;
        private Label name;
        private Button Logout;
        private TabPage tabPage1;
        private ListBox sessionListBox;
        private Label label9;
        private TextBox sesDescriptionTxt;
        private TextBox nameTextBox;
        private TextBox dateTextBox;
        private Button button2;
        private Button button1;
        private TextBox trainerTextBox;
        private Label label2;
        private TextBox capacityTextBox;
        private Label label3;
        private Label trainerLabel;
        private Label sesLocationLabel;
        private Label sesDateLabel;
        private Label sesTypeLabel;
        private Label sesNameLabel;
        private Button deleteSessionButton;
        private Label label5;
        private ListBox attendingUsersList;
        private TextBox textBox2;
        private Label label4;
        private Button button4;
        private ComboBox typeComboBox;
        private Label amountLabel;
        private Label billingIdLabel;
        private ListBox billingsListBox;
        private Label dateLabel;
        private Label purposeLabel;
        private Label cardNumberLabel;
        private Label memberLabel;
        private ComboBox machineRoomCombo;
        private TextBox machineNameText;
        private Label label11;
        private Label label12;
        private Label label13;
        private ListBox machineListBox;
        private TextBox statusTextBox;
        private Button deleteMachineButton;
        private Button button5;
        private Button button6;
        private ComboBox Rooms;
        private Label ErrorText;
    }
}