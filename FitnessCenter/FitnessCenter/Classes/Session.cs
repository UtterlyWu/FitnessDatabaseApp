using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace FitnessCenter.Classes
{
    internal class Session
    {
        public int session_id;
        public string name;
        public int trainer_id;
        public int room_number;
        public string type;
        public string description;
        public string date;
        public int capacity;
        public Session(int session_id, int trainer_id, int room_number, string type, string name, string description, string date, int capacity)
        {
            this.session_id = session_id;
            this.trainer_id = trainer_id;
            this.room_number = room_number;
            this.type = type;
            this.name = name;
            this.description = description;
            this.date = date;
            this.capacity = capacity;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
