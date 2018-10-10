using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automotora.Services;
using Automotora.Contracts.Services;
using Automotora.Domain;

namespace Automotora.UI
{
    public partial class AddVehicle : UserControl
    {
        private VehiclesService service;

        public AddVehicle(VehiclesService aService)
        {
            InitializeComponent();
            service = aService;
            cbxTipo.DataSource = LoadComboBoxOfVehiclesTypes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewVehicle();
                ClearForm();
            } catch (BusinessRuleException ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void AddNewVehicle()
        {
            Vehicle vehiculo;
            if (cbxTipo.SelectedValue.Equals(VehicleType.Moto.ToString()))
            {
                vehiculo = new Moto(txbBrand.Text, txbModel.Text, (int)nudYear.Value, dtpAdded.Value, (double)nudKilometers.Value);
            }
            else
            {
                vehiculo = new Car(txbBrand.Text, txbModel.Text, (int)nudYear.Value, dtpAdded.Value, (double)nudKilometers.Value);
            }
            service.Add(vehiculo);

        }

        private void ClearForm()
        {
            txbBrand.Text = "";
            txbModel.Text = "";
            nudYear.Value = 2017;
            nudKilometers.Value = 0;
            dtpAdded.Value = DateTime.Today;
        }

        private List<String> LoadComboBoxOfVehiclesTypes()
        {
            return Enum.GetValues(typeof(VehicleType)).Cast<VehicleType>().Select(v => v.ToString()).ToList();
        }
    }
}
