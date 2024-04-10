using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Classes
{
    public class Member : Account
    {
        public String joined_date;
        public String sex;
        public int member_id;
        public float current_weight;
        public float desired_weight;
        public float height;

        public Member(String Username, String Password, String First_name, String Last_name) : base(Username, Password, First_name, Last_name, "members")
        {
        }

        public Member(String Username, String Password, String First_name, String Last_name, String Joined_date, String Sex, int Member_id, float Current_weight, float Desired_weight, float Height)
        : base(Username, Password, First_name, Last_name, "members")
        {
            joined_date = Joined_date;
            sex = Sex;
            member_id = Member_id;
            current_weight = Current_weight;
            desired_weight = Desired_weight;
            height = Height;
        }

    }
}
