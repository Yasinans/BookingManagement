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
        public Dictionary<int, FacilityCard> facilityCards;
        public ScheduleOne()
        {
            InitializeComponent();
            facilityCards = new Dictionary<int, FacilityCard>();
            facilityCards.Add(0, createFacilityCard("Test 1"));
            facilityCards.Add(1, createFacilityCard("Test 2"));
            facilityCards.Add(2, createFacilityCard("Test 3"));
        }

        private FacilityCard createFacilityCard(string facilityName)
        {
            FacilityCard facilityCard = new FacilityCard(facilityName, false);
            facilityCard.BackColor = System.Drawing.Color.Transparent;
            facilityCard.Location = new System.Drawing.Point(145, 60);
            facilityCard.Margin = new System.Windows.Forms.Padding(0);
            facilityCard.Name = facilityName;
            facilityCard.Size = new System.Drawing.Size(714, 220);
            facilityCard.TabIndex = 0;
            this.facilityPanel.Controls.Add(facilityCard);
            return facilityCard;
        }
    }
}
