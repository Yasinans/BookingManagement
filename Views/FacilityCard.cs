using System;
using System.Drawing;
using System.Windows.Forms;
using BookingManagement.Util;

namespace BookingManagement
{
    public partial class FacilityCard : UserControl
    {
        private bool isBooking;
        //to be edited for db integration
        public FacilityCard(string facilityName, string description, Image image, bool isBooking)
        {
            this.isBooking = isBooking;
            InitializeComponent();
            BookLabel.Text = facilityName;
            BookDescription.Text = description;
            CardButton.Text = isBooking ? "Book Now " : "View Schedule";
            BookFacilityImage.Image = ImageUtil.RoundCorner(image,30);
            BookFacilityImage.HoverState.Image = ImageUtil.HoverImage(image);
            this.CardButton.Click += OnButtonClick;

        }
        private void OnButtonClick(Object obj, EventArgs e)
        {
            BookingManagement.Form.CurrentFacility = (int)this.Tag;
            if (isBooking) BookingManagement.Form.ShowPage(2);
            else BookingManagement.Form.ShowPage(7);
    
        }
    }
}
