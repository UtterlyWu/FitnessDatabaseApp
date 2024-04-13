using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Classes
{
    internal class Room
    {
        public int room_number;
        string name;

        public Room(int room_number, string name) 
        { 
            this.room_number = room_number;
            this.name = name;
        }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
