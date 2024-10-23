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
        public event EventHandler proceedButtonClick;
        public BookingStepFour()
        {
            InitializeComponent();
            this.touchKeyboard.InputUpdated += this.OnInputUpdated;
            this.proceedButton.Click += (sender, e) => OnProceedButtonclick(e);
        }
        public void OnInputUpdated(String newValue)
        {
            additionalInput.Text = newValue;
        }

        protected virtual void OnProceedButtonclick(EventArgs e)
        {
            proceedButtonClick?.Invoke(this, e);
        }
    }
}
