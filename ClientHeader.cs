using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingManagement
{
    public partial class ClientHeader : UserControl
    {
        public ClientHeader()
        {
            InitializeComponent();
            currentDateLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy   h:mm tt");
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            currentDateLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy   h:mm tt");
        }
    }
}
