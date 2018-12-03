namespace TigerTakeOut
{
    partial class checkout
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
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.graybackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graybackground)).BeginInit();
            this.SuspendLayout();
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.BackColor = System.Drawing.Color.Transparent;
            this.shoppingCartLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartLabel.ForeColor = System.Drawing.Color.Black;
            this.shoppingCartLabel.Location = new System.Drawing.Point(231, 196);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(353, 56);
            this.shoppingCartLabel.TabIndex = 0;
            this.shoppingCartLabel.Text = "Shopping Cart";
            // 
            // graybackground
            // 
            this.graybackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.graybackground.Location = new System.Drawing.Point(241, 269);
            this.graybackground.Name = "graybackground";
            this.graybackground.Size = new System.Drawing.Size(1090, 550);
            this.graybackground.TabIndex = 1;
            this.graybackground.TabStop = false;
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TigerTakeOut.Properties.Resources.tigertakeoutbg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.graybackground);
            this.Controls.Add(this.shoppingCartLabel);
            this.Name = "checkout";
            this.Text = "Check Out";
            ((System.ComponentModel.ISupportInitialize)(this.graybackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label shoppingCartLabel;
        private System.Windows.Forms.PictureBox graybackground;
    }
}

