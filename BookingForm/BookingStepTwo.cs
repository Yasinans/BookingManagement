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

namespace BookingManagement.BookingForm
{
    public partial class BookingStepTwo : UserControl
    {

        public event EventHandler proceedButtonClick;

        string Occupation;
        string Department;

        Dictionary<int, Guna2GradientButton> DepartmentButtons;
        public BookingStepTwo()
        {
            InitializeComponent();
            //test dummy departments
            DepartmentButtons = new Dictionary<int, Guna2GradientButton>();
            DepartmentButtons.Add(0, placeholderDepartment);
            DepartmentButtons.Add(1, placeholder2Department);
            foreach(int index in DepartmentButtons.Keys)
            {
                if (index == 0) continue;
                DepartmentButtons[index].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(132)))), ((int)(((byte)(139)))));
                DepartmentButtons[index].FillColor = System.Drawing.Color.Transparent;
                DepartmentButtons[index].FillColor2 = System.Drawing.Color.Transparent;
            }
            //diff
            this.touchKeyboard.InputUpdated += this.OnInputUpdated;
            this.facultyPanel.FillColor = System.Drawing.Color.Transparent;
            this.facultyPanel.FillColor2 = System.Drawing.Color.Transparent;
            this.staffPanel.FillColor = System.Drawing.Color.Transparent;
            this.staffPanel.FillColor2 = System.Drawing.Color.Transparent;
            this.proceedButton.Click += (sender, e) => OnProceedButtonclick(e);
        }

        protected virtual void OnProceedButtonclick(EventArgs e)
        {
            proceedButtonClick?.Invoke(this, e);
        }
        public void OnInputUpdated(String newValue)
        {
            nameInput.Text = newValue;
        }
        private void OnDepartmentChanged(object sender, EventArgs e)
        {
            Guna2GradientButton DepartmentButton = (Guna2GradientButton) sender;
            int id = Int32.Parse((string)DepartmentButton.Tag);
            foreach (int index in DepartmentButtons.Keys)
            {
                if (index == id)
                {
                    DepartmentButtons[index].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
                    DepartmentButtons[index].FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
                    DepartmentButtons[index].FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
                    Department = DepartmentButton.Text;
                    continue;
                }
                DepartmentButtons[index].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(132)))), ((int)(((byte)(139)))));
                DepartmentButtons[index].FillColor = System.Drawing.Color.Transparent;
                DepartmentButtons[index].FillColor2 = System.Drawing.Color.Transparent;
            }
        }
        private void OnOccupationChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string name = (string)radioButton.Tag;

            if (radioButton.Checked)
            {
                switch (name)
                {
                    case "Student":
                        this.studentPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
                        this.studentPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
                        this.facultyPanel.FillColor = System.Drawing.Color.Transparent;
                        this.facultyPanel.FillColor2 = System.Drawing.Color.Transparent;
                        this.staffPanel.FillColor = System.Drawing.Color.Transparent;
                        this.staffPanel.FillColor2 = System.Drawing.Color.Transparent;
                        this.facultyRadioButton.Checked = false;
                        this.staffRadioButton.Checked = false;
                        Occupation = "Student";
                        break;
                    case "Faculty":
                        this.facultyPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
                        this.facultyPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
                        this.studentPanel.FillColor = System.Drawing.Color.Transparent;
                        this.studentPanel.FillColor2 = System.Drawing.Color.Transparent;
                        this.staffPanel.FillColor = System.Drawing.Color.Transparent;
                        this.staffPanel.FillColor2 = System.Drawing.Color.Transparent;
                        this.studentRadioButton.Checked = false;
                        this.staffRadioButton.Checked = false;
                        Occupation = "Faculty";
                        break;
                    case "Staff":
                        this.staffPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
                        this.staffPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
                        this.studentPanel.FillColor = System.Drawing.Color.Transparent;
                        this.studentPanel.FillColor2 = System.Drawing.Color.Transparent;
                        this.facultyPanel.FillColor = System.Drawing.Color.Transparent;
                        this.facultyPanel.FillColor2 = System.Drawing.Color.Transparent;
                        this.studentRadioButton.Checked = false;
                        this.facultyRadioButton.Checked = false;
                        Occupation = "Staff";
                        break;
                }
            }
        }
    }
}
