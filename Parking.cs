using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    public class Parking
    {
        private List<Garage> all = new List<Garage>();

        public Parking ()
        {

        }

        public void CreateGarage()
        {
            for (int i = 1; i < 21; i++)
            {
                Garage g = new Garage(i);
                all.Add(g);
            }
        }

        public Garage SearchGarage(int num)
        {
            Garage g = null;
            foreach (Garage per in all)
            {
                if (per.Number == num)
                {
                    g = per;
                }
            }
            return g;
        }

        public List<Garage> ShowAll()
        {
            return all;
        }

        public void Clean(Garage g)
        {
            foreach (Garage per in all)
            {
                if (per.Number == g.Number)
                {
                    per.State = false;
                    per.Vehicle = null;
                }
            }
        }

        public void Modify(Garage g)
        {
            foreach (Garage per in all)
            {
                if (per.Number == g.Number)
                {
                    per.State = g.State;
                    per.Vehicle = g.Vehicle;
                }
            }
        }
    }
}
