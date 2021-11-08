using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    public class Activity
    {
        private string concept;
        private double amount;
        private DateTime date;
        private bool isIngress;
        private User user;
        private Closing closing;
        private int activityId;

        public Activity ()
        {

        }

        public Activity (string concept, double amount, bool isIngress, User user)
        {
            Concept = concept;
            Amount = amount;
            Date = DateTime.Now;
            IsIngress = isIngress;
            User = user;
            closing = null;
        }

        public string Concept
        {
            get
            { return concept; }
            set
            { concept = value; }
        }

        public double Amount
        {
            get
            { return amount; }
            set
            { amount = value; }
        }

        public DateTime Date
        {
            get
            { return date; }
            set
            { date = value; }
        }

        public bool IsIngress
        {
            get
            { return isIngress; }
            set
            { isIngress = value; }
        }

        public User User
        {
            get
            { return user; }
            set
            { user = value; }
        }

        public Closing Closing
        {
            get
            { return closing; }
            set
            { closing = value; }
        }

        public int ActivityID
        {
            get
            { return activityId; }
            set
            { activityId = value; }
        }
            

        public override string ToString()
        {
            return Date.ToShortDateString() + "\t" + Concept + "\t $" + Amount + "\t" + User.UserName;
        }
    }
}
