using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaAutomotora;

namespace UIAutomotora
{
    public partial class VerAutomoviles : UserControl
    {
        private Vehiculos registro;

        public VerAutomoviles(Vehiculos reg)
        {
            InitializeComponent();
            registro = reg;
            ListarVehiculos();
        }

        private void ListarVehiculos()
        {
            lstAutomoviles.DataSource = null;
            lstAutomoviles.DataSource = registro.TodosLosVehiculos;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(lstAutomoviles.SelectedIndex != -1)
            {
                Vehiculo vehiculoSeleccionado = (Vehiculo)lstAutomoviles.SelectedItem;
                registro.EliminarVehiculo(vehiculoSeleccionado);
                ListarVehiculos();
            }
        }

        private void lstAutomoviles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstAutomoviles.SelectedIndex != -1)
            {
                Vehiculo vehiculoSeleccionado = (Vehiculo)lstAutomoviles.SelectedItem;
                MostrarVehiculo ventana = new MostrarVehiculo(vehiculoSeleccionado);
                ventana.ShowDialog();
            }
        }
    }
}
