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
    public partial class BookingCard : UserControl
    {
        public event EventHandler ButtonClick;
        public BookingCard()
        {
            InitializeComponent();
            Button.Click += (sender, e) => ProcessButtonClick(e);
        }

        protected virtual void ProcessButtonClick(EventArgs e)
        {
            ButtonClick?.Invoke(this, e);
        }
    }
}
