using BookingManagement.Models;
using Guna.UI2.WinForms;
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
    public partial class ScheduleOne : UserControl
    {
        public List<FacilityCard> FacilityCards;
        private List<string> Categories;
        private List<Guna2Button> CategoryButtons;
        public ScheduleOne()
        {
            InitializeComponent();
            FacilityCards = new List<FacilityCard>();
            Categories = new List<string>();
            CategoryButtons = new List<Guna2Button>();
        }

        public void LoadCategories()
        {
            CategoryPanel.Controls.Clear();
            CategoryButtons.Clear();
            //add all category
            Guna2Button allButton = GenerateCategoryButton("All");
            allButton.Checked = true;
            allButton.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(118)))), ((int)(((byte)(236)))));
            CategoryPanel.Controls.Add(allButton);
            CategoryButtons.Add(allButton);
            foreach (string category in Categories)
            {
                Guna2Button button = GenerateCategoryButton(category);
                CategoryButtons.Add(button);
                CategoryPanel.Controls.Add(button);
            }
        }

        public void LoadFacilityCards(string category)
        {
            facilityPanel.Controls.Clear();
            BookingManagement.FacilityMV.LoadFacilities();
            foreach (FacilityModel facilityModel in BookingManagement.FacilityMV.Facilities)
            {
                if (!Categories.Contains(facilityModel.Category))
                {
                    Categories.Add(facilityModel.Category);
                }
                if (category.Equals("All") || facilityModel.Category.Equals(category))
                {
                    int total_bookings = BookingManagement.BookingDetailMV.BookingDetails.FindAll(x => x.VenueId == facilityModel.Id).Count();
                    string description = "Category: " + facilityModel.Category + "\nTotal Bookings: " + total_bookings;
                    FacilityCards.Add(createFacilityCard(facilityModel.FacilityName, facilityModel.Id, Util.ImageUtil.Base64ToImage(facilityModel.Image), description));
                }


            }
        }
        private Guna2Button GenerateCategoryButton(string categoryName)
        {
            Guna2Button button = new Guna2Button
            {
                Animated = true,
                ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton,
                CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(223))))),
                CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3)
            };
            button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            button.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            button.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            button.Dock = System.Windows.Forms.DockStyle.Left;
            button.FillColor = System.Drawing.Color.Transparent;
            button.Font = new System.Drawing.Font("Plus Jakarta Sans SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            button.ForeColor = System.Drawing.Color.Black;
            button.IndicateFocus = true;
            button.Click += ProcessCategoryClick;
            button.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            button.Padding = new System.Windows.Forms.Padding(5, 5, 5, 15);
            button.Size = new System.Drawing.Size(65, 50);
            button.TabIndex = 0;
            button.AutoSize = true;
            button.Text = categoryName;
            return button;
        }

        private void ProcessCategoryClick(object sender, EventArgs e)
        {
            Guna2Button clickedButton = (Guna2Button)sender;
            foreach (Guna2Button button in CategoryButtons)
            {
                button.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            }
            clickedButton.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(118)))), ((int)(((byte)(236)))));
            LoadFacilityCards(clickedButton.Text);
        }

      
        private FacilityCard createFacilityCard(string facilityName, int id, Image image, string description)
        {
            FacilityCard facilityCard = new FacilityCard(facilityName, description, image, false);
            facilityCard.BackColor = Color.Transparent;
            facilityCard.Location = new Point(145, 60);
            facilityCard.Margin = new Padding(0);
            facilityCard.Name = facilityName;
            facilityCard.Tag = id;
            facilityCard.Size = new Size(900, 220);
            facilityCard.TabIndex = 0;
            this.facilityPanel.Controls.Add(facilityCard);
            return facilityCard;
        }
    }
}

