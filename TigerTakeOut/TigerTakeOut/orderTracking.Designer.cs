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
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.DarkOrange;
            this.goBackButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(12, 12);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(171, 45);
            this.goBackButton.TabIndex = 0;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel Order";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // orderProgressLabel
            // 
            this.orderProgressLabel.AutoSize = true;
            this.orderProgressLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderProgressLabel.Location = new System.Drawing.Point(107, 127);
            this.orderProgressLabel.Name = "orderProgressLabel";
            this.orderProgressLabel.Size = new System.Drawing.Size(156, 24);
            this.orderProgressLabel.TabIndex = 2;
            this.orderProgressLabel.Text = "Order Progress:";
            // 
            // orderProgress
            // 
            this.orderProgress.BackColor = System.Drawing.Color.White;
            this.orderProgress.ForeColor = System.Drawing.Color.DarkOrange;
            this.orderProgress.Location = new System.Drawing.Point(111, 154);
            this.orderProgress.Name = "orderProgress";
            this.orderProgress.Size = new System.Drawing.Size(667, 29);
            this.orderProgress.TabIndex = 3;
            // 
            // orderInfoLabel
            // 
            this.orderInfoLabel.AutoSize = true;
            this.orderInfoLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderInfoLabel.Location = new System.Drawing.Point(108, 186);
            this.orderInfoLabel.Name = "orderInfoLabel";
            this.orderInfoLabel.Size = new System.Drawing.Size(119, 16);
            this.orderInfoLabel.TabIndex = 4;
            this.orderInfoLabel.Text = "Preparing order...";
            // 
            // orderIssueLabel
            // 
            this.orderIssueLabel.AutoSize = true;
            this.orderIssueLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIssueLabel.Location = new System.Drawing.Point(672, 186);
            this.orderIssueLabel.Name = "orderIssueLabel";
            this.orderIssueLabel.Size = new System.Drawing.Size(105, 16);
            this.orderIssueLabel.TabIndex = 5;
            this.orderIssueLabel.Text = "Have an Issue?";
            // 
            // complaintNumberLabel
            // 
            this.complaintNumberLabel.AutoSize = true;
            this.complaintNumberLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintNumberLabel.Location = new System.Drawing.Point(670, 202);
            this.complaintNumberLabel.Name = "complaintNumberLabel";
            this.complaintNumberLabel.Size = new System.Drawing.Size(107, 16);
            this.complaintNumberLabel.TabIndex = 6;
            this.complaintNumberLabel.Text = "(123) 456-7891";
            // 
            // orderSummaryLabel
            // 
            this.orderSummaryLabel.AutoSize = true;
            this.orderSummaryLabel.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSummaryLabel.Location = new System.Drawing.Point(107, 290);
            this.orderSummaryLabel.Name = "orderSummaryLabel";
            this.orderSummaryLabel.Size = new System.Drawing.Size(189, 24);
            this.orderSummaryLabel.TabIndex = 7;
            this.orderSummaryLabel.Text = "Order Information:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(108, 353);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(194, 16);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Address: 181C Perkin\'s Road";
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDLabel.Location = new System.Drawing.Point(108, 325);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(154, 16);
            this.studentIDLabel.TabIndex = 9;
            this.studentIDLabel.Text = "Student ID: 123456789";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(108, 379);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(209, 16);
            this.phoneNumberLabel.TabIndex = 10;
            this.phoneNumberLabel.Text = "Phone Number: (123) 456-7891";
            // 
            // orderReceiptLabel
            // 
            this.orderReceiptLabel.AutoSize = true;
            this.orderReceiptLabel.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderReceiptLabel.Location = new System.Drawing.Point(419, 290);
            this.orderReceiptLabel.Name = "orderReceiptLabel";
            this.orderReceiptLabel.Size = new System.Drawing.Size(142, 24);
            this.orderReceiptLabel.TabIndex = 11;
            this.orderReceiptLabel.Text = "Order Receipt:";
            // 
            // itemOneLabel
            // 
            this.itemOneLabel.AutoSize = true;
            this.itemOneLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemOneLabel.Location = new System.Drawing.Point(420, 325);
            this.itemOneLabel.Name = "itemOneLabel";
            this.itemOneLabel.Size = new System.Drawing.Size(187, 16);
            this.itemOneLabel.TabIndex = 12;
            this.itemOneLabel.Text = "Bacon Cheeseburger: $5.99";
            // 
            // itemTwoLabel
            // 
            this.itemTwoLabel.AutoSize = true;
            this.itemTwoLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTwoLabel.Location = new System.Drawing.Point(420, 353);
            this.itemTwoLabel.Name = "itemTwoLabel";
            this.itemTwoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemTwoLabel.Size = new System.Drawing.Size(153, 16);
            this.itemTwoLabel.TabIndex = 13;
            this.itemTwoLabel.Text = "Mozarella Sticks: $3.99";
            // 
            // orderMethodLabel
            // 
            this.orderMethodLabel.AutoSize = true;
            this.orderMethodLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderMethodLabel.Location = new System.Drawing.Point(108, 404);
            this.orderMethodLabel.Name = "orderMethodLabel";
            this.orderMethodLabel.Size = new System.Drawing.Size(192, 16);
            this.orderMethodLabel.TabIndex = 14;
            this.orderMethodLabel.Text = "Order Method: Dining Dollars";
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTotalLabel.Location = new System.Drawing.Point(420, 404);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(85, 16);
            this.orderTotalLabel.TabIndex = 15;
            this.orderTotalLabel.Text = "Total: $9.98";
            // 
            // orderTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 564);
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
            this.Name = "orderTracking";
            this.Text = "Form1";
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
    }
}

