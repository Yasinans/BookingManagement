using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookingManagement;

namespace BookingManagement
{
    public partial class ClientForm : Form
    {
        private List<UserControl> pages;
        private int currentPage;
        private int currentFacility;

        public ClientForm()
        {
            InitializeComponent();
            pages = new List<UserControl>();
            PrepareComponents();
        }

        private void PrepareComponents()
        {
            returnButton.Hide();
            InitializeEventHandlers();
            InitializePages();
            ShowPage(0);
            currentDateLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy   h:mm tt");
        }

        private void InitializeEventHandlers()
        {
            // Attach event handlers for facility cards in bookingStepOne and scheduleOne
            foreach (FacilityCard card in bookingStepOne.facilityCards.Concat(scheduleOne.facilityCards))
            {
                card.buttonClick += HandleBookingFacilityCards;
            }

            homePanel.BookButtonClicked += (s, e) => ShowPage(1);
            homePanel.ViewButtonClicked += (s, e) => ShowPage(6);
            bookingStepTwo.ProceedButtonClick += (s, e) => ShowPage(3);
            bookingStepThree.proceedButtonClick += (s, e) => ShowPage(4);
            bookingStepFour.proceedButtonClick += (s, e) => ShowPage(5);
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

        private void ShowPage(int index)
        {
            if (index == 0)
                returnButton.Hide();
            else
                returnButton.Show();

            pages[currentPage].Hide();
            pages[index].Show();
            currentPage = index;
        }

        private void HandleBookingFacilityCards(object sender, EventArgs e)
        {
            FacilityCard facilityCard = (FacilityCard)sender;
            currentFacility = (int)facilityCard.Tag;
            ShowPage(facilityCard.isBooking ? 2 : 7);
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            int previousPage;
            switch (currentPage)
            {
                case 1:
                    previousPage = 0;
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

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            currentDateLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy   h:mm tt");
        }
    }
}
