
using Automotora.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotora.UI
{
    public partial class InspectVehicle : Form
    {
        public InspectVehicle(Vehicle vehicle)
        {
            InitializeComponent();
            txbBrand.Text = vehicle.Brand;
            txbModel.Text = vehicle.Model;
            nudYear.Value = vehicle.Year;
            dtpAdded.Value = vehicle.DateAdded;
            nudKilometers.Value = (decimal)vehicle.Kilometers;

        }
    }
}
