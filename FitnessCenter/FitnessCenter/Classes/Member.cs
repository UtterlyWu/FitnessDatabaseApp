using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Classes
{
    internal class Member
    {
        public String username;
        public String password;
        public String joined_date;
        public String sex;
        public int member_id;
        public String first_name;
        public String last_name;
        public float current_weight;
        public float desired_weight;
        public float height;

        public Member(String Username, String Password, String First_name, String Last_name, String Joined_date, String Sex, int Member_id, float Current_weight, float Desired_weight, float Height)
        {
            username = Username;
            password = Password;
            last_name = Last_name;
            first_name = First_name;
            joined_date = Joined_date;
            sex = Sex;
            member_id = Member_id;
            current_weight = Current_weight;
            desired_weight = Desired_weight;
            height = Height;
        }
    }
}
