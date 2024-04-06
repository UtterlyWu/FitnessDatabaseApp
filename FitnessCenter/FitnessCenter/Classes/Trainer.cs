using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Classes
{
    public class Trainer : Account
    {
        public int trainer_id;

        public Trainer(String Username, String Password, int Trainer_id, String First_name, String Last_name) 
        : base(Username, Password, First_name, Last_name, "trainers")
        {
            trainer_id = Trainer_id;
        }
    }
}
