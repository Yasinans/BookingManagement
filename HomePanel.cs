using System;
using System.Windows.Forms;
using BookingManagement.Util;

namespace BookingManagement
{
    public partial class HomePanel : UserControl
    {

        public event EventHandler bookButtonClicked;
        public event EventHandler viewButtonClicked;
        public HomePanel()
        {
            InitializeComponent();

            this.BookFacilityButton.Click += (sender, e) => OnBookButtonClicked(e);
            this.ViewScheduleButton.Click += (sender, e) => OnViewButtonClicked(e);
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
