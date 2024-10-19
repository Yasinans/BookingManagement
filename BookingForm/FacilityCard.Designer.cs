namespace BookingManagement.BookingForm
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
            this.bookFacilityButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bookLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookNowButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookFacilityButton
            // 
            this.bookFacilityButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bookFacilityButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookFacilityButton.HoverState.ImageSize = new System.Drawing.Size(342, 210);
            this.bookFacilityButton.Image = global::BookingManagement.Properties.Resources.PlaceholderFacility;
            this.bookFacilityButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.bookFacilityButton.ImageRotate = 0F;
            this.bookFacilityButton.ImageSize = new System.Drawing.Size(342, 210);
            this.bookFacilityButton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.bookFacilityButton.Location = new System.Drawing.Point(0, 0);
            this.bookFacilityButton.Name = "bookFacilityButton";
            this.bookFacilityButton.PressedState.ImageSize = new System.Drawing.Size(342, 210);
            this.bookFacilityButton.Size = new System.Drawing.Size(355, 220);
            this.bookFacilityButton.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bookNowButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bookLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(355, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 220);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.Font = new System.Drawing.Font("Plus Jakarta Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.bookLabel.Location = new System.Drawing.Point(13, 10);
            this.bookLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(133, 40);
            this.bookLabel.TabIndex = 2;
            this.bookLabel.Text = "Facility#1";
            this.bookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:  Booked\r\nBooked by: Test T. Test\r\nBooking Details: Test Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookNowButton
            // 
            this.bookNowButton.BackColor = System.Drawing.Color.Transparent;
            this.bookNowButton.BorderRadius = 20;
            this.bookNowButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bookNowButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bookNowButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bookNowButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bookNowButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bookNowButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.bookNowButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.bookNowButton.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.bookNowButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bookNowButton.Location = new System.Drawing.Point(13, 146);
            this.bookNowButton.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.bookNowButton.Name = "bookNowButton";
            this.bookNowButton.Size = new System.Drawing.Size(177, 42);
            this.bookNowButton.TabIndex = 4;
            this.bookNowButton.Text = "Book Now";
            // 
            // FacilityCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bookFacilityButton);
            this.Name = "FacilityCard";
            this.Size = new System.Drawing.Size(852, 220);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton bookFacilityButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton bookNowButton;
    }
}
