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
    public partial class AutomotoraMilenium : Form
    {
        private Vehiculos registro;

        public AutomotoraMilenium()
        {
            InitializeComponent();
            registro = new Vehiculos();
            CargarPanelAltaVehiculos();
        }
       
        private void agregarVehiculo_Click(object sender, EventArgs e)
        {
            CargarPanelAltaVehiculos();
        }

        private void verVehiculo_Click(object sender, EventArgs e)
        {
            CargarPanelVerVehiculos();
        }

        private void CargarPanelAltaVehiculos()
        {
            panelPrincipal.Controls.Clear();
            UserControl altaAutomovil = new AltaAutomovil(registro);
            panelPrincipal.Controls.Add(altaAutomovil);
        }

        private void CargarPanelVerVehiculos()
        {
            panelPrincipal.Controls.Clear();
            UserControl VerAutomovil = new VerAutomoviles(registro);
            panelPrincipal.Controls.Add(VerAutomovil);
        }

    }
}
