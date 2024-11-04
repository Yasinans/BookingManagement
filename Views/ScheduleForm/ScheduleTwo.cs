using BookingManagement.BookingForm;
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
    public partial class ScheduleTwo : UserControl
    {
        public List<BookingCard> Cards;
        public ScheduleTwo()
        {
            Cards = new List<BookingCard>();
            InitializeComponent();
            StartDateTimePicker.Value = DateTime.Now;
            EndDateTimePicker.Value = DateTime.Now.AddDays(1);
        }
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (StartDateTimePicker.Value > EndDateTimePicker.Value)
            {
                EndDateTimePicker.Value = StartDateTimePicker.Value;
                EndDateTimePicker.MinDate = StartDateTimePicker.Value;
            }
            FillBookingPanel();
        }

        private void FillBookingPanel()
        {
            BookingPanel.Controls.Clear();
            foreach (BookingDetailModel booking in GetBookingDetailMV(StartDateTimePicker.Value, EndDateTimePicker.Value))
            {
                BookingCard card = new BookingCard();
                card.Tag = booking.Id;
                card.ButtonClick += ProcessCardClick;
                card.PurposeLabel.Text = booking.Purpose;
                card.DateLabel.Text = booking.StartDate.ToString("MMM dd, yyyy") + " ~ " + booking.EndDate.ToString("MMM dd, yyyy")+
                    "\n"+ booking.StartDate.ToString("hh:mm tt")+" to "+ booking.EndDate.ToString("hh:mm tt")+" ("+booking.Recurrence+")";
                BookingPanel.Controls.Add(card);
            }
        }

        private void ProcessCardClick(Object obj, EventArgs args)
        {
            BookingCard bookingCard = (BookingCard)obj;
            BookingDetailModel bookingDetail = BookingManagement.BookingDetailMV.BookingDetails.First(e => e.Id == (int)bookingCard.Tag);
            RequesterLabel.Text = "Requester’s Name: " + bookingDetail.Name +
                   "\nDepartment: " + bookingDetail.Department +
                   "\nOccupation: " + bookingDetail.Occupation;
            DetailsLabel.Text = "Venue: " + BookingManagement.FacilityMV.Facilities.Find(e => e.Id == bookingDetail.VenueId).FacilityName +
            "\r\nDate of Use:" +
                "\r\n         Start: " + bookingDetail.StartDate.ToString("MMMM dd, yyyy") +
                "\r\n         End: " + bookingDetail.EndDate.ToString("MMMM dd, yyyy") +
            "\r\nTime of Use:" +
                "\r\n         Start: " + bookingDetail.StartDate.ToString("h:mm tt") +
                "\r\n         End: " + bookingDetail.EndDate.ToString("h:mm tt") +
                "\r\nRecurrence: " + bookingDetail.Recurrence +
                "\r\nPurpose: " + bookingDetail.Purpose +
                "\r\nStatus: " + bookingDetail.Status + 
                "\r\nAdditional Details: " + bookingDetail.AdditionalDetails;
        }
        public List<BookingDetailModel> GetBookingDetailMV(DateTime? startDate, DateTime? endDate) {
            List<BookingDetailModel> BookingList = new List<BookingDetailModel>();
            DateTime startTime = new DateTime(
            StartDateTimePicker.Value.Year,
            StartDateTimePicker.Value.Month,
            StartDateTimePicker.Value.Day,
            1,
            0,
            0,
            StartDateTimePicker.Value.Kind
            );
            DateTime endTime = new DateTime(
            EndDateTimePicker.Value.Year,
            EndDateTimePicker.Value.Month,
            EndDateTimePicker.Value.Day,
            23,
            0,
            EndDateTimePicker.Value.Second,
            EndDateTimePicker.Value.Kind
            );
            foreach (BookingDetailModel bookingDetailModel in BookingManagement.BookingDetailMV.BookingDetails)
            {
                if (startTime <= bookingDetailModel.StartDate && endTime >= bookingDetailModel.EndDate)
                {
                    BookingList.Add(bookingDetailModel);
                }
            }

            return BookingList;

        }
    }
}
