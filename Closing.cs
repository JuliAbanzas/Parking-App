using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    public class Closing
    {
        private DateTime date;
        private User user;

        public Closing()
        {

        }

        public Closing (User user)
        {
            Date = DateTime.Now;
            User = user;
        }

        public DateTime Date
        {
            get
            { return date; }
            set
            { date = value; }
        }

        public User User
        {
            get
            { return user; }
            set
            { user = value; }
        }

        public override string ToString()
        {
            return "\t" + Date.ToString() + "\t" + User.UserName;
        }
    }
}
