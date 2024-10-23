using System;
using System.Windows.Forms;
using BookingManagement.Util;

namespace BookingManagement
{
    public partial class FacilityCard : UserControl
    {
        public event EventHandler buttonClick;
        public bool isBooking;
        public FacilityCard()
        {
            //id
            this.Tag = 0;
            isBooking = true;
            InitializeComponent();
            this.CardButton.Click += (sender, e) => OnButtonClick(e);
        }
        //to be edited for db integration
        public FacilityCard(string facilityName, bool isBooking)
        {
            //tag is for facility id based on db
            this.Tag = 0;
            this.isBooking = isBooking;
            InitializeComponent();
            BookLabel.Text = facilityName;
            CardButton.Text = isBooking ? "Book Now " : "View Schedule";
            this.CardButton.Click += (sender, e) => OnButtonClick(e);
        }
        protected virtual void OnButtonClick(EventArgs e)
        {
            buttonClick?.Invoke(this, e);
        }
    }
}
