using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAutomotora
{
    public class Moto : Vehiculo
    {

        public Moto(string marca, string modelo, int año, DateTime fechaIngreso, double kilometros)
            : base(marca, modelo, año, fechaIngreso, kilometros)
        {
        }

    }
}
