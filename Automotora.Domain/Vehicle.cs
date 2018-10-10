using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotora.Domain
{
    public abstract class Vehicle
    {
        public Guid Id { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year{ get; private set; }
        public DateTime DateAdded { get; private set; }

        public double kilometers;
        public double Kilometers
        {
            get
            {
                return kilometers;
            }
            private set
            {
                if(value >= 0)
                {
                    kilometers = value;
                } else
                {
                    throw new VehicleException();
                }
            }
        }

        protected Vehicle(string brand, string model, int year, DateTime dateAdded, double kilometers)
        {
            Id = Guid.NewGuid();
            Brand = brand;
            Model = model;
            DateAdded = dateAdded;
            Year = year;
            Kilometers = kilometers;
        }

        public override string ToString()
        {
            return Brand + " " + Model + " " + Year;
        }

    }
}
