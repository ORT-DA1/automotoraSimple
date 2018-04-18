using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAutomotora
{
    public class Vehiculos
    {
        private List<Vehiculo> vehiculos;
        public IEnumerable<Vehiculo> TodosLosVehiculos
        {
            get
            {
                return vehiculos;
            }
        }

        public Vehiculos()
        {
            vehiculos = new List<Vehiculo>();
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }

        public void EliminarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Remove(vehiculo);
        }


        public Vehiculo ObtenerVehiculoPorId(Guid idVehiculo)
        {
            return vehiculos.Find(v => v.Id.Equals(idVehiculo));
        }

    }
}
