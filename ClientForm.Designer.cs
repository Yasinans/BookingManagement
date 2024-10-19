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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.bookingStepTwo1 = new BookingManagement.BookingForm.BookingStepTwo();
            this.bookingStepOne = new BookingManagement.BookingForm.BookingStepOne();
            this.homePanel = new BookingManagement.HomePanel();
            this.clientFooter = new BookingManagement.ClientFooter();
            this.clientHeader = new BookingManagement.ClientHeader();
            this.bookingStepThree1 = new BookingManagement.BookingForm.BookingStepThree();
            this.bookingStepFour1 = new BookingManagement.BookingForm.BookingStepFour();
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
            this.bookingStepTwo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingStepTwo1.BackColor = System.Drawing.Color.Transparent;
            this.bookingStepTwo1.Location = new System.Drawing.Point(0, 76);
            this.bookingStepTwo1.Name = "bookingStepTwo1";
            this.bookingStepTwo1.Size = new System.Drawing.Size(1350, 503);
            this.bookingStepTwo1.TabIndex = 16;
            // 
            // bookingStepOne
            // 
            this.bookingStepOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingStepOne.Location = new System.Drawing.Point(0, 579);
            this.bookingStepOne.Name = "bookingStepOne";
            this.bookingStepOne.Size = new System.Drawing.Size(1334, 2);
            this.bookingStepOne.TabIndex = 15;
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.Transparent;
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.homePanel.Location = new System.Drawing.Point(0, 76);
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
            // clientHeader
            // 
            this.clientHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientHeader.Location = new System.Drawing.Point(0, 0);
            this.clientHeader.Name = "clientHeader";
            this.clientHeader.Size = new System.Drawing.Size(1334, 76);
            this.clientHeader.TabIndex = 11;
            // 
            // bookingStepThree1
            // 
            this.bookingStepThree1.Location = new System.Drawing.Point(0, 76);
            this.bookingStepThree1.Name = "bookingStepThree1";
            this.bookingStepThree1.Size = new System.Drawing.Size(1350, 503);
            this.bookingStepThree1.TabIndex = 17;
            // 
            // bookingStepFour1
            // 
            this.bookingStepFour1.Location = new System.Drawing.Point(0, 76);
            this.bookingStepFour1.Name = "bookingStepFour1";
            this.bookingStepFour1.Size = new System.Drawing.Size(1350, 503);
            this.bookingStepFour1.TabIndex = 18;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 684);
            this.Controls.Add(this.bookingStepFour1);
            this.Controls.Add(this.bookingStepThree1);
            this.Controls.Add(this.bookingStepTwo1);
            this.Controls.Add(this.bookingStepOne);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.clientFooter);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.clientHeader);
            this.Name = "ClientForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private ClientHeader clientHeader;
        private System.Windows.Forms.Label welcomeLabel;
        private ClientFooter clientFooter;
        private HomePanel homePanel;
        private BookingForm.BookingStepOne bookingStepOne;
        private BookingForm.BookingStepTwo bookingStepTwo1;
        private BookingForm.BookingStepThree bookingStepThree1;
        private BookingForm.BookingStepFour bookingStepFour1;
    }
}

