using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    public class RentalMonthly:Rental
    {
        private string owner;
        private DateTime expirationDate;

        public RentalMonthly()
        {

        }

        public RentalMonthly (Garage garage, string owner, int months) : base (garage)
        {
            Owner = owner.ToUpper();
            ExpirationDate = Date.AddMonths(months);
        }

        public string Owner
        {
            get
            { return owner; }
            set
            { owner = value; }
        }

        public DateTime ExpirationDate
        {
            get
            { return expirationDate; }
            set
            { expirationDate = value; }
        }

        public override double CalculateAmount()
        {
            TimeSpan time = ExpirationDate.Date - DateTime.Now.Date;
            return 1500 * (time.Days / 30);
        }

        public void Add (int months)
        {
            ExpirationDate = ExpirationDate.AddMonths(months);
        }

        public bool Alert()
        {
            bool alarm = false;
            TimeSpan time = ExpirationDate.Date - DateTime.Now.Date;
            int days = time.Days;
            if (days < 5)
            { alarm = true; }
            return alarm;
        }
    }
}
