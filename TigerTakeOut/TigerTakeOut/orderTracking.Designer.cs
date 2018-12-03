namespace TigerTakeOut
{
    partial class orderTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderTracking));
            this.goBackButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.orderProgressLabel = new System.Windows.Forms.Label();
            this.orderProgress = new System.Windows.Forms.ProgressBar();
            this.orderInfoLabel = new System.Windows.Forms.Label();
            this.orderIssueLabel = new System.Windows.Forms.Label();
            this.complaintNumberLabel = new System.Windows.Forms.Label();
            this.orderSummaryLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.orderReceiptLabel = new System.Windows.Forms.Label();
            this.itemOneLabel = new System.Windows.Forms.Label();
            this.itemTwoLabel = new System.Windows.Forms.Label();
            this.orderMethodLabel = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.deliveryFeeLabel = new System.Windows.Forms.Label();
            this.orderTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.goBackButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(11, 790);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(212, 60);
            this.goBackButton.TabIndex = 0;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(60)))), ((int)(((byte)(49)))));
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(666, 480);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel Order";
            this.button1.UseVisualStyleBackColor = false;
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
            this.orderProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderProgress.Maximum = 500;
            this.orderProgress.Name = "orderProgress";
            this.orderProgress.Size = new System.Drawing.Size(731, 28);
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
            this.orderIssueLabel.Location = new System.Drawing.Point(712, 433);
            this.orderIssueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderIssueLabel.Name = "orderIssueLabel";
            this.orderIssueLabel.Size = new System.Drawing.Size(82, 14);
            this.orderIssueLabel.TabIndex = 5;
            this.orderIssueLabel.Text = "Have an Issue?";
            this.orderIssueLabel.Click += new System.EventHandler(this.orderIssueLabel_Click);
            // 
            // complaintNumberLabel
            // 
            this.complaintNumberLabel.AutoSize = true;
            this.complaintNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.complaintNumberLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintNumberLabel.Location = new System.Drawing.Point(712, 447);
            this.complaintNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.complaintNumberLabel.Name = "complaintNumberLabel";
            this.complaintNumberLabel.Size = new System.Drawing.Size(82, 14);
            this.complaintNumberLabel.TabIndex = 6;
            this.complaintNumberLabel.Text = "(123) 456-7891";
            this.complaintNumberLabel.Click += new System.EventHandler(this.complaintNumberLabel_Click);
            // 
            // orderSummaryLabel
            // 
            this.orderSummaryLabel.AutoSize = true;
            this.orderSummaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderSummaryLabel.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSummaryLabel.Location = new System.Drawing.Point(951, 354);
            this.orderSummaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderSummaryLabel.Name = "orderSummaryLabel";
            this.orderSummaryLabel.Size = new System.Drawing.Size(225, 29);
            this.orderSummaryLabel.TabIndex = 7;
            this.orderSummaryLabel.Text = "Order Information:";
            this.orderSummaryLabel.Click += new System.EventHandler(this.orderSummaryLabel_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(953, 429);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(216, 18);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Address: 181C Perkin\'s Road";
            this.addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.studentIDLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDLabel.Location = new System.Drawing.Point(953, 395);
            this.studentIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(169, 18);
            this.studentIDLabel.TabIndex = 9;
            this.studentIDLabel.Text = "Student ID: 123456789";
            this.studentIDLabel.Click += new System.EventHandler(this.studentIDLabel_Click);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(953, 464);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(229, 18);
            this.phoneNumberLabel.TabIndex = 10;
            this.phoneNumberLabel.Text = "Phone Number: (123) 456-7891";
            // 
            // orderReceiptLabel
            // 
            this.orderReceiptLabel.AutoSize = true;
            this.orderReceiptLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderReceiptLabel.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderReceiptLabel.Location = new System.Drawing.Point(1289, 354);
            this.orderReceiptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderReceiptLabel.Name = "orderReceiptLabel";
            this.orderReceiptLabel.Size = new System.Drawing.Size(172, 29);
            this.orderReceiptLabel.TabIndex = 11;
            this.orderReceiptLabel.Text = "Order Receipt:";
            // 
            // itemOneLabel
            // 
            this.itemOneLabel.AutoSize = true;
            this.itemOneLabel.BackColor = System.Drawing.Color.Transparent;
            this.itemOneLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemOneLabel.Location = new System.Drawing.Point(1291, 395);
            this.itemOneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemOneLabel.Name = "itemOneLabel";
            this.itemOneLabel.Size = new System.Drawing.Size(205, 18);
            this.itemOneLabel.TabIndex = 12;
            this.itemOneLabel.Text = "Bacon Cheeseburger: $5.99";
            // 
            // itemTwoLabel
            // 
            this.itemTwoLabel.AutoSize = true;
            this.itemTwoLabel.BackColor = System.Drawing.Color.Transparent;
            this.itemTwoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTwoLabel.Location = new System.Drawing.Point(1291, 429);
            this.itemTwoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemTwoLabel.Name = "itemTwoLabel";
            this.itemTwoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemTwoLabel.Size = new System.Drawing.Size(170, 18);
            this.itemTwoLabel.TabIndex = 13;
            this.itemTwoLabel.Text = "Mozarella Sticks: $3.99";
            // 
            // orderMethodLabel
            // 
            this.orderMethodLabel.AutoSize = true;
            this.orderMethodLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderMethodLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderMethodLabel.Location = new System.Drawing.Point(953, 498);
            this.orderMethodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderMethodLabel.Name = "orderMethodLabel";
            this.orderMethodLabel.Size = new System.Drawing.Size(210, 18);
            this.orderMethodLabel.TabIndex = 14;
            this.orderMethodLabel.Text = "Order Method: Dining Dollars";
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderTotalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTotalLabel.Location = new System.Drawing.Point(1290, 498);
            this.orderTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(105, 19);
            this.orderTotalLabel.TabIndex = 15;
            this.orderTotalLabel.Text = "Total: $15.97";
            // 
            // deliveryFeeLabel
            // 
            this.deliveryFeeLabel.AutoSize = true;
            this.deliveryFeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.deliveryFeeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryFeeLabel.Location = new System.Drawing.Point(1290, 464);
            this.deliveryFeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deliveryFeeLabel.Name = "deliveryFeeLabel";
            this.deliveryFeeLabel.Size = new System.Drawing.Size(153, 19);
            this.deliveryFeeLabel.TabIndex = 16;
            this.deliveryFeeLabel.Text = "Delivery Fee: $5.99";
            // 
            // orderTimer
            // 
            this.orderTimer.Tick += new System.EventHandler(this.orderTimer_Tick);
            // 
            // orderTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.deliveryFeeLabel);
            this.Controls.Add(this.orderTotalLabel);
            this.Controls.Add(this.orderMethodLabel);
            this.Controls.Add(this.itemTwoLabel);
            this.Controls.Add(this.itemOneLabel);
            this.Controls.Add(this.orderReceiptLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.studentIDLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.orderSummaryLabel);
            this.Controls.Add(this.complaintNumberLabel);
            this.Controls.Add(this.orderIssueLabel);
            this.Controls.Add(this.orderInfoLabel);
            this.Controls.Add(this.orderProgress);
            this.Controls.Add(this.orderProgressLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.goBackButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "orderTracking";
            this.Text = "Tiger Take Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label orderProgressLabel;
        private System.Windows.Forms.ProgressBar orderProgress;
        private System.Windows.Forms.Label orderInfoLabel;
        private System.Windows.Forms.Label orderIssueLabel;
        private System.Windows.Forms.Label complaintNumberLabel;
        private System.Windows.Forms.Label orderSummaryLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label orderReceiptLabel;
        private System.Windows.Forms.Label itemOneLabel;
        private System.Windows.Forms.Label itemTwoLabel;
        private System.Windows.Forms.Label orderMethodLabel;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.Label deliveryFeeLabel;
        private System.Windows.Forms.Timer orderTimer;
    }
}

