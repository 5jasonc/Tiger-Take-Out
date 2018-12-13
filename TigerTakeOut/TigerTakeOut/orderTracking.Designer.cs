namespace TigerTakeOut
{
    partial class OrderTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderTracking));
            this.goBackButton = new System.Windows.Forms.Button();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.orderProgressLabel = new System.Windows.Forms.Label();
            this.orderProgress = new System.Windows.Forms.ProgressBar();
            this.orderInfoLabel = new System.Windows.Forms.Label();
            this.orderIssueLabel = new System.Windows.Forms.Label();
            this.complaintNumberLabel = new System.Windows.Forms.Label();
            this.orderSummaryLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.orderMethodLabel = new System.Windows.Forms.Label();
            this.orderTimer = new System.Windows.Forms.Timer(this.components);
            this.street = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.zip = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.goBackButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(11, 790);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(212, 60);
            this.goBackButton.TabIndex = 0;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(60)))), ((int)(((byte)(49)))));
            this.cancelOrderButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderButton.ForeColor = System.Drawing.Color.White;
            this.cancelOrderButton.Location = new System.Drawing.Point(617, 475);
            this.cancelOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(128, 37);
            this.cancelOrderButton.TabIndex = 1;
            this.cancelOrderButton.Text = "Cancel Order";
            this.cancelOrderButton.UseVisualStyleBackColor = false;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // orderProgressLabel
            // 
            this.orderProgressLabel.AutoSize = true;
            this.orderProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderProgressLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderProgressLabel.Location = new System.Drawing.Point(58, 354);
            this.orderProgressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderProgressLabel.Name = "orderProgressLabel";
            this.orderProgressLabel.Size = new System.Drawing.Size(188, 29);
            this.orderProgressLabel.TabIndex = 2;
            this.orderProgressLabel.Text = "Order Progress:";
            // 
            // orderProgress
            // 
            this.orderProgress.BackColor = System.Drawing.Color.White;
            this.orderProgress.ForeColor = System.Drawing.Color.DarkOrange;
            this.orderProgress.Location = new System.Drawing.Point(63, 395);
            this.orderProgress.Margin = new System.Windows.Forms.Padding(2);
            this.orderProgress.Maximum = 500;
            this.orderProgress.Name = "orderProgress";
            this.orderProgress.Size = new System.Drawing.Size(682, 28);
            this.orderProgress.Step = 5;
            this.orderProgress.TabIndex = 3;
            // 
            // orderInfoLabel
            // 
            this.orderInfoLabel.AutoSize = true;
            this.orderInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderInfoLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderInfoLabel.Location = new System.Drawing.Point(60, 431);
            this.orderInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderInfoLabel.Name = "orderInfoLabel";
            this.orderInfoLabel.Size = new System.Drawing.Size(119, 16);
            this.orderInfoLabel.TabIndex = 4;
            this.orderInfoLabel.Text = "Preparing order...";
            // 
            // orderIssueLabel
            // 
            this.orderIssueLabel.AutoSize = true;
            this.orderIssueLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderIssueLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIssueLabel.Location = new System.Drawing.Point(663, 428);
            this.orderIssueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderIssueLabel.Name = "orderIssueLabel";
            this.orderIssueLabel.Size = new System.Drawing.Size(82, 14);
            this.orderIssueLabel.TabIndex = 5;
            this.orderIssueLabel.Text = "Have an Issue?";
            // 
            // complaintNumberLabel
            // 
            this.complaintNumberLabel.AutoSize = true;
            this.complaintNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.complaintNumberLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintNumberLabel.Location = new System.Drawing.Point(663, 442);
            this.complaintNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.complaintNumberLabel.Name = "complaintNumberLabel";
            this.complaintNumberLabel.Size = new System.Drawing.Size(82, 14);
            this.complaintNumberLabel.TabIndex = 6;
            this.complaintNumberLabel.Text = "(123) 456-7891";
            // 
            // orderSummaryLabel
            // 
            this.orderSummaryLabel.AutoSize = true;
            this.orderSummaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderSummaryLabel.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSummaryLabel.Location = new System.Drawing.Point(819, 302);
            this.orderSummaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderSummaryLabel.Name = "orderSummaryLabel";
            this.orderSummaryLabel.Size = new System.Drawing.Size(225, 29);
            this.orderSummaryLabel.TabIndex = 7;
            this.orderSummaryLabel.Text = "Order Information:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(821, 343);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(71, 18);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Address:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(821, 412);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(52, 18);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Email:";
            // 
            // orderMethodLabel
            // 
            this.orderMethodLabel.AutoSize = true;
            this.orderMethodLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderMethodLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderMethodLabel.Location = new System.Drawing.Point(821, 446);
            this.orderMethodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderMethodLabel.Name = "orderMethodLabel";
            this.orderMethodLabel.Size = new System.Drawing.Size(190, 18);
            this.orderMethodLabel.TabIndex = 14;
            this.orderMethodLabel.Text = "Order Method: TigerBucks";
            // 
            // orderTimer
            // 
            this.orderTimer.Tick += new System.EventHandler(this.orderTimer_Tick);
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street.Location = new System.Drawing.Point(897, 345);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(46, 16);
            this.street.TabIndex = 16;
            this.street.Text = "Street";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(821, 377);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(32, 16);
            this.city.TabIndex = 16;
            this.city.Text = "City";
            // 
            // zip
            // 
            this.zip.AutoSize = true;
            this.zip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zip.Location = new System.Drawing.Point(969, 377);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(27, 16);
            this.zip.TabIndex = 16;
            this.zip.Text = "Zip";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(878, 414);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(44, 16);
            this.email.TabIndex = 16;
            this.email.Text = "email";
            // 
            // OrderTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.email);
            this.Controls.Add(this.city);
            this.Controls.Add(this.street);
            this.Controls.Add(this.orderMethodLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.orderSummaryLabel);
            this.Controls.Add(this.complaintNumberLabel);
            this.Controls.Add(this.orderIssueLabel);
            this.Controls.Add(this.orderInfoLabel);
            this.Controls.Add(this.orderProgress);
            this.Controls.Add(this.orderProgressLabel);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.goBackButton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderTracking";
            this.Text = "Tiger Take Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.Label orderProgressLabel;
        private System.Windows.Forms.ProgressBar orderProgress;
        private System.Windows.Forms.Label orderInfoLabel;
        private System.Windows.Forms.Label orderIssueLabel;
        private System.Windows.Forms.Label complaintNumberLabel;
        private System.Windows.Forms.Label orderSummaryLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label orderMethodLabel;
        private System.Windows.Forms.Timer orderTimer;

        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label zip;
        private System.Windows.Forms.Label email;
    }
}

