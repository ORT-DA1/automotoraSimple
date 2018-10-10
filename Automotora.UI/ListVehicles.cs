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
using Automotora.Domain;

namespace Automotora.UI
{
    public partial class ListVehicles : UserControl
    {
        private VehiclesService service;

        public ListVehicles(VehiclesService aService)
        {
            InitializeComponent();
            service = aService;
            ShowList();
        }

        private void ShowList()
        {
            lstAutomoviles.DataSource = null;
            lstAutomoviles.DataSource = service.GetAll();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(lstAutomoviles.SelectedIndex != -1)
            {
                Vehicle selected = (Vehicle)lstAutomoviles.SelectedItem;
                service.Delete(selected);
                ShowList();
            }
        }

        private void lstAutomoviles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstAutomoviles.SelectedIndex != -1)
            {
                Vehicle selected = (Vehicle)lstAutomoviles.SelectedItem;
                InspectVehicle inspector = new InspectVehicle(selected);
                inspector.ShowDialog();
            }
        }
    }
}
