using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAutomotora
{
    public abstract class Vehiculo
    {
        public Guid Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public DateTime FechaIngreso { get; set; }
        public double Kilometros { get; set; }

        protected Vehiculo(string marca, string modelo, int año, DateTime fechaIngreso, double kilometros)
        {
            Id = Guid.NewGuid();
            Marca = marca;
            Modelo = modelo;
            FechaIngreso = fechaIngreso;
            Año = año;
            Kilometros = kilometros;
        }

        public override string ToString()
        {
            return Marca + " " + Modelo + " " + Año;
        }

    }
}
