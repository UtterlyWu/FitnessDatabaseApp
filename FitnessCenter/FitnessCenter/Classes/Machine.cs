using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FitnessCenter.Classes
{
    internal class Machine
    {
        public int machine_id;
        public string name;
        public string status;
        public int room_number;

        public Machine(int machine_id, string name, string status, int room_number) 
        {
            this.machine_id = machine_id;   
            this.name = name;
            this.status = status;
            this.room_number = room_number;
        }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
