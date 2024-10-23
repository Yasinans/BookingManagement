
using BookingManagement.Util;

namespace BookingManagement
{
    partial class HomePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanel));
            this.HomeLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BookFacilityButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BookLabel = new System.Windows.Forms.Label();
            this.BookDescriptionLabel = new System.Windows.Forms.Label();
            this.ViewScheduleButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ScheduleLabel = new System.Windows.Forms.Label();
            this.ScheduleDescriptionLabel = new System.Windows.Forms.Label();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.HomeLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeLayoutPanel
            // 
            this.HomeLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HomeLayoutPanel.ColumnCount = 5;
            this.HomeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 336F));
            this.HomeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 522F));
            this.HomeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 286F));
            this.HomeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 537F));
            this.HomeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HomeLayoutPanel.Controls.Add(this.BookFacilityButton, 1, 0);
            this.HomeLayoutPanel.Controls.Add(this.BookLabel, 1, 1);
            this.HomeLayoutPanel.Controls.Add(this.BookDescriptionLabel, 1, 2);
            this.HomeLayoutPanel.Controls.Add(this.ViewScheduleButton, 3, 0);
            this.HomeLayoutPanel.Controls.Add(this.ScheduleLabel, 3, 1);
            this.HomeLayoutPanel.Controls.Add(this.ScheduleDescriptionLabel, 3, 2);
            this.HomeLayoutPanel.Location = new System.Drawing.Point(0, 175);
            this.HomeLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeLayoutPanel.Name = "HomeLayoutPanel";
            this.HomeLayoutPanel.RowCount = 3;
            this.HomeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 349F));
            this.HomeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.74194F));
            this.HomeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.HomeLayoutPanel.Size = new System.Drawing.Size(2025, 598);
            this.HomeLayoutPanel.TabIndex = 15;
            // 
            // BookFacilityButton
            // 
            this.BookFacilityButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BookFacilityButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.BookFacilityButton.HoverState.ImageSize = new System.Drawing.Size(341, 209);
            this.BookFacilityButton.Image = ((System.Drawing.Image)(resources.GetObject("BookFacilityButton.Image")));
            this.BookFacilityButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.BookFacilityButton.ImageRotate = 0F;
            this.BookFacilityButton.ImageSize = new System.Drawing.Size(342, 210);
            this.BookFacilityButton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.BookFacilityButton.Location = new System.Drawing.Point(340, 5);
            this.BookFacilityButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BookFacilityButton.Name = "BookFacilityButton";
            this.BookFacilityButton.PressedState.ImageSize = new System.Drawing.Size(342, 210);
            this.BookFacilityButton.Size = new System.Drawing.Size(513, 339);
            this.BookFacilityButton.TabIndex = 3;
            // 
            // BookLabel
            // 
            this.BookLabel.AutoSize = true;
            this.BookLabel.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BookLabel.Location = new System.Drawing.Point(340, 349);
            this.BookLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Size = new System.Drawing.Size(153, 33);
            this.BookLabel.TabIndex = 1;
            this.BookLabel.Text = "Book a Facility";
            this.BookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookDescriptionLabel
            // 
            this.BookDescriptionLabel.AutoSize = true;
            this.BookDescriptionLabel.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BookDescriptionLabel.Location = new System.Drawing.Point(340, 400);
            this.BookDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookDescriptionLabel.Name = "BookDescriptionLabel";
            this.BookDescriptionLabel.Size = new System.Drawing.Size(291, 58);
            this.BookDescriptionLabel.TabIndex = 5;
            this.BookDescriptionLabel.Text = "Auditorium, gym, computer labs, \nmeeting rooms, etc";
            this.BookDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewScheduleButton
            // 
            this.ViewScheduleButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ViewScheduleButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.ViewScheduleButton.HoverState.ImageSize = new System.Drawing.Size(341, 209);
            this.ViewScheduleButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewScheduleButton.Image")));
            this.ViewScheduleButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.ViewScheduleButton.ImageRotate = 0F;
            this.ViewScheduleButton.ImageSize = new System.Drawing.Size(342, 210);
            this.ViewScheduleButton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ViewScheduleButton.Location = new System.Drawing.Point(1148, 5);
            this.ViewScheduleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewScheduleButton.Name = "ViewScheduleButton";
            this.ViewScheduleButton.PressedState.ImageSize = new System.Drawing.Size(342, 210);
            this.ViewScheduleButton.Size = new System.Drawing.Size(513, 318);
            this.ViewScheduleButton.TabIndex = 4;
            // 
            // ScheduleLabel
            // 
            this.ScheduleLabel.AutoSize = true;
            this.ScheduleLabel.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ScheduleLabel.Location = new System.Drawing.Point(1148, 349);
            this.ScheduleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScheduleLabel.Name = "ScheduleLabel";
            this.ScheduleLabel.Size = new System.Drawing.Size(166, 33);
            this.ScheduleLabel.TabIndex = 7;
            this.ScheduleLabel.Text = "View Schedules";
            this.ScheduleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScheduleDescriptionLabel
            // 
            this.ScheduleDescriptionLabel.AutoSize = true;
            this.ScheduleDescriptionLabel.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ScheduleDescriptionLabel.Location = new System.Drawing.Point(1148, 400);
            this.ScheduleDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScheduleDescriptionLabel.Name = "ScheduleDescriptionLabel";
            this.ScheduleDescriptionLabel.Size = new System.Drawing.Size(291, 58);
            this.ScheduleDescriptionLabel.TabIndex = 8;
            this.ScheduleDescriptionLabel.Text = "Auditorium, gym, computer labs, \nmeeting rooms, etc";
            this.ScheduleDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HomeLabel
            // 
            this.HomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeLabel.Font = new System.Drawing.Font("Plus Jakarta Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.HomeLabel.Location = new System.Drawing.Point(0, 0);
            this.HomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(2025, 175);
            this.HomeLabel.TabIndex = 16;
            this.HomeLabel.Text = "How can we help you today?";
            this.HomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.HomeLabel);
            this.Controls.Add(this.HomeLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(2025, 774);
            this.HomeLayoutPanel.ResumeLayout(false);
            this.HomeLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HomeLayoutPanel;
        private Guna.UI2.WinForms.Guna2ImageButton BookFacilityButton;
        private System.Windows.Forms.Label BookLabel;
        private System.Windows.Forms.Label BookDescriptionLabel;
        private Guna.UI2.WinForms.Guna2ImageButton ViewScheduleButton;
        private System.Windows.Forms.Label ScheduleLabel;
        private System.Windows.Forms.Label ScheduleDescriptionLabel;
        private System.Windows.Forms.Label HomeLabel;
    }
}
