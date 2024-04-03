using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FitnessCenter.Classes
{
    internal class Admin : Account
    {
        public int admin_id;
        public String position;

        public Admin(String Username, String Password, int Admin_id, String First_name, String Last_name, String Position)
        : base(Username, Password, First_name, Last_name, "adminstaff")
        {
            admin_id = Admin_id;
            position = Position;
        }
    }
}
