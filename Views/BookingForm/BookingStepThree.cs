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
    public partial class BookingStepThree : UserControl
    {
        public event EventHandler proceedButtonClick;
        public BookingStepThree()
        {
            InitializeComponent();
            this.proceedButton.Click += (sender, e) => OnProceedButtonclick(e);
        }
        protected virtual void OnProceedButtonclick(EventArgs e)
        {
            proceedButtonClick?.Invoke(this, e);
        }
    }
}
