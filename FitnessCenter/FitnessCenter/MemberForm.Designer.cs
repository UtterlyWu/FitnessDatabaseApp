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
            Register = new TabPage();
            errorText = new Label();
            button1 = new Button();
            monthCalendar1 = new MonthCalendar();
            Sessions = new ListBox();
            tabPage2 = new TabPage();
            setRoutine = new Button();
            label7 = new Label();
            listBox1 = new ListBox();
            button2 = new Button();
            curSex = new Label();
            curDesWeight = new Label();
            curWeight = new Label();
            curHeight = new Label();
            option_other = new CheckBox();
            option_female = new CheckBox();
            option_male = new CheckBox();
            setDesWeight = new TextBox();
            setWeight = new TextBox();
            setHeight = new TextBox();
            setLS = new TextBox();
            setFN = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            username = new Label();
            name = new Label();
            tabControl1.SuspendLayout();
            Register.SuspendLayout();
            tabPage2.SuspendLayout();
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
            tabControl1.Controls.Add(Register);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(152, 14);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(571, 463);
            tabControl1.TabIndex = 35;
            // 
            // Register
            // 
            Register.Controls.Add(errorText);
            Register.Controls.Add(button1);
            Register.Controls.Add(monthCalendar1);
            Register.Controls.Add(Sessions);
            Register.Location = new Point(4, 29);
            Register.Name = "Register";
            Register.Padding = new Padding(3);
            Register.Size = new Size(563, 430);
            Register.TabIndex = 0;
            Register.Text = "Class Registration";
            Register.UseVisualStyleBackColor = true;
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
            // button1
            // 
            button1.Location = new Point(319, 323);
            button1.Name = "button1";
            button1.Size = new Size(138, 54);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(255, 16);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // Sessions
            // 
            Sessions.FormattingEnabled = true;
            Sessions.Location = new Point(20, 16);
            Sessions.Name = "Sessions";
            Sessions.Size = new Size(201, 384);
            Sessions.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(setRoutine);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(listBox1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(curSex);
            tabPage2.Controls.Add(curDesWeight);
            tabPage2.Controls.Add(curWeight);
            tabPage2.Controls.Add(curHeight);
            tabPage2.Controls.Add(option_other);
            tabPage2.Controls.Add(option_female);
            tabPage2.Controls.Add(option_male);
            tabPage2.Controls.Add(setDesWeight);
            tabPage2.Controls.Add(setWeight);
            tabPage2.Controls.Add(setHeight);
            tabPage2.Controls.Add(setLS);
            tabPage2.Controls.Add(setFN);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(563, 430);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Set My Stats";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // setRoutine
            // 
            setRoutine.Location = new Point(373, 338);
            setRoutine.Name = "setRoutine";
            setRoutine.Size = new Size(131, 48);
            setRoutine.TabIndex = 21;
            setRoutine.Text = "Set Routine";
            setRoutine.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(358, 10);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 20;
            label7.Text = "Select a new routine:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(358, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(171, 284);
            listBox1.TabIndex = 19;
            // 
            // button2
            // 
            button2.Location = new Point(181, 271);
            button2.Name = "button2";
            button2.Size = new Size(94, 71);
            button2.TabIndex = 18;
            button2.Text = "SET";
            button2.UseVisualStyleBackColor = true;
            // 
            // curSex
            // 
            curSex.AutoSize = true;
            curSex.Location = new Point(74, 352);
            curSex.Name = "curSex";
            curSex.Size = new Size(58, 20);
            curSex.TabIndex = 17;
            curSex.Text = "current:";
            // 
            // curDesWeight
            // 
            curDesWeight.AutoSize = true;
            curDesWeight.Location = new Point(201, 211);
            curDesWeight.Name = "curDesWeight";
            curDesWeight.Size = new Size(58, 20);
            curDesWeight.TabIndex = 16;
            curDesWeight.Text = "current:";
            // 
            // curWeight
            // 
            curWeight.AutoSize = true;
            curWeight.Location = new Point(164, 165);
            curWeight.Name = "curWeight";
            curWeight.Size = new Size(58, 20);
            curWeight.TabIndex = 15;
            curWeight.Text = "current:";
            // 
            // curHeight
            // 
            curHeight.AutoSize = true;
            curHeight.Location = new Point(181, 122);
            curHeight.Name = "curHeight";
            curHeight.Size = new Size(62, 20);
            curHeight.TabIndex = 14;
            curHeight.Text = "current: ";
            // 
            // option_other
            // 
            option_other.AutoSize = true;
            option_other.Location = new Point(74, 325);
            option_other.Name = "option_other";
            option_other.Size = new Size(68, 24);
            option_other.TabIndex = 13;
            option_other.Text = "Other";
            option_other.UseVisualStyleBackColor = true;
            option_other.CheckedChanged += option_other_CheckedChanged;
            // 
            // option_female
            // 
            option_female.AutoSize = true;
            option_female.ImageAlign = ContentAlignment.MiddleLeft;
            option_female.Location = new Point(74, 295);
            option_female.Name = "option_female";
            option_female.Size = new Size(79, 24);
            option_female.TabIndex = 12;
            option_female.Text = "Female";
            option_female.UseVisualStyleBackColor = true;
            option_female.CheckedChanged += option_female_CheckedChanged;
            // 
            // option_male
            // 
            option_male.AutoSize = true;
            option_male.Location = new Point(74, 265);
            option_male.Name = "option_male";
            option_male.Size = new Size(64, 24);
            option_male.TabIndex = 11;
            option_male.Text = "Male";
            option_male.UseVisualStyleBackColor = true;
            option_male.CheckedChanged += option_male_CheckedChanged;
            // 
            // setDesWeight
            // 
            setDesWeight.Location = new Point(136, 208);
            setDesWeight.Name = "setDesWeight";
            setDesWeight.Size = new Size(59, 27);
            setDesWeight.TabIndex = 10;
            // 
            // setWeight
            // 
            setWeight.Location = new Point(99, 162);
            setWeight.Name = "setWeight";
            setWeight.Size = new Size(59, 27);
            setWeight.TabIndex = 9;
            // 
            // setHeight
            // 
            setHeight.Location = new Point(128, 119);
            setHeight.Name = "setHeight";
            setHeight.Size = new Size(47, 27);
            setHeight.TabIndex = 8;
            // 
            // setLS
            // 
            setLS.Location = new Point(128, 76);
            setLS.Name = "setLS";
            setLS.Size = new Size(147, 27);
            setLS.TabIndex = 7;
            // 
            // setFN
            // 
            setFN.Location = new Point(128, 28);
            setFN.Name = "setFN";
            setFN.Size = new Size(147, 27);
            setFN.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 265);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 5;
            label6.Text = "Sex:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 211);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 4;
            label5.Text = "Desire Weight:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 162);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 3;
            label4.Text = "Weight:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 119);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "Height (cm):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 76);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 31);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First name:";
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
            Register.ResumeLayout(false);
            Register.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logout;
        private Label usernameLabel;
        private TabControl tabControl1;
        private TabPage Register;
        private TabPage tabPage2;
        private Label username;
        private Label name;
        private MonthCalendar monthCalendar1;
        private ListBox Sessions;
        private Label errorText;
        private Button button1;
        private Label label1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Label curSex;
        private Label curDesWeight;
        private Label curWeight;
        private Label curHeight;
        private CheckBox option_other;
        private CheckBox option_female;
        private CheckBox option_male;
        private TextBox setDesWeight;
        private TextBox setWeight;
        private TextBox setHeight;
        private TextBox setLS;
        private TextBox setFN;
        private ListBox listBox1;
        private Button setRoutine;
        private Label label7;
    }
}