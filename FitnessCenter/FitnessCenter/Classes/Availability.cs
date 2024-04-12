using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FitnessCenter.Classes
{
    internal class Availability
    {
        public string date;
        public int trainer_id;

        public Availability(string date, int trainer_id) 
        {
            this.date = date;
            this.trainer_id = trainer_id;
        }

        public override string ToString()
        {
            return $"{date}";
        }
    }
}
