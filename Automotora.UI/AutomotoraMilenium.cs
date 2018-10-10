using Automotora.Services;
using System;
using System.Windows.Forms;

namespace Automotora.UI
{
    public partial class AutomotoraMilenium : Form
    {
        private VehiclesService service;

        public AutomotoraMilenium()
        {
            InitializeComponent();
            service = new VehiclesService();
            LoadAddVehiclePanel();
        }
       
        private void addVehicle_Click(object sender, EventArgs e)
        {
            LoadAddVehiclePanel();
        }

        private void listVehicles_Click(object sender, EventArgs e)
        {
            LoadListVehiclePanel();
        }

        private void LoadAddVehiclePanel()
        {
            mainPanel.Controls.Clear();
            UserControl addVehicle = new AddVehicle(service);
            mainPanel.Controls.Add(addVehicle);
        }

        private void LoadListVehiclePanel()
        {
            mainPanel.Controls.Clear();
            UserControl listVehicle = new ListVehicles(service);
            mainPanel.Controls.Add(listVehicle);
        }

    }
}
