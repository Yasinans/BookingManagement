using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingManagement.Views.BookingForm
{
    public partial class DepartmentButton : UserControl
    {
        public bool Checked
        {
            get
            {
                return Checked;
            } 
            set {
                if (value)
                {
                    DepartmentB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
                    DepartmentB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
                    DepartmentB.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
                } else
                {
                    DepartmentB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(132)))), ((int)(((byte)(139)))));
                    DepartmentB.FillColor = System.Drawing.Color.Transparent;
                    DepartmentB.FillColor2 = System.Drawing.Color.Transparent;
                }
            }
        }
        public event EventHandler ButtonClick;
        public DepartmentButton()
        {
            InitializeComponent();
            Checked = false;
            DepartmentB.Text = "Placeholder";
            this.DepartmentB.Click += (sender, e) => OnButtonClick(e);
        }
        public DepartmentButton(string title)
        {
            InitializeComponent();
            Checked = false;
            DepartmentB.Text = title;
           this.DepartmentB.Click += (sender, e) => OnButtonClick(e);
        }

        public string DepartmentName()
        {
            return DepartmentB.Text;
        }

     


        protected virtual void OnButtonClick(EventArgs e)
        {
            ButtonClick?.Invoke(this, e);
        }
    }
}
