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
    public partial class HomePanel : UserControl
    {

        public event EventHandler bookButtonClicked;
        public event EventHandler viewButtonClicked;
        public HomePanel()
        {
            InitializeComponent();

            this.bookFacilityButton.Click += (sender, e) => OnBookButtonClicked(e);
            this.viewScheduleButton.Click += (sender, e) => OnViewButtonClicked(e);
        }

        protected virtual void OnBookButtonClicked(EventArgs e)
        {
            bookButtonClicked?.Invoke(this, e);
        }

        protected virtual void OnViewButtonClicked(EventArgs e)
        {
            viewButtonClicked?.Invoke(this, e);
        }


    }
}
