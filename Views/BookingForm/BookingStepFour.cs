using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingManagement.BookingForm
{
    public partial class BookingStepFour : UserControl
    {
        public string AdditionalDetails;
        public BookingStepFour()
        {
            InitializeComponent();
            this.touchKeyboard.InputUpdated += this.OnInputUpdated;
            this.proceedButton.Click += OnProceedButtonClick;
        }
        public void OnInputUpdated(String newValue)
        {
            AdditionalDetails = newValue;
            AdditionalInput.Text = AdditionalDetails;
        }

        private void OnProceedButtonClick(Object obj, EventArgs e)
        {
            BookingManagement.Form.ShowPage(5);
        }
    }
}
