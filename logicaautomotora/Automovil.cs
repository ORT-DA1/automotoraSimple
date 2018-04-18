using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAutomotora
{
    public class Automovil : Vehiculo
    {
        public Automovil(string marca, string modelo, int año,DateTime fechaIngreso,  double kilometros)
            : base(marca, modelo, año, fechaIngreso, kilometros)
        {
        }


    }
}
