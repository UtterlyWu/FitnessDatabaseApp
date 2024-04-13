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
            roomTextBox = new TextBox();
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
            label1 = new Label();
            username = new Label();
            name = new Label();
            Logout = new Button();
            machineListBox = new ListBox();
            machineRoomCombo = new ComboBox();
            machineNameText = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            statusTextBox = new TextBox();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
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
            tabControl1.Location = new Point(107, 11);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(646, 482);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // ScheduleClasses
            // 
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
            ScheduleClasses.Controls.Add(roomTextBox);
            ScheduleClasses.Controls.Add(sessionListBox);
            ScheduleClasses.Controls.Add(label9);
            ScheduleClasses.Controls.Add(sesLocationLabel);
            ScheduleClasses.Controls.Add(sesDateLabel);
            ScheduleClasses.Controls.Add(sesTypeLabel);
            ScheduleClasses.Controls.Add(sesNameLabel);
            ScheduleClasses.Controls.Add(sesDescriptionTxt);
            ScheduleClasses.Location = new Point(4, 24);
            ScheduleClasses.Margin = new Padding(3, 2, 3, 2);
            ScheduleClasses.Name = "ScheduleClasses";
            ScheduleClasses.Padding = new Padding(3, 2, 3, 2);
            ScheduleClasses.Size = new Size(638, 454);
            ScheduleClasses.TabIndex = 0;
            ScheduleClasses.Text = "Scheduling";
            ScheduleClasses.UseVisualStyleBackColor = true;
            // 
            // typeComboBox
            // 
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Items.AddRange(new object[] { "Single", "Group" });
            typeComboBox.Location = new Point(128, 53);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(100, 23);
            typeComboBox.TabIndex = 43;
            // 
            // button4
            // 
            button4.Location = new Point(128, 299);
            button4.Name = "button4";
            button4.Size = new Size(100, 23);
            button4.TabIndex = 42;
            button4.Text = "Kick User";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // deleteSessionButton
            // 
            deleteSessionButton.Location = new Point(560, 96);
            deleteSessionButton.Name = "deleteSessionButton";
            deleteSessionButton.Size = new Size(75, 23);
            deleteSessionButton.TabIndex = 41;
            deleteSessionButton.Text = "Delete";
            deleteSessionButton.UseVisualStyleBackColor = true;
            deleteSessionButton.Click += deleteSessionButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 297);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 5, 0, 5);
            label5.Size = new Size(94, 25);
            label5.TabIndex = 40;
            label5.Text = "Attending Users:";
            // 
            // attendingUsersList
            // 
            attendingUsersList.FormattingEnabled = true;
            attendingUsersList.ItemHeight = 15;
            attendingUsersList.Location = new Point(8, 325);
            attendingUsersList.Name = "attendingUsersList";
            attendingUsersList.Size = new Size(220, 124);
            attendingUsersList.TabIndex = 39;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 246);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 242);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 10, 0, 15);
            label4.Size = new Size(76, 40);
            label4.TabIndex = 37;
            label4.Text = "Session Cost:";
            // 
            // capacityTextBox
            // 
            capacityTextBox.Location = new Point(128, 206);
            capacityTextBox.Name = "capacityTextBox";
            capacityTextBox.Size = new Size(100, 23);
            capacityTextBox.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 202);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 10, 0, 15);
            label3.Size = new Size(98, 40);
            label3.TabIndex = 35;
            label3.Text = "Session Capacity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 206);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 15);
            label2.Size = new Size(89, 40);
            label2.TabIndex = 33;
            label2.Text = "Select a Session";
            // 
            // trainerTextBox
            // 
            trainerTextBox.Location = new Point(128, 168);
            trainerTextBox.Name = "trainerTextBox";
            trainerTextBox.Size = new Size(100, 23);
            trainerTextBox.TabIndex = 32;
            // 
            // trainerLabel
            // 
            trainerLabel.AutoSize = true;
            trainerLabel.Location = new Point(6, 162);
            trainerLabel.Name = "trainerLabel";
            trainerLabel.Padding = new Padding(0, 10, 0, 15);
            trainerLabel.Size = new Size(87, 40);
            trainerLabel.TabIndex = 31;
            trainerLabel.Text = "Session Trainer:";
            // 
            // button2
            // 
            button2.Location = new Point(560, 67);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 30;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(560, 38);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 29;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(128, 14);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 28;
            nameTextBox.TextChanged += textBox5_TextChanged;
            // 
            // dateTextBox
            // 
            dateTextBox.Location = new Point(128, 88);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(100, 23);
            dateTextBox.TabIndex = 26;
            dateTextBox.TextChanged += textBox3_TextChanged;
            // 
            // roomTextBox
            // 
            roomTextBox.Location = new Point(128, 128);
            roomTextBox.Name = "roomTextBox";
            roomTextBox.Size = new Size(100, 23);
            roomTextBox.TabIndex = 25;
            // 
            // sessionListBox
            // 
            sessionListBox.FormattingEnabled = true;
            sessionListBox.ItemHeight = 15;
            sessionListBox.Location = new Point(256, 249);
            sessionListBox.Name = "sessionListBox";
            sessionListBox.Size = new Size(376, 199);
            sessionListBox.TabIndex = 23;
            sessionListBox.SelectedIndexChanged += sessionListBox_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(256, 2);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 10, 0, 15);
            label9.Size = new Size(112, 40);
            label9.TabIndex = 19;
            label9.Text = "Session Description:";
            // 
            // sesLocationLabel
            // 
            sesLocationLabel.AutoSize = true;
            sesLocationLabel.Location = new Point(6, 122);
            sesLocationLabel.Name = "sesLocationLabel";
            sesLocationLabel.Padding = new Padding(0, 10, 0, 15);
            sesLocationLabel.Size = new Size(89, 40);
            sesLocationLabel.TabIndex = 18;
            sesLocationLabel.Text = "Room Number:";
            // 
            // sesDateLabel
            // 
            sesDateLabel.AutoSize = true;
            sesDateLabel.Location = new Point(6, 82);
            sesDateLabel.Name = "sesDateLabel";
            sesDateLabel.Padding = new Padding(0, 10, 0, 15);
            sesDateLabel.Size = new Size(76, 40);
            sesDateLabel.TabIndex = 17;
            sesDateLabel.Text = "Session Date:";
            // 
            // sesTypeLabel
            // 
            sesTypeLabel.AutoSize = true;
            sesTypeLabel.Location = new Point(6, 42);
            sesTypeLabel.Name = "sesTypeLabel";
            sesTypeLabel.Padding = new Padding(0, 10, 0, 15);
            sesTypeLabel.Size = new Size(76, 40);
            sesTypeLabel.TabIndex = 16;
            sesTypeLabel.Text = "Session Type:";
            // 
            // sesNameLabel
            // 
            sesNameLabel.AutoSize = true;
            sesNameLabel.Location = new Point(6, 2);
            sesNameLabel.Name = "sesNameLabel";
            sesNameLabel.Padding = new Padding(0, 10, 0, 15);
            sesNameLabel.Size = new Size(84, 40);
            sesNameLabel.TabIndex = 15;
            sesNameLabel.Text = "Session Name:";
            // 
            // sesDescriptionTxt
            // 
            sesDescriptionTxt.Location = new Point(256, 42);
            sesDescriptionTxt.Multiline = true;
            sesDescriptionTxt.Name = "sesDescriptionTxt";
            sesDescriptionTxt.Size = new Size(298, 149);
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
            Billings.Location = new Point(4, 24);
            Billings.Margin = new Padding(3, 2, 3, 2);
            Billings.Name = "Billings";
            Billings.Padding = new Padding(3, 2, 3, 2);
            Billings.Size = new Size(638, 454);
            Billings.TabIndex = 1;
            Billings.Text = "Manage Billings";
            Billings.UseVisualStyleBackColor = true;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(6, 206);
            dateLabel.Name = "dateLabel";
            dateLabel.Padding = new Padding(0, 10, 0, 15);
            dateLabel.Size = new Size(34, 40);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Date:";
            // 
            // purposeLabel
            // 
            purposeLabel.AutoSize = true;
            purposeLabel.Location = new Point(6, 166);
            purposeLabel.Name = "purposeLabel";
            purposeLabel.Padding = new Padding(0, 10, 0, 15);
            purposeLabel.Size = new Size(53, 40);
            purposeLabel.TabIndex = 5;
            purposeLabel.Text = "Purpose:";
            // 
            // cardNumberLabel
            // 
            cardNumberLabel.AutoSize = true;
            cardNumberLabel.Location = new Point(6, 126);
            cardNumberLabel.Name = "cardNumberLabel";
            cardNumberLabel.Padding = new Padding(0, 10, 0, 15);
            cardNumberLabel.Size = new Size(82, 40);
            cardNumberLabel.TabIndex = 4;
            cardNumberLabel.Text = "Card Number:";
            // 
            // memberLabel
            // 
            memberLabel.AutoSize = true;
            memberLabel.Location = new Point(5, 86);
            memberLabel.Name = "memberLabel";
            memberLabel.Padding = new Padding(0, 10, 0, 15);
            memberLabel.Size = new Size(58, 40);
            memberLabel.TabIndex = 3;
            memberLabel.Text = "Member: ";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(6, 46);
            amountLabel.Name = "amountLabel";
            amountLabel.Padding = new Padding(0, 10, 0, 15);
            amountLabel.Size = new Size(54, 40);
            amountLabel.TabIndex = 2;
            amountLabel.Text = "Amount:";
            // 
            // billingIdLabel
            // 
            billingIdLabel.AutoSize = true;
            billingIdLabel.Location = new Point(6, 6);
            billingIdLabel.Name = "billingIdLabel";
            billingIdLabel.Padding = new Padding(0, 10, 0, 15);
            billingIdLabel.Size = new Size(57, 40);
            billingIdLabel.TabIndex = 1;
            billingIdLabel.Text = "Billing ID:";
            // 
            // billingsListBox
            // 
            billingsListBox.FormattingEnabled = true;
            billingsListBox.ItemHeight = 15;
            billingsListBox.Location = new Point(6, 250);
            billingsListBox.Name = "billingsListBox";
            billingsListBox.Size = new Size(626, 199);
            billingsListBox.TabIndex = 0;
            billingsListBox.SelectedIndexChanged += billingsListBox_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(statusTextBox);
            tabPage1.Controls.Add(machineRoomCombo);
            tabPage1.Controls.Add(machineNameText);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(machineListBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(638, 454);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Manage Building";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 30);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Logged in as:";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(10, 59);
            username.Name = "username";
            username.Size = new Size(59, 15);
            username.TabIndex = 2;
            username.Text = "username";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(10, 91);
            name.Name = "name";
            name.Size = new Size(38, 15);
            name.TabIndex = 3;
            name.Text = "label3";
            // 
            // Logout
            // 
            Logout.Location = new Point(10, 124);
            Logout.Margin = new Padding(3, 2, 3, 2);
            Logout.Name = "Logout";
            Logout.Size = new Size(82, 22);
            Logout.TabIndex = 4;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            // 
            // machineListBox
            // 
            machineListBox.FormattingEnabled = true;
            machineListBox.ItemHeight = 15;
            machineListBox.Location = new Point(292, 39);
            machineListBox.Name = "machineListBox";
            machineListBox.Size = new Size(310, 379);
            machineListBox.TabIndex = 0;
            machineListBox.SelectedIndexChanged += machineListBox_SelectedIndexChanged;
            // 
            // machineRoomCombo
            // 
            machineRoomCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            machineRoomCombo.FormattingEnabled = true;
            machineRoomCombo.Items.AddRange(new object[] { "Single", "Group" });
            machineRoomCombo.Location = new Point(155, 82);
            machineRoomCombo.Name = "machineRoomCombo";
            machineRoomCombo.Size = new Size(100, 23);
            machineRoomCombo.TabIndex = 57;
            // 
            // machineNameText
            // 
            machineNameText.Location = new Point(155, 43);
            machineNameText.Name = "machineNameText";
            machineNameText.Size = new Size(100, 23);
            machineNameText.TabIndex = 50;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(33, 111);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 10, 0, 15);
            label11.Size = new Size(88, 40);
            label11.TabIndex = 46;
            label11.Text = "Machine Status";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 71);
            label12.Name = "label12";
            label12.Padding = new Padding(0, 10, 0, 15);
            label12.Size = new Size(91, 40);
            label12.TabIndex = 45;
            label12.Text = "Machine Room:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 31);
            label13.Name = "label13";
            label13.Padding = new Padding(0, 10, 0, 15);
            label13.Size = new Size(91, 40);
            label13.TabIndex = 44;
            label13.Text = "Machine Name:";
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(33, 154);
            statusTextBox.Multiline = true;
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(235, 235);
            statusTextBox.TabIndex = 58;
            // 
            // button3
            // 
            button3.Location = new Point(195, 395);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 61;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(114, 395);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 60;
            button5.Text = "Create";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(33, 395);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 59;
            button6.Text = "Save";
            button6.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 504);
            Controls.Add(Logout);
            Controls.Add(name);
            Controls.Add(username);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox roomTextBox;
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
        private Button button3;
        private Button button5;
        private Button button6;
    }
}