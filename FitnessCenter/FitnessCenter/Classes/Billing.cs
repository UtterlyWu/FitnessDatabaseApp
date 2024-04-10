using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Classes
{
    public class Billing
    {
        public float amount;
        public int card_number;
        public int bill_id;
        public int member_id;

        public Billing(float Amount, int Card_number, int Bill_id, int Member_id)
        {
            amount = Amount;
            card_number = Card_number;
            bill_id = Bill_id;
            member_id = Member_id;
        }
    }
}
