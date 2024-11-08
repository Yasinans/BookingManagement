namespace BookingManagement
{
    partial class ClientForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.returnButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            this.clientFooter = new ClientFooter();
            this.bookingStepOne = new BookingForm.BookingStepOne();
            this.bookingStepTwo = new BookingForm.BookingStepTwo();
            this.bookingStepThree = new BookingForm.BookingStepThree();
            this.bookingStepFour = new BookingForm.BookingStepFour();
            this.bookingFinal = new BookingForm.BookingFinal();
            this.scheduleTwo = new ScheduleForm.ScheduleTwo();
            this.homePanel = new HomePanel();
            this.scheduleOne = new ScheduleForm.ScheduleOne();
            this.headerPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.headerPanel.Controls.Add(this.tableLayoutPanel1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1334, 81);
            this.headerPanel.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.33206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.66794F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tableLayoutPanel1.Controls.Add(this.currentDateLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.welcomeLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.returnButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1334, 81);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.currentDateLabel.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.currentDateLabel.Location = new System.Drawing.Point(1020, 0);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(54, 81);
            this.currentDateLabel.TabIndex = 6;
            this.currentDateLabel.Text = "Date";
            this.currentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.welcomeLabel.Font = new System.Drawing.Font("Plus Jakarta Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(250, 16);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(764, 48);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Welcome to EduReserve!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnButton
            // 
            this.returnButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.returnButton.BorderColor = System.Drawing.Color.Gainsboro;
            this.returnButton.BorderRadius = 5;
            this.returnButton.BorderThickness = 1;
            this.returnButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.returnButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.returnButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.returnButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.returnButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.returnButton.FillColor = System.Drawing.Color.Empty;
            this.returnButton.FillColor2 = System.Drawing.Color.Transparent;
            this.returnButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.returnButton.Image = global::BookingManagement.Properties.Resources._return;
            this.returnButton.Location = new System.Drawing.Point(10, 13);
            this.returnButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(54, 54);
            this.returnButton.TabIndex = 7;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // dateTimer
            // 
            this.dateTimer.Interval = 1000;
            this.dateTimer.Tick += Timer_Tick;
            // 
            // clientFooter
            // 
            this.clientFooter.BackColor = System.Drawing.Color.Transparent;
            this.clientFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clientFooter.Location = new System.Drawing.Point(0, 581);
            this.clientFooter.Margin = new System.Windows.Forms.Padding(10);
            this.clientFooter.Name = "clientFooter";
            this.clientFooter.Size = new System.Drawing.Size(1334, 103);
            this.clientFooter.TabIndex = 13;
            // 
            // bookingStepOne
            // 
            this.bookingStepOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingStepOne.Location = new System.Drawing.Point(0, 584);
            this.bookingStepOne.Name = "bookingStepOne";
            this.bookingStepOne.Size = new System.Drawing.Size(1334, 0);
            this.bookingStepOne.TabIndex = 15;
            // 
            // bookingStepTwo
            // 
            this.bookingStepTwo.BackColor = System.Drawing.Color.Transparent;
            this.bookingStepTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingStepTwo.Location = new System.Drawing.Point(0, 584);
            this.bookingStepTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookingStepTwo.FullName = "bookingStepTwo";
            this.bookingStepTwo.Size = new System.Drawing.Size(1334, 0);
            this.bookingStepTwo.TabIndex = 16;
            // 
            // bookingStepThree
            // 
            this.bookingStepThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingStepThree.Location = new System.Drawing.Point(0, 584);
            this.bookingStepThree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookingStepThree.Name = "bookingStepThree";
            this.bookingStepThree.Size = new System.Drawing.Size(1334, 0);
            this.bookingStepThree.TabIndex = 17;
            // 
            // bookingStepFour
            // 
            this.bookingStepFour.BackColor = System.Drawing.Color.Transparent;
            this.bookingStepFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingStepFour.Location = new System.Drawing.Point(0, 584);
            this.bookingStepFour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookingStepFour.Name = "bookingStepFour";
            this.bookingStepFour.Size = new System.Drawing.Size(1334, 0);
            this.bookingStepFour.TabIndex = 18;
            // 
            // bookingFinal
            // 
            this.bookingFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingFinal.Location = new System.Drawing.Point(0, 584);
            this.bookingFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookingFinal.Name = "bookingFinal";
            this.bookingFinal.Size = new System.Drawing.Size(1334, 0);
            this.bookingFinal.TabIndex = 19;
            // 
            // scheduleTwo
            // 
            this.scheduleTwo.BackColor = System.Drawing.Color.Transparent;
            this.scheduleTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleTwo.Location = new System.Drawing.Point(0, 584);
            this.scheduleTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scheduleTwo.Name = "scheduleTwo";
            this.scheduleTwo.Size = new System.Drawing.Size(1334, 0);
            this.scheduleTwo.TabIndex = 22;
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.Transparent;
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.homePanel.Location = new System.Drawing.Point(0, 81);
            this.homePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1334, 503);
            this.homePanel.TabIndex = 14;
            // 
            // scheduleOne
            // 
            this.scheduleOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleOne.Location = new System.Drawing.Point(0, 584);
            this.scheduleOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scheduleOne.Name = "scheduleOne";
            this.scheduleOne.Size = new System.Drawing.Size(1334, 0);
            this.scheduleOne.TabIndex = 23;
            // 
            // ClientForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 684);
            this.Controls.Add(this.scheduleOne);
            this.Controls.Add(this.scheduleTwo);
            this.Controls.Add(this.bookingFinal);
            this.Controls.Add(this.bookingStepFour);
            this.Controls.Add(this.bookingStepThree);
            this.Controls.Add(this.bookingStepTwo);
            this.Controls.Add(this.bookingStepOne);
            this.Controls.Add(this.homePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Controls.Add(this.clientFooter);
            this.Controls.Add(this.headerPanel);
            this.dateTimer.Enabled = true;
            this.Name = "ClientForm";
            this.Text = "Booking Management";
            this.headerPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ClientFooter clientFooter;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.Timer dateTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label welcomeLabel;
        private Guna.UI2.WinForms.Guna2GradientButton returnButton;
        private BookingForm.BookingStepOne bookingStepOne;
        private BookingForm.BookingStepTwo bookingStepTwo;
        private BookingForm.BookingStepThree bookingStepThree;
        private BookingForm.BookingStepFour bookingStepFour;
        private BookingForm.BookingFinal bookingFinal;
        private ScheduleForm.ScheduleTwo scheduleTwo;
        private HomePanel homePanel;
        private ScheduleForm.ScheduleOne scheduleOne;
    }
}