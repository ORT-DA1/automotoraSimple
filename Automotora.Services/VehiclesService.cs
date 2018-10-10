using Automotora.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotora.Services
{
    public class VehiclesService
    {
        private List<Vehicle> vehicles;

        public VehiclesService()
        {
            vehicles = new List<Vehicle>();
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return vehicles;
        }

        public Vehicle GetById(Guid id)
        {
            return vehicles.Find(v => v.Id.Equals(id));
        }

        public void Add(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void Delete(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
        }

    }
}
