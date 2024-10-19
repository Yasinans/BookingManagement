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
        public BookingStepFour()
        {
            InitializeComponent();
            this.touchKeyboard.InputUpdated += this.OnInputUpdated;
        }
        public void OnInputUpdated(String newValue)
        {
            additionalInput.Text = newValue;
        }
    }
}
