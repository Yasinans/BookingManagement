using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace BookingManagement
{
    public partial class ClientForm : Form
    {

        Dictionary<int, UserControl> pages;
        int currentPage;
        int currentFacility;
        public ClientForm()
        {
            InitializeComponent();
            PrepareComponents();
            returnButton.Hide();
            this.pages = new Dictionary<int, UserControl>();
            pages.Add(0, this.homePanel);
            pages.Add(1, this.bookingStepOne);
            pages.Add(2, this.bookingStepTwo);
            pages.Add(3, this.bookingStepThree);
            pages.Add(4, this.bookingStepFour);
            pages.Add(5, this.bookingFinal);
            pages.Add(6, this.scheduleOne);
            pages.Add(7, this.scheduleTwo);
            foreach(int index in pages.Keys)
            {
                if (index == 0)
                {
                    currentPage = 0;
                    continue;
                }
                pages[index].Hide();
            }
            this.homePanel.bookButtonClicked += HomePanel_BookClicked;
            this.homePanel.viewButtonClicked += HomePanel_ViewClicked;
            this.bookingStepTwo.proceedButtonClick += BookingStepTwo_ProceedClicked;
            this.bookingStepThree.proceedButtonClick += BookingStepThree_ProceedClicked;
            this.bookingStepFour.proceedButtonClick += BookingStepFour_ProceedClicked;
            currentDateLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy   h:mm tt");
        }

        private void PrepareComponents()
        {

            foreach(int i in this.bookingStepOne.facilityCards.Keys){
                this.bookingStepOne.facilityCards[i].buttonClick += HandleBookingFacilityCards;
            }
            foreach (int i in this.scheduleOne.facilityCards.Keys)
            {
                this.scheduleOne.facilityCards[i].buttonClick += HandleBookingFacilityCards;
            }
        }
        private void HandleBookingFacilityCards(object sender, EventArgs e)
        {
            FacilityCard facilityCard = (FacilityCard)sender;
            currentFacility = (int)facilityCard.Tag;
            if(facilityCard.isBooking){
                SwitchPage(2);
            } else
            {
                SwitchPage(7);
            }
        }
        private void SwitchPage(int index)
        {
            if (index == 0)
            {
                returnButton.Hide();
            } else
            {
                returnButton.Show();
            }
            pages[currentPage].Hide();
            pages[index].Show();
            currentPage=index;
        }
        private void returnButton_Click(object sender, EventArgs e)
        {
            //clear infos after return 
            switch (currentPage)
            {
                case 1:
                    SwitchPage(0);
                    break;
                case 2:
                    SwitchPage(1);
                    break;
                case 3:
                    SwitchPage(2);
                    break;
                case 4:
                    SwitchPage(3);
                    break;
                case 5:
                    SwitchPage(0);
                    break;
                case 6:
                    SwitchPage(0);
                    break;
                case 7:
                    SwitchPage(6);
                    break;
               
            }
        }

        //event handlers todo:clean
        private void HomePanel_BookClicked(object sender, EventArgs e)
        {
            SwitchPage(1);
        }

        private void HomePanel_ViewClicked(object sender, EventArgs e)
        {
            SwitchPage(6);
        }

        private void BookingStepTwo_ProceedClicked(object sender, EventArgs e)
        {
            SwitchPage(3);
        }
        private void BookingStepThree_ProceedClicked(object sender, EventArgs e)
        {
            SwitchPage(4);
        }
        private void BookingStepFour_ProceedClicked(object sender, EventArgs e)
        {
            SwitchPage(5);
        }
        private void dateTimer_Tick(object sender, EventArgs e)
        {
            currentDateLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy   h:mm tt");
        }

       
    }
}
