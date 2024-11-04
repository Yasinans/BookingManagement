using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BookingManagement.Models;
using BookingManagement.Views.BookingForm;
using Guna.UI2.WinForms.Suite;

namespace BookingManagement.BookingForm
{
    public partial class BookingStepTwo : UserControl
    {       
        public string Occupation { get; set; }
        public string Department { get; set; }
        public string FullName { get; set; }

        public List<DepartmentButton> DepartmentButtons;

        public BookingStepTwo()
        {
            InitializeComponent();
            DepartmentButtons = new List<DepartmentButton>();
            LoadDepartments();
            Occupation = "Student";
            Department = DepartmentButtons.First().DepartmentName();
            proceedButton.Enabled = false;
            this.touchKeyboard.InputUpdated += this.OnInputUpdated;
            this.facultyPanel.FillColor = Color.Transparent;
            this.facultyPanel.FillColor2 = Color.Transparent;
            this.staffPanel.FillColor = Color.Transparent;
            this.staffPanel.FillColor2 = Color.Transparent;
            this.proceedButton.Click += OnProceedButtonClick;
        }

        public void LoadDepartments()
        {
            foreach(OptionModel department in BookingManagement.OptionMV.Departments)
            {
                DepartmentButton departmentButton = new DepartmentButton(department.Value);
                departmentButton.ButtonClick += HandleDepartmentClick;
                this.DepartmentLayoutPanel.Controls.Add(departmentButton);
                DepartmentButtons.Add(departmentButton);
            }
            DepartmentButtons.First().Checked = true;
        }

        private void HandleDepartmentClick(object obj, EventArgs e)
        {
            DepartmentButton button = (DepartmentButton)obj;
            foreach (DepartmentButton b in DepartmentButtons)
            {
                b.Checked = false;
            }
            button.Checked = true;
            Department = button.DepartmentName();
        }
        private void OnProceedButtonClick(Object obj, EventArgs e)
        {
            BookingManagement.Form.ShowPage(3);
        }
        public void OnInputUpdated(String newValue)
        {
            if (newValue.Equals("")) proceedButton.Enabled = false ;
            else proceedButton.Enabled = true ;
            FullName = newValue;
            NameInput.Text = FullName;
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
