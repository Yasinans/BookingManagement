using BookingManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingManagement.ScheduleForm
{
    public partial class ScheduleOne : UserControl
    {
        public List<FacilityCard> facilityCards;
        public ScheduleOne()
        {
            InitializeComponent();
            facilityCards = new List<FacilityCard>();
            LoadFacilityCards();
        }

        private void LoadFacilityCards()
        {
            BookingManagement.FacilityMV.LoadFacilities();
            foreach (FacilityModel facilityModel in BookingManagement.FacilityMV.Facilities)
            {
                int total_bookings = BookingManagement.BookingDetailMV.BookingDetails.FindAll(x => x.VenueId == facilityModel.Id).Count();
                string description = "Category: " + facilityModel.Category + "\nTotal Bookings: " + total_bookings;
                facilityCards.Add(createFacilityCard(facilityModel.FacilityName, facilityModel.Id, description));

            }
        }

        private FacilityCard createFacilityCard(string facilityName, int id, string description)
        {
            FacilityCard facilityCard = new FacilityCard(facilityName, description, true);
            facilityCard.BackColor = Color.Transparent;
            facilityCard.Location = new Point(145, 60);
            facilityCard.Margin = new Padding(0);
            facilityCard.Name = facilityName;
            facilityCard.Tag = id;
            facilityCard.Size = new Size(714, 220);
            facilityCard.TabIndex = 0;
            this.facilityPanel.Controls.Add(facilityCard);
            return facilityCard;
        }
    }
}
