using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    public class TypeVehicle
    {
        private char code;
        private string description;

        public TypeVehicle()
        {

        }


        public TypeVehicle (char code, string description)
        {
            Code = code;
            Description = description;
        }

        public char Code
        {
            get
            { return code; }
            set
            { code = value; }
        }

        public string Description
        {
            get
            { return description; }
            set
            { description = value; }
        }
    }
}
