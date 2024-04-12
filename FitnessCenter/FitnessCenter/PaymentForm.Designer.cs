namespace FitnessCenter
{
    partial class PaymentForm
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
            PayButton = new Button();
            CancelButton = new Button();
            cardNum = new TextBox();
            amount = new TextBox();
            ErrorText = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Credit Card Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 1;
            label2.Text = "Amount to pay: $";
            // 
            // PayButton
            // 
            PayButton.Location = new Point(27, 113);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(94, 29);
            PayButton.TabIndex = 2;
            PayButton.Text = "Pay";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += PayButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(163, 113);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // cardNum
            // 
            cardNum.Location = new Point(163, 19);
            cardNum.Name = "cardNum";
            cardNum.Size = new Size(125, 27);
            cardNum.TabIndex = 4;
            // 
            // amount
            // 
            amount.Location = new Point(129, 50);
            amount.Name = "amount";
            amount.Size = new Size(50, 27);
            amount.TabIndex = 5;
            // 
            // ErrorText
            // 
            ErrorText.AutoSize = true;
            ErrorText.ForeColor = Color.Red;
            ErrorText.Location = new Point(27, 90);
            ErrorText.Name = "ErrorText";
            ErrorText.Size = new Size(0, 20);
            ErrorText.TabIndex = 6;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 183);
            Controls.Add(ErrorText);
            Controls.Add(amount);
            Controls.Add(cardNum);
            Controls.Add(CancelButton);
            Controls.Add(PayButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PaymentForm";
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button PayButton;
        private Button CancelButton;
        private TextBox cardNum;
        private TextBox amount;
        private Label ErrorText;
    }
}