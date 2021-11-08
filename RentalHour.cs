using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    public class RentalHour:Rental
    {
        private DateTime from;
        private DateTime to;

        public RentalHour()
        {

        }

        public RentalHour (Garage garage): base (garage)
        {
            From = DateTime.Now;
        }

        public DateTime From
        {
            get
            { return from; }
            set
            { from = value; }
        }

        public DateTime To
        {
            get
            { return to; }
            set
            { to = value; }
        }        

        public override double CalculateAmount()
        {
            TimeSpan time = To - From;
            double amount = 0;
            int hours = time.Hours;

            if (time.Minutes > 1)
            {
                hours++;
            }

            if (Garage.Vehicle.TypeVehicle.Code == 'M')
            {
                amount = hours * 40;
            }
            else
            {
                if (Garage.Vehicle.TypeVehicle.Code == 'C')
                {
                    amount = hours * 80;
                }
                else
                {
                    if (Garage.Vehicle.TypeVehicle.Code == 'P')
                    {
                        amount = hours * 120;
                    }
                }
            }
            return amount;
        }        
    }
}
