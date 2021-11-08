using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    public class Garage
    {
        private int number;
        private string location;
        private bool state;
        private Vehicle vehicle;

        public Garage ()
        {

        }

        public Garage (int number)
        {
            Number = number;
            State = false;
            Vehicle = null;
            if (number <= 10)
            { Location = "Arriba"; }
            else
            { Location = "Abajo"; }
        }

        public int Number
        {
            get
            { return number; }
            set
            { number = value; }
        }

        public string Location
        {
            get
            { return location; }
            set
            { location = value; }
        }

        public bool State
        {
            get
            { return state; }
            set
            { state = value; }
        }

        public Vehicle Vehicle
        {
            get
            { return vehicle; }
            set
            { vehicle = value; }
        }
    }
}
