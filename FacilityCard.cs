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
    public partial class FacilityCard : UserControl
    {
        public event EventHandler buttonClick;
        bool isBooking;
        public FacilityCard()
        {
            //id
            this.Tag = 0;
            isBooking = true;
            InitializeComponent();
            bookNowButton.Tag = 0;
            this.bookNowButton.Click += (sender, e) => OnButtonClick(e);
        }
        //to be edited for db integration
        public FacilityCard(string facilityName, bool isBooking)
        {
            //tag is for facility id based on db
            this.Tag = 0;
            this.isBooking = isBooking;
            InitializeComponent();
            bookNowButton.Tag = 0;
            bookLabel.Text = facilityName;
            bookNowButton.Text = isBooking ? "Book Now " : "View Schedule";
        }
        protected virtual void OnButtonClick(EventArgs e)
        {
            buttonClick?.Invoke(this, e);
        }
    }
}
