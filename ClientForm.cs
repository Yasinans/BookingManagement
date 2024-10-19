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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            this.bookingStepOne.Hide();
            this.homePanel.Hide();
            this.homePanel.bookButtonClicked += HomePanel_BookClicked;
        }

        private void HomePanel_BookClicked(object sender, EventArgs e)
        {
            this.homePanel.Hide();
            this.bookingStepOne.Show();
        }

        private void LoadStepOne()
        {

        }
    }
}
