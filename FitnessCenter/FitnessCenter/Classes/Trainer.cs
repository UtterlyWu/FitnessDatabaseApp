using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Classes
{
    internal class Trainer
    {
        public String username;
        public String password;
        public int user_id;
        public String first_name;
        public String last_name;

        public Trainer(String Username, String Password, int User_id, String First_name, String Last_name)
        {
            username = Username;
            password = Password;
            user_id = User_id;
            first_name = First_name;
            last_name = Last_name;
        }
    }
}
