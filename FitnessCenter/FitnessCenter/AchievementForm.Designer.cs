namespace FitnessCenter
{
    partial class AchievementForm
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
            achievementNameTxt = new TextBox();
            AchievementDescTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            close = new Button();
            Save = new Button();
            SuspendLayout();
            // 
            // achievementNameTxt
            // 
            achievementNameTxt.Location = new Point(12, 49);
            achievementNameTxt.Name = "achievementNameTxt";
            achievementNameTxt.Size = new Size(299, 23);
            achievementNameTxt.TabIndex = 1;
            // 
            // AchievementDescTxt
            // 
            AchievementDescTxt.Location = new Point(12, 115);
            AchievementDescTxt.Multiline = true;
            AchievementDescTxt.Name = "AchievementDescTxt";
            AchievementDescTxt.Size = new Size(299, 261);
            AchievementDescTxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 15, 0, 5);
            label2.Size = new Size(151, 37);
            label2.TabIndex = 3;
            label2.Text = "Achievement Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 15, 0, 5);
            label1.Size = new Size(120, 37);
            label1.TabIndex = 4;
            label1.Text = "Achievement Name";
            // 
            // close
            // 
            close.Location = new Point(12, 386);
            close.Name = "close";
            close.Size = new Size(75, 23);
            close.TabIndex = 5;
            close.Text = "Close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // Save
            // 
            Save.Location = new Point(93, 386);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 6;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // AchievementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 421);
            Controls.Add(Save);
            Controls.Add(close);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(AchievementDescTxt);
            Controls.Add(achievementNameTxt);
            Name = "AchievementForm";
            Text = "AchievementForm";
            Load += AchievementForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox achievementNameTxt;
        private TextBox AchievementDescTxt;
        private Label label2;
        private Label label1;
        private Button close;
        private Button Save;
    }
}