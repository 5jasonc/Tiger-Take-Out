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
            this.orderReceiptLabel = new System.Windows.Forms.Label();
            this.orderMethodLabel = new System.Windows.Forms.Label();
            this.orderTimer = new System.Windows.Forms.Timer(this.components);
            this.item1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.Label();
            this.price2 = new System.Windows.Forms.Label();
            this.price3 = new System.Windows.Forms.Label();
            this.price4 = new System.Windows.Forms.Label();
            this.price5 = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.Label();
            this.deliveryFeeLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
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
            // orderReceiptLabel
            // 
            this.orderReceiptLabel.AutoSize = true;
            this.orderReceiptLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderReceiptLabel.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderReceiptLabel.Location = new System.Drawing.Point(1162, 302);
            this.orderReceiptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderReceiptLabel.Name = "orderReceiptLabel";
            this.orderReceiptLabel.Size = new System.Drawing.Size(172, 29);
            this.orderReceiptLabel.TabIndex = 11;
            this.orderReceiptLabel.Text = "Order Receipt:";
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
            // item1
            // 
            this.item1.AutoSize = true;
            this.item1.BackColor = System.Drawing.Color.Transparent;
            this.item1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item1.Location = new System.Drawing.Point(1167, 343);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(0, 18);
            this.item1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1167, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1167, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1167, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1167, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 15;
            // 
            // price1
            // 
            this.price1.AutoSize = true;
            this.price1.BackColor = System.Drawing.Color.Transparent;
            this.price1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price1.Location = new System.Drawing.Point(1394, 343);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(0, 18);
            this.price1.TabIndex = 15;
            // 
            // price2
            // 
            this.price2.AutoSize = true;
            this.price2.BackColor = System.Drawing.Color.Transparent;
            this.price2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price2.Location = new System.Drawing.Point(1394, 377);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(0, 18);
            this.price2.TabIndex = 15;
            // 
            // price3
            // 
            this.price3.AutoSize = true;
            this.price3.BackColor = System.Drawing.Color.Transparent;
            this.price3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price3.Location = new System.Drawing.Point(1394, 412);
            this.price3.Name = "price3";
            this.price3.Size = new System.Drawing.Size(0, 18);
            this.price3.TabIndex = 15;
            // 
            // price4
            // 
            this.price4.AutoSize = true;
            this.price4.BackColor = System.Drawing.Color.Transparent;
            this.price4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price4.Location = new System.Drawing.Point(1394, 446);
            this.price4.Name = "price4";
            this.price4.Size = new System.Drawing.Size(0, 18);
            this.price4.TabIndex = 15;
            // 
            // price5
            // 
            this.price5.AutoSize = true;
            this.price5.BackColor = System.Drawing.Color.Transparent;
            this.price5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price5.Location = new System.Drawing.Point(1394, 483);
            this.price5.Name = "price5";
            this.price5.Size = new System.Drawing.Size(0, 18);
            this.price5.TabIndex = 15;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtotalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.Color.DimGray;
            this.subtotalLabel.Location = new System.Drawing.Point(1167, 551);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(65, 18);
            this.subtotalLabel.TabIndex = 15;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.BackColor = System.Drawing.Color.Transparent;
            this.subtotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.ForeColor = System.Drawing.Color.DimGray;
            this.subtotal.Location = new System.Drawing.Point(1394, 551);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(0, 18);
            this.subtotal.TabIndex = 15;
            // 
            // deliveryFeeLabel
            // 
            this.deliveryFeeLabel.AutoSize = true;
            this.deliveryFeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.deliveryFeeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryFeeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.deliveryFeeLabel.Location = new System.Drawing.Point(1167, 591);
            this.deliveryFeeLabel.Name = "deliveryFeeLabel";
            this.deliveryFeeLabel.Size = new System.Drawing.Size(96, 18);
            this.deliveryFeeLabel.TabIndex = 15;
            this.deliveryFeeLabel.Text = "Delivery Fee";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(1394, 591);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "5.99";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Black;
            this.totalLabel.Location = new System.Drawing.Point(1167, 641);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(46, 19);
            this.totalLabel.TabIndex = 15;
            this.totalLabel.Text = "Total";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.Color.Transparent;
            this.total.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.Black;
            this.total.Location = new System.Drawing.Point(1393, 636);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 24);
            this.total.TabIndex = 15;
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
            this.Controls.Add(this.total);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.price5);
            this.Controls.Add(this.price4);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.deliveryFeeLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.item1);
            this.Controls.Add(this.orderMethodLabel);
            this.Controls.Add(this.orderReceiptLabel);
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
        private System.Windows.Forms.Label orderReceiptLabel;
        private System.Windows.Forms.Label orderMethodLabel;
        private System.Windows.Forms.Timer orderTimer;
        private System.Windows.Forms.Label item1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label price1;
        private System.Windows.Forms.Label price2;
        private System.Windows.Forms.Label price3;
        private System.Windows.Forms.Label price4;
        private System.Windows.Forms.Label price5;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label deliveryFeeLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label zip;
        private System.Windows.Forms.Label email;
    }
}

