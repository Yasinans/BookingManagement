using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookingManagement;
using BookingManagement.BookingForm;
using BookingManagement.Models;
using BookingManagement.ModelViews;
using BookingManagement.Util;

namespace BookingManagement
{
    public partial class ClientForm : Form
    {
        private List<UserControl> pages;
        public int CurrentPage { get; set; }
        public int CurrentFacility { get; set; }

        public ClientForm()
        {
            InitializeComponent();
            pages = new List<UserControl>();
            PrepareComponents();
        }

        private void PrepareComponents()
        {
            returnButton.Hide();
            InitializePages();
            ShowPage(0);
            currentDateLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy   h:mm tt");
        }

        

        private void InitializePages()
        {
            pages.AddRange(new UserControl[]
            {
            homePanel, bookingStepOne, bookingStepTwo, bookingStepThree,
            bookingStepFour, bookingFinal, scheduleOne, scheduleTwo
            });
            pages.ForEach(page => page.Hide());
        }

        public void ShowPage(int index)
        {
            if (index == 1)
            {
                bookingStepOne.LoadFacilityCards("All");
                bookingStepOne.LoadCategories();
            }
            else if (index == 6)
            {
                scheduleOne.LoadFacilityCards("All");
                scheduleOne.LoadCategories();
            }
            else if(index == 4)
            {
                bookingStepFour.RequesterLabel.Text = "Requester’s Name: " + bookingStepTwo.FullName +
                    "\nDepartment: " + bookingStepTwo.Department +
                    "\nOccupation: " + bookingStepTwo.Occupation;
                bookingStepFour.DetailsLabel.Text = "Venue: "+BookingManagement.FacilityMV.Facilities.Find(e=>e.Id==CurrentFacility).FacilityName+
                    "\r\nDate of Use:" +
                    "\r\n         Start: " + bookingStepThree.StartTime.ToString("MMMM dd, yyyy") +
                    "\r\n         End: " + bookingStepThree.EndTime.ToString("MMMM dd, yyyy") +
                    "\r\nTime of Use:" +
                    "\r\n         Start: " + bookingStepThree.StartTime.ToString("h:mm tt") +
                    "\r\n         End: " + bookingStepThree.EndTime.ToString("h:mm tt") +
                    "\r\nRecurrence: " + bookingStepThree.Recurrence +
                    "\r\nPurpose: "+ bookingStepThree.Purpose;
            }
            else if (index == 5) {
                BookingDetailModel newBooking = new Models.BookingDetailModel
                {
                    Id = 0,
                    Name = bookingStepTwo.FullName,
                    VenueId = CurrentFacility,
                    Department = bookingStepTwo.Department,
                    Occupation = bookingStepTwo.Occupation,
                    Purpose = bookingStepThree.Purpose,
                    StartDate = bookingStepThree.StartTime,
                    EndDate = bookingStepThree.EndTime,
                    Recurrence = bookingStepThree.Recurrence,
                    AdditionalDetails = bookingStepFour.AdditionalDetails

                };
                BookingManagement.BookingDetailMV.AddBookingDetail(newBooking);

                ((BookingFinal)pages[5]).BeginCountdown();
            }
            else if (index == 7)
            {
                int total_bookings = BookingManagement.BookingDetailMV.BookingDetails.FindAll(x => x.VenueId == CurrentFacility).Count();
                scheduleTwo.FacilityLabel.Text = BookingManagement.FacilityMV.Facilities.Find(e => e.Id == CurrentFacility).FacilityName;
                scheduleTwo.DescriptionLabel.Text = "Total Bookings: " + total_bookings + 
                    "\nCategory: " + BookingManagement.FacilityMV.Facilities.Find(e => e.Id == CurrentFacility).Category;
                scheduleTwo.FacilityImage.Image = ImageUtil.Base64ToImage(BookingManagement.FacilityMV.Facilities.Find(e => e.Id == CurrentFacility).Image);
            }
            returnButton.Show();
            if (index == 0)
                returnButton.Hide();
            pages[CurrentPage].Hide();
            pages[index].Show();
            CurrentPage = index;
        }

        public void ResetForm()
        {
            ShowPage(0);
            CurrentFacility = -1;
            bookingStepTwo.DepartmentButtons.Clear();
            bookingStepTwo.DepartmentLayoutPanel.Controls.Clear();
            bookingStepTwo.LoadDepartments();
            bookingStepTwo.NameInput.Text = "";
            bookingStepTwo.studentRadioButton.Checked = true;
            bookingStepThree.DailyRadioButton.Checked = true;
            bookingStepThree.StartDateTimePicker.MinDate = DateTime.Now;
            bookingStepThree.EndDateTimePicker.MinDate = DateTime.Now;
            bookingStepThree.StartMinuteComboBox.SelectedIndex = 0;
            bookingStepThree.StartHourComboBox.SelectedIndex = 0;
            bookingStepThree.DComboBox.SelectedIndex = 0;
            bookingStepThree.DurationHourComboBox.SelectedIndex = 0;
            bookingStepThree.DurationMinuteComboBox.SelectedIndex = 0;
            bookingStepThree.PurposeRadioButtons.Clear();
            bookingStepThree.PurposePanel.Controls.Clear();
            bookingStepThree.LoadPurposes();
            bookingStepFour.AdditionalInput.Text = "";


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            currentDateLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy   h:mm tt");
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            int previousPage;
            switch (CurrentPage)
            {
                case 1:
                    previousPage = 0;
                    ResetForm();
                    break;
                case 2:
                    previousPage = 1;
                    break;
                case 3:
                    previousPage = 2;
                    break;
                case 4:
                    previousPage = 3;
                    break;
                case 5:
                case 6:
                    previousPage = 0;
                    break;
                case 7:
                    previousPage = 6;
                    break;
                default:
                    previousPage = 0;
                    break;
            }
            ShowPage(previousPage);
        }
    }
}
