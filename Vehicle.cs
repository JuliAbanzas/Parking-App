using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    public class Vehicle
    {
        private string domain;
        private string brand;
        private string model;
        private TypeVehicle typeVehicle;

        public Vehicle()
        {

        }

        public Vehicle (string domain, string brand, string model)
        {
            Domain = domain;
            Brand = brand;
            Model = model;
        }

        public string Domain
        {
            get
            { return domain; }
            set
            { domain = value; }
        }

        public string Brand
        {
            get
            { return brand; }
            set
            { brand = value; }
        }

        public string Model
        {
            get
            { return model; }
            set
            { model = value; }
        }

        public TypeVehicle TypeVehicle
        {
            get
            { return typeVehicle; }
            set
            { typeVehicle = value; }
        }
    }
}
