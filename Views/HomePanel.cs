using System;
using System.Windows.Forms;

namespace BookingManagement
{
    public partial class HomePanel : UserControl
    {

        public event EventHandler BookButtonClicked;
        public event EventHandler ViewButtonClicked;
        public HomePanel()
        {
            InitializeComponent();

            this.BookFacilityButton.Click += (sender, e) => OnBookButtonClicked(e);
            this.ViewScheduleButton.Click += (sender, e) => OnViewButtonClicked(e);
        }

        protected virtual void OnBookButtonClicked(EventArgs e)
        {
            BookButtonClicked?.Invoke(this, e);
        }

        protected virtual void OnViewButtonClicked(EventArgs e)
        {
            ViewButtonClicked?.Invoke(this, e);
        }


    }
}
