namespace TigerTakeOut
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.loginBackground = new System.Windows.Forms.PictureBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.userText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.RITlogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RITlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBackground
            // 
            this.loginBackground.Image = ((System.Drawing.Image)(resources.GetObject("loginBackground.Image")));
            this.loginBackground.Location = new System.Drawing.Point(0, 0);
            this.loginBackground.Name = "loginBackground";
            this.loginBackground.Size = new System.Drawing.Size(1600, 900);
            this.loginBackground.TabIndex = 0;
            this.loginBackground.TabStop = false;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.BackColor = System.Drawing.Color.White;
            this.usernamelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernamelabel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.usernamelabel.Location = new System.Drawing.Point(497, 441);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(113, 31);
            this.usernamelabel.TabIndex = 1;
            this.usernamelabel.Text = "Username";
            this.usernamelabel.UseCompatibleTextRendering = true;
            this.usernamelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.Location = new System.Drawing.Point(506, 533);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(104, 24);
            this.passlabel.TabIndex = 2;
            this.passlabel.Text = "Password";
            this.passlabel.Click += new System.EventHandler(this.passlabel_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.loginbutton.Location = new System.Drawing.Point(726, 611);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 36);
            this.loginbutton.TabIndex = 3;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(672, 441);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(421, 20);
            this.userText.TabIndex = 4;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(672, 530);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(421, 20);
            this.passText.TabIndex = 5;
            // 
            // RITlogo
            // 
            this.RITlogo.BackColor = System.Drawing.Color.Transparent;
            this.RITlogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("RITlogo.InitialImage")));
            this.RITlogo.Location = new System.Drawing.Point(609, 217);
            this.RITlogo.Name = "RITlogo";
            this.RITlogo.Size = new System.Drawing.Size(400, 150);
            this.RITlogo.TabIndex = 6;
            this.RITlogo.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.RITlogo);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.loginBackground);
            this.Name = "LoginPage";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.loginBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RITlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox loginBackground;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.PictureBox RITlogo;
    }
}