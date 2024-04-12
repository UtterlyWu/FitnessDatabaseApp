using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Classes
{
    public class Achievement
    {
        public int achievement_id;
        public String name;
        public String description;
        public int member_id;
        public String date;
        public int trainer_id;

        public Achievement(int Achievement_id, String Name, String Description, int Member_id, String Date, int Trainer_id)
        {
            achievement_id = Achievement_id;
            name = Name;
            description = Description;
            member_id = Member_id;
            date = Date;
            trainer_id = Trainer_id;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
