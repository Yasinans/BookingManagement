using BookingManagement.Models;
using BookingManagement.Views.BookingForm;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace BookingManagement.BookingForm
{
    public partial class BookingStepThree : UserControl
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Recurrence { get; set; }
        public string Purpose { get; set; }
        //missing feature, check if booked
        public List<Guna2TileButton> PurposeRadioButtons;

        public BookingStepThree()
        {
            InitializeComponent();
            PurposeRadioButtons = new List<Guna2TileButton>();
            LoadPurposes();
            Recurrence = "Daily";
            Purpose = PurposeRadioButtons[0].Text;
            StartDateTimePicker.MinDate = DateTime.Now;
            EndDateTimePicker.MinDate = DateTime.Now;
            this.proceedButton.Click += OnProceedButtonClick;
            
        }

        public void LoadPurposes()
        {
            foreach (OptionModel purpose in BookingManagement.OptionMV.Purposes)
            {
                Guna2TileButton purposeRadio = new Guna2TileButton();
                purposeRadio.BackColor = Color.Transparent;
                purposeRadio.BorderColor =  Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
                purposeRadio.BorderRadius = 5;
                purposeRadio.BorderThickness = 2;
                purposeRadio.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                purposeRadio.DefaultAutoSize = true;
                purposeRadio.DisabledState.BorderColor = Color.DarkGray;
                purposeRadio.DisabledState.CustomBorderColor = Color.DarkGray;
                purposeRadio.DisabledState.FillColor = Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                purposeRadio.DisabledState.ForeColor = Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                purposeRadio.FillColor = Color.Transparent;
                purposeRadio.Font = new Font("Plus Jakarta Sans", 9F);
                purposeRadio.ForeColor = Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
                purposeRadio.Margin = new Padding(3, 3, 3, 3);
                purposeRadio.Padding = new Padding(3, 5, 3, 5);
                purposeRadio.TabIndex = 7;
                purposeRadio.Text = purpose.Value;
                purposeRadio.Click += HandlePurposeClick;
                this.PurposePanel.Controls.Add(purposeRadio);
                PurposeRadioButtons.Add(purposeRadio);
            }
            PurposeRadioButtons[0].Checked = true;
        }
        private void HandlePurposeClick(object obj, EventArgs e)
        {
            Guna2TileButton button = (Guna2TileButton)obj;
            Purpose = button.Text;
        }
        private void OnProceedButtonClick(Object obj, EventArgs e)
        {
            BookingManagement.Form.ShowPage(4);
        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            StartTime = StartDateTimePicker.Value;
            EndDateTimePicker.MinDate = StartTime;
            if (EndTime < StartTime)
            {
                EndDateTimePicker.Value = StartTime;
            }

            UpdateDate();
        }

        private void EndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            EndTime = EndDateTimePicker.Value;
        }

        private void TimeOfUse_Changed(object sender, EventArgs e)
        {
            UpdateDate();
        }

        private void UpdateDate()
        {
            int startHour = Int32.Parse((string)StartHourComboBox.SelectedItem);
            int startMinute = Int32.Parse((string)StartMinuteComboBox.SelectedItem);
            int endHour = startHour + Int32.Parse((string)DurationHourComboBox.SelectedItem);
            int endMinute = Int32.Parse((string)DurationMinuteComboBox.SelectedItem);
            StartTime = new DateTime(
                StartDateTimePicker.Value.Year,
                StartDateTimePicker.Value.Month,
                StartDateTimePicker.Value.Day,
                startHour,
                startMinute,
                StartDateTimePicker.Value.Second,
                StartDateTimePicker.Value.Kind
            );
            EndTime = new DateTime(
                EndDateTimePicker.Value.Year,
                EndDateTimePicker.Value.Month,
                EndDateTimePicker.Value.Day,
                endHour,
                endMinute,
                EndDateTimePicker.Value.Second,
                EndDateTimePicker.Value.Kind
            );
        }
        private void DailyRadioButton_Click(object sender, EventArgs e)
        {
            Recurrence = "Daily";
        }

        private void WeeklyRadioButton_Click(object sender, EventArgs e)
        {
            Recurrence = "Weekly";
        }

        private void MonthlyRadioButton_Click(object sender, EventArgs e)
        {
            Recurrence = "Monthly";
        }

        private void YearlyRadioButton_Click(object sender, EventArgs e)
        {
            Recurrence = "Yearly";
        }
    }
}
