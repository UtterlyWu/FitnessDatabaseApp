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
            Billings = new TabPage();
            label1 = new Label();
            username = new Label();
            name = new Label();
            Logout = new Button();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ScheduleClasses);
            tabControl1.Controls.Add(Billings);
            tabControl1.Location = new Point(133, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(655, 412);
            tabControl1.TabIndex = 0;
            // 
            // ScheduleClasses
            // 
            ScheduleClasses.Location = new Point(4, 29);
            ScheduleClasses.Name = "ScheduleClasses";
            ScheduleClasses.Padding = new Padding(3);
            ScheduleClasses.Size = new Size(647, 379);
            ScheduleClasses.TabIndex = 0;
            ScheduleClasses.Text = "Scheduling";
            ScheduleClasses.UseVisualStyleBackColor = true;
            // 
            // Billings
            // 
            Billings.Location = new Point(4, 29);
            Billings.Name = "Billings";
            Billings.Padding = new Padding(3);
            Billings.Size = new Size(647, 379);
            Billings.TabIndex = 1;
            Billings.Text = "Manage Billings";
            Billings.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "Logged in as:";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(12, 79);
            username.Name = "username";
            username.Size = new Size(73, 20);
            username.TabIndex = 2;
            username.Text = "username";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(12, 121);
            name.Name = "name";
            name.Size = new Size(50, 20);
            name.TabIndex = 3;
            name.Text = "label3";
            // 
            // Logout
            // 
            Logout.Location = new Point(12, 165);
            Logout.Name = "Logout";
            Logout.Size = new Size(94, 29);
            Logout.TabIndex = 4;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Logout);
            Controls.Add(name);
            Controls.Add(username);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "AdminForm";
            Text = "Admin";
            tabControl1.ResumeLayout(false);
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
    }
}