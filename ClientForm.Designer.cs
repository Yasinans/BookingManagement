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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.bookingStepTwo1 = new BookingManagement.BookingForm.BookingStepTwo();
            this.bookingStepOne = new BookingManagement.BookingForm.BookingStepOne();
            this.homePanel = new BookingManagement.HomePanel();
            this.clientFooter = new BookingManagement.ClientFooter();
            this.bookingStepThree1 = new BookingManagement.BookingForm.BookingStepThree();
            this.bookingStepFour1 = new BookingManagement.BookingForm.BookingStepFour();
            this.bookingFinal1 = new BookingManagement.BookingForm.BookingFinal();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.welcomeLabel.Font = new System.Drawing.Font("Plus Jakarta Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(483, 10);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(374, 48);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome to EduReserve!";
            // 
            // bookingStepTwo1
            // 
            this.bookingStepTwo1.BackColor = System.Drawing.Color.Transparent;
            this.bookingStepTwo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingStepTwo1.Location = new System.Drawing.Point(0, 584);
            this.bookingStepTwo1.Name = "bookingStepTwo1";
            this.bookingStepTwo1.Size = new System.Drawing.Size(1334, 0);
            this.bookingStepTwo1.TabIndex = 16;
            // 
            // bookingStepOne
            // 
            this.bookingStepOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingStepOne.Location = new System.Drawing.Point(0, 584);
            this.bookingStepOne.Name = "bookingStepOne";
            this.bookingStepOne.Size = new System.Drawing.Size(1334, 0);
            this.bookingStepOne.TabIndex = 15;
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.Transparent;
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.homePanel.Location = new System.Drawing.Point(0, 81);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1334, 503);
            this.homePanel.TabIndex = 14;
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
            // bookingStepThree1
            // 
            this.bookingStepThree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingStepThree1.Location = new System.Drawing.Point(0, 584);
            this.bookingStepThree1.Name = "bookingStepThree1";
            this.bookingStepThree1.Size = new System.Drawing.Size(1334, 0);
            this.bookingStepThree1.TabIndex = 17;
            // 
            // bookingStepFour1
            // 
            this.bookingStepFour1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingStepFour1.Location = new System.Drawing.Point(0, 584);
            this.bookingStepFour1.Name = "bookingStepFour1";
            this.bookingStepFour1.Size = new System.Drawing.Size(1334, 0);
            this.bookingStepFour1.TabIndex = 18;
            // 
            // bookingFinal1
            // 
            this.bookingFinal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingFinal1.Location = new System.Drawing.Point(0, 584);
            this.bookingFinal1.Name = "bookingFinal1";
            this.bookingFinal1.Size = new System.Drawing.Size(1334, 0);
            this.bookingFinal1.TabIndex = 19;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.headerPanel.Controls.Add(this.currentDateLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1334, 81);
            this.headerPanel.TabIndex = 20;
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.currentDateLabel.Location = new System.Drawing.Point(1051, 26);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(54, 29);
            this.currentDateLabel.TabIndex = 6;
            this.currentDateLabel.Text = "Date";
            this.currentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimer
            // 
            this.dateTimer.Interval = 1000;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 684);
            this.Controls.Add(this.bookingFinal1);
            this.Controls.Add(this.bookingStepFour1);
            this.Controls.Add(this.bookingStepThree1);
            this.Controls.Add(this.bookingStepTwo1);
            this.Controls.Add(this.bookingStepOne);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.clientFooter);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.headerPanel);
            this.Name = "ClientForm";
            this.Text = "Form1";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label welcomeLabel;
        private ClientFooter clientFooter;
        private HomePanel homePanel;
        private BookingForm.BookingStepOne bookingStepOne;
        private BookingForm.BookingStepTwo bookingStepTwo1;
        private BookingForm.BookingStepThree bookingStepThree1;
        private BookingForm.BookingStepFour bookingStepFour1;
        private BookingForm.BookingFinal bookingFinal1;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.Timer dateTimer;
    }
}

