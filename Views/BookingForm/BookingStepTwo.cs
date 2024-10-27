using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BookingManagement.Models;
using BookingManagement.Views.BookingForm;

namespace BookingManagement.BookingForm
{
    public partial class BookingStepTwo : UserControl
    {

        public event EventHandler ProceedButtonClick;
       
        public string Occupation { get; set; }
        public string Department { get; set; }
        public string FullName { get; set; }

        Dictionary<int, DepartmentButton> DepartmentButtons;

        public BookingStepTwo()
        {
            InitializeComponent();
            DepartmentButtons = new Dictionary<int, DepartmentButton>();
            LoadDepartments();
            this.touchKeyboard.InputUpdated += this.OnInputUpdated;
            this.facultyPanel.FillColor = Color.Transparent;
            this.facultyPanel.FillColor2 = Color.Transparent;
            this.staffPanel.FillColor = Color.Transparent;
            this.staffPanel.FillColor2 = Color.Transparent;
            this.proceedButton.Click += (sender, e) => OnProceedButtonclick(e);
        }

        private void LoadDepartments()
        {
            foreach(OptionModel department in BookingManagement.OptionMV.Departments.FindAll(x=>x.Type=="Department"))
            {
                DepartmentButton departmentButton = new DepartmentButton(department.Value);
                departmentButton.ButtonClick += HandleDepartmentClick;
                this.DepartmentLayoutPanel.Controls.Add(departmentButton);
                DepartmentButtons.Add(department.Id,departmentButton);
            }
            DepartmentButtons.First().Value.Checked = true;
        }

        private void HandleDepartmentClick(object obj, EventArgs e)
        {
            DepartmentButton button = (DepartmentButton)obj;
            foreach (DepartmentButton b in DepartmentButtons.Values)
            {
                b.Checked = false;
            }
            button.Checked = true;
            Department = button.DepartmentName();
        }
        protected virtual void OnProceedButtonclick(EventArgs e)
        {
            ProceedButtonClick?.Invoke(this, e);
        }
        public void OnInputUpdated(String newValue)
        {
            nameInput.Text = newValue;
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
