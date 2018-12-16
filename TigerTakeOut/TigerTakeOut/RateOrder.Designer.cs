namespace TigerTakeOut
{
    partial class RateOrder
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
            this.orderDeliveredLabel = new System.Windows.Forms.Label();
            this.orderIssueLabel = new System.Windows.Forms.Label();
            this.rateOrderBox = new System.Windows.Forms.ComboBox();
            this.rateOrderLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderDeliveredLabel
            // 
            this.orderDeliveredLabel.AutoSize = true;
            this.orderDeliveredLabel.BackColor = System.Drawing.Color.White;
            this.orderDeliveredLabel.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDeliveredLabel.Location = new System.Drawing.Point(274, 172);
            this.orderDeliveredLabel.Name = "orderDeliveredLabel";
            this.orderDeliveredLabel.Size = new System.Drawing.Size(448, 63);
            this.orderDeliveredLabel.TabIndex = 0;
            this.orderDeliveredLabel.Text = "Order Delivered!";
            // 
            // orderIssueLabel
            // 
            this.orderIssueLabel.AutoSize = true;
            this.orderIssueLabel.BackColor = System.Drawing.Color.White;
            this.orderIssueLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIssueLabel.Location = new System.Drawing.Point(367, 244);
            this.orderIssueLabel.Name = "orderIssueLabel";
            this.orderIssueLabel.Size = new System.Drawing.Size(273, 19);
            this.orderIssueLabel.TabIndex = 1;
            this.orderIssueLabel.Text = "Issue with order? Call 123-777-7777";
            // 
            // rateOrderBox
            // 
            this.rateOrderBox.DisplayMember = "Rate your order!";
            this.rateOrderBox.FormattingEnabled = true;
            this.rateOrderBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.rateOrderBox.Location = new System.Drawing.Point(440, 357);
            this.rateOrderBox.Name = "rateOrderBox";
            this.rateOrderBox.Size = new System.Drawing.Size(137, 24);
            this.rateOrderBox.TabIndex = 2;
            // 
            // rateOrderLabel
            // 
            this.rateOrderLabel.AutoSize = true;
            this.rateOrderLabel.BackColor = System.Drawing.Color.White;
            this.rateOrderLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateOrderLabel.Location = new System.Drawing.Point(436, 321);
            this.rateOrderLabel.Name = "rateOrderLabel";
            this.rateOrderLabel.Size = new System.Drawing.Size(141, 23);
            this.rateOrderLabel.TabIndex = 3;
            this.rateOrderLabel.Text = "Leave a rating!";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.exitButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(440, 451);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(137, 64);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // RateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TigerTakeOut.Properties.Resources.tigertakeoutbg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 563);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rateOrderLabel);
            this.Controls.Add(this.rateOrderBox);
            this.Controls.Add(this.orderIssueLabel);
            this.Controls.Add(this.orderDeliveredLabel);
            this.Name = "RateOrder";
            this.Text = "RateOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderDeliveredLabel;
        private System.Windows.Forms.Label orderIssueLabel;
        private System.Windows.Forms.ComboBox rateOrderBox;
        private System.Windows.Forms.Label rateOrderLabel;
        private System.Windows.Forms.Button exitButton;
    }
}