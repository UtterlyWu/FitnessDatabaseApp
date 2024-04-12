using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FitnessCenter
{
    public partial class PaymentForm : Form
    {
        public bool PaymentCompleted { get; private set; }
        int member_id;
        DBConnection conn;
        string purpose;
        public PaymentForm(int member_id, string purpose)
        {
            InitializeComponent();
            this.member_id = member_id;
            this.purpose = purpose;
            conn = new DBConnection();
        }

        public async void PayButton_Click(object sender, EventArgs e)
        {
            int cardNumber;
            bool isNumeric1 = int.TryParse(cardNum.Text, out cardNumber);
            float amountToPay;
            bool isNumeric2 = float.TryParse(amount.Text, out amountToPay);

            if(isNumeric1 && isNumeric2 && cardNum.Text !="" && amount.Text!="")
            {
                await conn.makePayment(member_id, amountToPay, cardNumber, purpose);
            }
            else
            {
                ErrorText.Text = "Invalid Card Number or Payment Amount";
                return;
            }
            PaymentCompleted = true;
            this.Close();
        }

        public void CancelButton_Click(object sender, EventArgs e)
        {
            PaymentCompleted = false;
            this.Close();
        }

      

    }
}
