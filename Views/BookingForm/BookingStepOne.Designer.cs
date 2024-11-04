namespace BookingManagement.BookingForm
{
    partial class BookingStepOne
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
            this.FacilityLabel = new System.Windows.Forms.Label();
            this.facilityPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SecondPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AllCategory = new Guna.UI2.WinForms.Guna2Button();
            this.SecondPanel.SuspendLayout();
            this.CategoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacilityLabel
            // 
            this.FacilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.FacilityLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FacilityLabel.Font = new System.Drawing.Font("Plus Jakarta Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.FacilityLabel.Location = new System.Drawing.Point(0, 0);
            this.FacilityLabel.Name = "FacilityLabel";
            this.FacilityLabel.Size = new System.Drawing.Size(1350, 70);
            this.FacilityLabel.TabIndex = 17;
            this.FacilityLabel.Text = "Select a Venue";
            this.FacilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // facilityPanel
            // 
            this.facilityPanel.AutoScroll = true;
            this.facilityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facilityPanel.Location = new System.Drawing.Point(0, 120);
            this.facilityPanel.Name = "facilityPanel";
            this.facilityPanel.Padding = new System.Windows.Forms.Padding(145, 60, 0, 0);
            this.facilityPanel.Size = new System.Drawing.Size(1350, 383);
            this.facilityPanel.TabIndex = 19;
            this.facilityPanel.WrapContents = false;
            // 
            // SecondPanel
            // 
            this.SecondPanel.Controls.Add(this.CategoryPanel);
            this.SecondPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.SecondPanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.SecondPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondPanel.Location = new System.Drawing.Point(0, 70);
            this.SecondPanel.Name = "SecondPanel";
            this.SecondPanel.Size = new System.Drawing.Size(1350, 50);
            this.SecondPanel.TabIndex = 18;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.BackColor = System.Drawing.Color.Transparent;
            this.CategoryPanel.Controls.Add(this.AllCategory);
            this.CategoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryPanel.Location = new System.Drawing.Point(0, 0);
            this.CategoryPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Padding = new System.Windows.Forms.Padding(145, 0, 0, 0);
            this.CategoryPanel.Size = new System.Drawing.Size(1350, 50);
            this.CategoryPanel.TabIndex = 8;
            // 
            // AllCategory
            // 
            this.AllCategory.Animated = true;
            this.AllCategory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AllCategory.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.AllCategory.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.AllCategory.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.AllCategory.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(118)))), ((int)(((byte)(236)))));
            this.AllCategory.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.AllCategory.DefaultAutoSize = true;
            this.AllCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AllCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AllCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AllCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AllCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.AllCategory.FillColor = System.Drawing.Color.Transparent;
            this.AllCategory.Font = new System.Drawing.Font("Plus Jakarta Sans SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AllCategory.ForeColor = System.Drawing.Color.Black;
            this.AllCategory.IndicateFocus = true;
            this.AllCategory.Location = new System.Drawing.Point(145, 0);
            this.AllCategory.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.AllCategory.Name = "AllCategory";
            this.AllCategory.Padding = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.AllCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AllCategory.Size = new System.Drawing.Size(59, 50);
            this.AllCategory.TabIndex = 8;
            this.AllCategory.Text = "All";
            this.AllCategory.Click += new System.EventHandler(this.ProcessCategoryClick);
            // 
            // BookingStepOne
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.facilityPanel);
            this.Controls.Add(this.SecondPanel);
            this.Controls.Add(this.FacilityLabel);
            this.Name = "BookingStepOne";
            this.Size = new System.Drawing.Size(1350, 503);
            this.SecondPanel.ResumeLayout(false);
            this.CategoryPanel.ResumeLayout(false);
            this.CategoryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FacilityLabel;
        private System.Windows.Forms.FlowLayoutPanel facilityPanel;
        public Guna.UI2.WinForms.Guna2Panel SecondPanel;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private Guna.UI2.WinForms.Guna2Button AllCategory;
    }
}
