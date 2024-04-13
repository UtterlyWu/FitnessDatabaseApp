using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FitnessCenter.Classes
{
    public class Billing
    {
        public float amount;
        public int card_number;
        public int bill_id;
        public string purpose;
        public int member_id;
        public string date;

        public Billing(float Amount, int Card_number, int Bill_id, string Purpose, int Member_id, string Date)
        {
            amount = Amount;
            card_number = Card_number;
            bill_id = Bill_id;
            purpose = Purpose;
            member_id = Member_id;
            date = Date;
        }

        public override string ToString()
        {
            return $"{bill_id}";
        }
    }
}
