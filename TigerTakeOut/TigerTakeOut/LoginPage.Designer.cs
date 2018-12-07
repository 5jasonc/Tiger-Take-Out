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
            ((System.ComponentModel.ISupportInitialize)(this.loginBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBackground
            // 
            this.loginBackground.Image = ((System.Drawing.Image)(resources.GetObject("loginBackground.Image")));
            this.loginBackground.Location = new System.Drawing.Point(-10, 1);
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
            this.usernamelabel.Location = new System.Drawing.Point(511, 406);
            this.usernamelabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Padding = new System.Windows.Forms.Padding(10);
            this.usernamelabel.Size = new System.Drawing.Size(133, 51);
            this.usernamelabel.TabIndex = 1;
            this.usernamelabel.Text = "Username";
            this.usernamelabel.UseCompatibleTextRendering = true;
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.Location = new System.Drawing.Point(517, 501);
            this.passlabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.passlabel.Name = "passlabel";
            this.passlabel.Padding = new System.Windows.Forms.Padding(10);
            this.passlabel.Size = new System.Drawing.Size(124, 44);
            this.passlabel.TabIndex = 2;
            this.passlabel.Text = "Password";
            this.passlabel.Click += new System.EventHandler(this.passlabel_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.loginbutton.Location = new System.Drawing.Point(763, 598);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 36);
            this.loginbutton.TabIndex = 3;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.passlabel_Click);
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(693, 415);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(421, 20);
            this.userText.TabIndex = 4;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(696, 512);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(421, 20);
            this.passText.TabIndex = 5;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.loginBackground);
            this.Name = "LoginPage";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.loginBackground)).EndInit();
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
    }
}