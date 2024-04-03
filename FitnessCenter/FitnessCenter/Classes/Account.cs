using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Classes
{
    internal class Account
    {
        public String username;
        public String password;
        public String first_name;
        public String last_name;
        public String account_type; //Can be either 'members' 'adminstaff' or 'trainers'

        public Account(String Username, String Password, String First_name, String Last_name, String Account_type)
        {
            username = Username;
            password = Password; 
            first_name = First_name;
            last_name = Last_name; 
            account_type = Account_type;
        }
    }
}
