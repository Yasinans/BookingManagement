namespace BookingManagement.ScheduleForm
{
    partial class BookingCard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DateLabel = new System.Windows.Forms.Label();
            this.PurposeLabel = new System.Windows.Forms.Label();
            this.Button = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.DateLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PurposeLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DateLabel.Location = new System.Drawing.Point(64, 23);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(201, 34);
            this.DateLabel.TabIndex = 5;
            this.DateLabel.Text = "December 12, 2023 12:00 AM - 12:00 AM\r\naa\r\n";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PurposeLabel
            // 
            this.PurposeLabel.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurposeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.PurposeLabel.Location = new System.Drawing.Point(64, 0);
            this.PurposeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PurposeLabel.Name = "PurposeLabel";
            this.PurposeLabel.Size = new System.Drawing.Size(255, 23);
            this.PurposeLabel.TabIndex = 4;
            this.PurposeLabel.Text = "Purpose Label";
            this.PurposeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button
            // 
            this.Button.Animated = true;
            this.Button.BackColor = System.Drawing.Color.Transparent;
            this.Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button.BorderRadius = 4;
            this.Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Button.Font = new System.Drawing.Font("Plus Jakarta Sans", 7F, System.Drawing.FontStyle.Bold);
            this.Button.ForeColor = System.Drawing.Color.Black;
            this.Button.IndicateFocus = true;
            this.Button.Location = new System.Drawing.Point(0, 0);
            this.Button.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Button.Name = "Button";
            this.tableLayoutPanel1.SetRowSpan(this.Button, 2);
            this.Button.Size = new System.Drawing.Size(54, 54);
            this.Button.TabIndex = 6;
            this.Button.Text = "View";
            // 
            // BookingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BookingCard";
            this.Size = new System.Drawing.Size(345, 54);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button Button;
        public System.Windows.Forms.Label DateLabel;
        public System.Windows.Forms.Label PurposeLabel;
    }
}
