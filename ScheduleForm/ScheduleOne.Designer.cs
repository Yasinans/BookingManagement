using BookingManagement;

namespace BookingManagement.ScheduleForm
{
    partial class ScheduleOne
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
            this.facilityPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.facilityCard1 = new BookingManagement.FacilityCard("Test 1",false);
            this.facilityCard2 = new BookingManagement.FacilityCard("Test 2",false);
            this.facilityCard3 = new BookingManagement.FacilityCard("Test 3",false);
            this.categoryPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.spacer = new System.Windows.Forms.Panel();
            this.allCategory = new Guna.UI2.WinForms.Guna2Button();
            this.facilityLabel = new System.Windows.Forms.Label();
            this.facilityPanel.SuspendLayout();
            this.categoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // facilityPanel
            // 
            this.facilityPanel.AutoScroll = true;
            this.facilityPanel.Controls.Add(this.facilityCard1);
            this.facilityPanel.Controls.Add(this.facilityCard2);
            this.facilityPanel.Controls.Add(this.facilityCard3);
            this.facilityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facilityPanel.Location = new System.Drawing.Point(0, 120);
            this.facilityPanel.Name = "facilityPanel";
            this.facilityPanel.Padding = new System.Windows.Forms.Padding(145, 60, 0, 0);
            this.facilityPanel.Size = new System.Drawing.Size(1350, 383);
            this.facilityPanel.TabIndex = 22;
            this.facilityPanel.WrapContents = false;
            // 
            // facilityCard1
            // 
            this.facilityCard1.BackColor = System.Drawing.Color.Transparent;
            this.facilityCard1.Location = new System.Drawing.Point(145, 60);
            this.facilityCard1.Margin = new System.Windows.Forms.Padding(0);
            this.facilityCard1.Name = "facilityCard1";
            this.facilityCard1.Size = new System.Drawing.Size(714, 220);
            this.facilityCard1.TabIndex = 0;
            // 
            // facilityCard2
            // 
            this.facilityCard2.BackColor = System.Drawing.Color.Transparent;
            this.facilityCard2.Location = new System.Drawing.Point(859, 60);
            this.facilityCard2.Margin = new System.Windows.Forms.Padding(0);
            this.facilityCard2.Name = "facilityCard2";
            this.facilityCard2.Size = new System.Drawing.Size(714, 220);
            this.facilityCard2.TabIndex = 1;
            // 
            // facilityCard3
            // 
            this.facilityCard3.BackColor = System.Drawing.Color.Transparent;
            this.facilityCard3.Location = new System.Drawing.Point(1573, 60);
            this.facilityCard3.Margin = new System.Windows.Forms.Padding(0);
            this.facilityCard3.Name = "facilityCard3";
            this.facilityCard3.Size = new System.Drawing.Size(714, 220);
            this.facilityCard3.TabIndex = 2;
            // 
            // categoryPanel
            // 
            this.categoryPanel.Controls.Add(this.spacer);
            this.categoryPanel.Controls.Add(this.allCategory);
            this.categoryPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.categoryPanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.categoryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryPanel.Location = new System.Drawing.Point(0, 70);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Padding = new System.Windows.Forms.Padding(145, 0, 0, 0);
            this.categoryPanel.Size = new System.Drawing.Size(1350, 50);
            this.categoryPanel.TabIndex = 21;
            // 
            // spacer
            // 
            this.spacer.BackColor = System.Drawing.Color.Transparent;
            this.spacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.spacer.Location = new System.Drawing.Point(210, 0);
            this.spacer.Name = "spacer";
            this.spacer.Size = new System.Drawing.Size(31, 50);
            this.spacer.TabIndex = 1;
            // 
            // allCategory
            // 
            this.allCategory.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(118)))), ((int)(((byte)(236)))));
            this.allCategory.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.allCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.allCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.allCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.allCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.allCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.allCategory.FillColor = System.Drawing.Color.Transparent;
            this.allCategory.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.allCategory.ForeColor = System.Drawing.Color.Black;
            this.allCategory.Location = new System.Drawing.Point(145, 0);
            this.allCategory.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.allCategory.Name = "allCategory";
            this.allCategory.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.allCategory.Size = new System.Drawing.Size(65, 50);
            this.allCategory.TabIndex = 0;
            this.allCategory.Text = "All";
            // 
            // facilityLabel
            // 
            this.facilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.facilityLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.facilityLabel.Font = new System.Drawing.Font("Plus Jakarta Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facilityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.facilityLabel.Location = new System.Drawing.Point(0, 0);
            this.facilityLabel.Name = "facilityLabel";
            this.facilityLabel.Size = new System.Drawing.Size(1350, 70);
            this.facilityLabel.TabIndex = 20;
            this.facilityLabel.Text = "Select a Venue";
            this.facilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScheduleOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.facilityPanel);
            this.Controls.Add(this.categoryPanel);
            this.Controls.Add(this.facilityLabel);
            this.Name = "ScheduleOne";
            this.Size = new System.Drawing.Size(1350, 503);
            this.facilityPanel.ResumeLayout(false);
            this.categoryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel facilityPanel;
        private FacilityCard facilityCard1;
        private FacilityCard facilityCard2;
        private FacilityCard facilityCard3;
        private Guna.UI2.WinForms.Guna2Panel categoryPanel;
        private System.Windows.Forms.Panel spacer;
        private Guna.UI2.WinForms.Guna2Button allCategory;
        private System.Windows.Forms.Label facilityLabel;
    }
}
