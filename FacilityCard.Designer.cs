using BookingManagement.Util;

namespace BookingManagement
{
    partial class FacilityCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacilityCard));
            this.BookFacilityButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.FacilityCardLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BookDescription = new System.Windows.Forms.Label();
            this.CardButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BookLabel = new System.Windows.Forms.Label();
            this.FacilityCardLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookFacilityButton
            // 
            this.BookFacilityButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BookFacilityButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.BookFacilityButton.HoverState.Image = ImageUtil.HoverImage(global::BookingManagement.Properties.Resources.PlaceholderFacility);
            this.BookFacilityButton.HoverState.ImageSize = new System.Drawing.Size(342, 210);
            this.BookFacilityButton.Image = ((System.Drawing.Image)(resources.GetObject("BookFacilityButton.Image")));
            this.BookFacilityButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.BookFacilityButton.ImageRotate = 0F;
            this.BookFacilityButton.ImageSize = new System.Drawing.Size(342, 210);
            this.BookFacilityButton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.BookFacilityButton.Location = new System.Drawing.Point(0, 0);
            this.BookFacilityButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BookFacilityButton.Name = "BookFacilityButton";
            this.BookFacilityButton.PressedState.ImageSize = new System.Drawing.Size(342, 210);
            this.BookFacilityButton.Size = new System.Drawing.Size(532, 338);
            this.BookFacilityButton.TabIndex = 4;
            // 
            // FacilityCardLayout
            // 
            this.FacilityCardLayout.AutoSize = true;
            this.FacilityCardLayout.ColumnCount = 1;
            this.FacilityCardLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FacilityCardLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FacilityCardLayout.Controls.Add(this.BookDescription, 0, 1);
            this.FacilityCardLayout.Controls.Add(this.CardButton, 0, 2);
            this.FacilityCardLayout.Controls.Add(this.BookLabel, 0, 0);
            this.FacilityCardLayout.Location = new System.Drawing.Point(532, 0);
            this.FacilityCardLayout.Margin = new System.Windows.Forms.Padding(0);
            this.FacilityCardLayout.Name = "FacilityCardLayout";
            this.FacilityCardLayout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.FacilityCardLayout.RowCount = 3;
            this.FacilityCardLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FacilityCardLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FacilityCardLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FacilityCardLayout.Size = new System.Drawing.Size(746, 338);
            this.FacilityCardLayout.TabIndex = 5;
            // 
            // BookDescription
            // 
            this.BookDescription.AutoSize = true;
            this.BookDescription.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BookDescription.Location = new System.Drawing.Point(19, 55);
            this.BookDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookDescription.Name = "BookDescription";
            this.BookDescription.Size = new System.Drawing.Size(264, 81);
            this.BookDescription.TabIndex = 3;
            this.BookDescription.Text = "Current Status:  Booked\r\nBooked by: Test T. Test\r\nBooking Details: Test Descripti" +
    "on";
            this.BookDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CardButton
            // 
            this.CardButton.Animated = true;
            this.CardButton.BackColor = System.Drawing.Color.Transparent;
            this.CardButton.BorderRadius = 20;
            this.CardButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CardButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CardButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CardButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CardButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CardButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.CardButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.CardButton.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 12F, System.Drawing.FontStyle.Bold);
            this.CardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.CardButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.CardButton.IndicateFocus = true;
            this.CardButton.Location = new System.Drawing.Point(19, 159);
            this.CardButton.Margin = new System.Windows.Forms.Padding(4, 23, 4, 5);
            this.CardButton.Name = "CardButton";
            this.CardButton.Size = new System.Drawing.Size(288, 65);
            this.CardButton.TabIndex = 4;
            this.CardButton.Text = "Book Now";
            // 
            // BookLabel
            // 
            this.BookLabel.AutoSize = true;
            this.BookLabel.Font = new System.Drawing.Font("Plus Jakarta Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BookLabel.Location = new System.Drawing.Point(19, 15);
            this.BookLabel.Margin = new System.Windows.Forms.Padding(4, 15, 4, 0);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Size = new System.Drawing.Size(133, 40);
            this.BookLabel.TabIndex = 2;
            this.BookLabel.Text = "Facility#1";
            this.BookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FacilityCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.FacilityCardLayout);
            this.Controls.Add(this.BookFacilityButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FacilityCard";
            this.Size = new System.Drawing.Size(1278, 338);
            this.FacilityCardLayout.ResumeLayout(false);
            this.FacilityCardLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton BookFacilityButton;
        private System.Windows.Forms.TableLayoutPanel FacilityCardLayout;
        private System.Windows.Forms.Label BookLabel;
        private System.Windows.Forms.Label BookDescription;
        private Guna.UI2.WinForms.Guna2GradientButton CardButton;
    }
}
