using System;
using System.Windows.Forms;

namespace BookingManagement.BookingForm
{
    public partial class BookingFinal : UserControl
    {

        public BookingFinal()
        {
            InitializeComponent();
        }
        
        public void BeginCountdown()
        {
            Countdown.Start();
        }
        private void Countdown_Tick(object sender, EventArgs e)
        {
            if (BookingManagement.Form.CurrentPage == 5)
            {
                BookingManagement.Form.ResetForm();
                Countdown.Stop();
            }
        }
    }
}
