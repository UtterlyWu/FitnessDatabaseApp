using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Classes
{
    internal class Routine
    {
        public int routine_id;
        public String title;
        public String description;
        public String catagory;
        public Routine(int routine_id, string title, string description, string catagory)
        {
            this.routine_id = routine_id;
            this.title = title;
            this.description = description;
            this.catagory = catagory;
        }
    }
}
