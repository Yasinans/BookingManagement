using System;
using System.Windows.Forms;

namespace BookingManagement
{
    public partial class HomePanel : UserControl
    {

        public HomePanel()
        {
            InitializeComponent();

            this.BookFacilityButton.Click +=  OnBookButtonClicked;
            this.ViewScheduleButton.Click += OnViewButtonClicked;
        }

        private void OnBookButtonClicked(Object obj, EventArgs e)
        {
            BookingManagement.Form.ShowPage(1);
        }

        private void  OnViewButtonClicked(Object obj, EventArgs e)
        {
            BookingManagement.Form.ShowPage(6);
        }


    }
}
