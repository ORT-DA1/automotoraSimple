using LogicaAutomotora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIAutomotora
{
    public partial class MostrarVehiculo : Form
    {
        public MostrarVehiculo(Vehiculo vehiculo)
        {
            InitializeComponent();
            txbMarca.Text = vehiculo.Marca;
            txbModelo.Text = vehiculo.Modelo;
            nudAño.Value = vehiculo.Año;
            dtpIngreso.Value = vehiculo.FechaIngreso;
            nudKilometros.Value = (decimal)vehiculo.Kilometros;

        }
    }
}
