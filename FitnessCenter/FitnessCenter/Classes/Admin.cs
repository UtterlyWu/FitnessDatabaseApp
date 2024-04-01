using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FitnessCenter.Classes
{
    internal class Admin
    {
        public String username;
        public String password;
        public int admin_id;
        public String first_name;
        public String last_name;
        public String position;

        public Admin(String Username, String Password, int Admin_id, String First_name, String Last_name, String Position)
        {
            username = Username;
            password = Password;
            admin_id = Admin_id;
            first_name = First_name;
            last_name = Last_name;
            position = Position;
        }
    }
}
