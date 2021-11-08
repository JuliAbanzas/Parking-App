using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    public abstract class Rental
    {
        private DateTime date;
        private Garage garage;

        public Rental()
        {

        }

        public Rental (Garage garage)
        {
            Garage = garage;
            Date = DateTime.Today;
        }

        public DateTime Date
        {
            get
            { return date; }
            set
            { date = value; }
        }

        public Garage Garage
        {
            get
            { return garage; }
            set
            { garage = value; }
        }

        public abstract double CalculateAmount();

        public override string ToString()
        {
            return Garage.Number + "/t" + Garage.Vehicle.Domain + "/t" + Date.ToShortDateString();
        }
    }
}
