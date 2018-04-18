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
    public partial class AltaAutomovil : UserControl
    {
        private Vehiculos registro;

        public AltaAutomovil(Vehiculos reg)
        {
            InitializeComponent();
            registro = reg;
            cbxTipo.DataSource = CargarComboDeTipos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {
                AgregarVehiculo();
                LimpiarCampos();
            } else
            {
                MessageBox.Show(Properties.Resources.ResourceManager.GetString("ErrorInvalidForm"));
            }
         
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrWhiteSpace(txbMarca.Text) && !string.IsNullOrWhiteSpace(txbModelo.Text);
        }

        private void AgregarVehiculo()
        {
            Vehiculo vehiculo;
            if (cbxTipo.SelectedValue.Equals(TipoVehiculo.Moto.ToString()))
            {
                vehiculo = new Moto(txbMarca.Text, txbModelo.Text, (int)nudAño.Value, dtpIngreso.Value, (double)nudKilometros.Value);
            }
            else
            {
                vehiculo = new Automovil(txbMarca.Text, txbModelo.Text, (int)nudAño.Value, dtpIngreso.Value, (double)nudKilometros.Value);
            }
            registro.AgregarVehiculo(vehiculo);

        }

        private void LimpiarCampos()
        {
            txbMarca.Text = "";
            txbModelo.Text = "";
            nudAño.Value = 2017;
            nudKilometros.Value = 0;
            dtpIngreso.Value = DateTime.Today;
        }

        private List<String> CargarComboDeTipos()
        {
            return Enum.GetValues(typeof(TipoVehiculo)).Cast<TipoVehiculo>().Select(v => v.ToString()).ToList();
        }
    }
}
