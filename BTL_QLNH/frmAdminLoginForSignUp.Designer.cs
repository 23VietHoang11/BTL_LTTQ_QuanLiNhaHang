namespace BTL_QLNH
{
    partial class frmAdminLoginForSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminLoginForSignUp));
            this.lblOnlyAdmin = new System.Windows.Forms.Label();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new ReaLTaiizor.Controls.CyberTextBox();
            this.txtUsername = new ReaLTaiizor.Controls.CyberTextBox();
            this.btnClear = new ReaLTaiizor.Controls.CyberButton();
            this.btnSignIn = new ReaLTaiizor.Controls.CyberButton();
            this.btnBack = new ReaLTaiizor.Controls.CyberButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOnlyAdmin
            // 
            this.lblOnlyAdmin.AutoSize = true;
            this.lblOnlyAdmin.BackColor = System.Drawing.Color.Black;
            this.lblOnlyAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnlyAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOnlyAdmin.Location = new System.Drawing.Point(205, 1017);
            this.lblOnlyAdmin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOnlyAdmin.Name = "lblOnlyAdmin";
            this.lblOnlyAdmin.Size = new System.Drawing.Size(755, 40);
            this.lblOnlyAdmin.TabIndex = 26;
            this.lblOnlyAdmin.Text = "Only admin can create account for other users";
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.Location = new System.Drawing.Point(1611, 175);
            this.lblLogIn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(425, 89);
            this.lblLogIn.TabIndex = 27;
            this.lblLogIn.Text = "Đăng nhập";
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Location = new System.Drawing.Point(1985, 702);
            this.cbShow.Margin = new System.Windows.Forms.Padding(5);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(95, 33);
            this.cbShow.TabIndex = 34;
            this.cbShow.Text = "Hiện";
            this.cbShow.UseVisualStyleBackColor = true;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(1580, 544);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(192, 46);
            this.lblPassword.TabIndex = 33;
            this.lblPassword.Text = "Mật Khẩu";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(1580, 356);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(294, 46);
            this.lblUsername.TabIndex = 32;
            this.lblUsername.Text = "Tên Đăng Nhập";
            // 
            // txtPassword
            // 
            this.txtPassword.Alpha = 20;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.Background_WidthPen = 3F;
            this.txtPassword.BackgroundPen = true;
            this.txtPassword.ColorBackground = System.Drawing.Color.White;
            this.txtPassword.ColorBackground_Pen = System.Drawing.Color.Black;
            this.txtPassword.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtPassword.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtPassword.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.txtPassword.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 21F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Lighting = false;
            this.txtPassword.LinearGradientPen = false;
            this.txtPassword.Location = new System.Drawing.Point(1566, 593);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.PenWidth = 15;
            this.txtPassword.RGB = false;
            this.txtPassword.Rounding = true;
            this.txtPassword.RoundingInt = 60;
            this.txtPassword.Size = new System.Drawing.Size(525, 86);
            this.txtPassword.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txtPassword.TabIndex = 29;
            this.txtPassword.Tag = "Cyber";
            this.txtPassword.TextButton = "";
            this.txtPassword.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtPassword.Timer_RGB = 300;
            // 
            // txtUsername
            // 
            this.txtUsername.Alpha = 20;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.Background_WidthPen = 3F;
            this.txtUsername.BackgroundPen = true;
            this.txtUsername.ColorBackground = System.Drawing.Color.White;
            this.txtUsername.ColorBackground_Pen = System.Drawing.Color.Black;
            this.txtUsername.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtUsername.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtUsername.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.txtUsername.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 21F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Lighting = false;
            this.txtUsername.LinearGradientPen = false;
            this.txtUsername.Location = new System.Drawing.Point(1566, 405);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PenWidth = 15;
            this.txtUsername.RGB = false;
            this.txtUsername.Rounding = true;
            this.txtUsername.RoundingInt = 60;
            this.txtUsername.Size = new System.Drawing.Size(525, 86);
            this.txtUsername.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txtUsername.TabIndex = 28;
            this.txtUsername.Tag = "Cyber";
            this.txtUsername.TextButton = "";
            this.txtUsername.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtUsername.Timer_RGB = 300;
            // 
            // btnClear
            // 
            this.btnClear.Alpha = 20;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Background = true;
            this.btnClear.Background_WidthPen = 4F;
            this.btnClear.BackgroundPen = true;
            this.btnClear.ColorBackground = System.Drawing.Color.Black;
            this.btnClear.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnClear.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnClear.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnClear.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnClear.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnClear.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnClear.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnClear.Effect_1 = true;
            this.btnClear.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnClear.Effect_1_Transparency = 25;
            this.btnClear.Effect_2 = true;
            this.btnClear.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnClear.Effect_2_Transparency = 20;
            this.btnClear.Font = new System.Drawing.Font("Arial", 11F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnClear.Lighting = false;
            this.btnClear.LinearGradient_Background = false;
            this.btnClear.LinearGradientPen = false;
            this.btnClear.Location = new System.Drawing.Point(1942, 826);
            this.btnClear.Name = "btnClear";
            this.btnClear.PenWidth = 15;
            this.btnClear.Rounding = true;
            this.btnClear.RoundingInt = 70;
            this.btnClear.Size = new System.Drawing.Size(229, 90);
            this.btnClear.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnClear.TabIndex = 36;
            this.btnClear.Tag = "Cyber";
            this.btnClear.TextButton = "Clear";
            this.btnClear.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnClear.Timer_Effect_1 = 5;
            this.btnClear.Timer_RGB = 300;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Alpha = 20;
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.Background = true;
            this.btnSignIn.Background_WidthPen = 4F;
            this.btnSignIn.BackgroundPen = true;
            this.btnSignIn.ColorBackground = System.Drawing.Color.Black;
            this.btnSignIn.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnSignIn.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnSignIn.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnSignIn.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnSignIn.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnSignIn.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnSignIn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnSignIn.Effect_1 = true;
            this.btnSignIn.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnSignIn.Effect_1_Transparency = 25;
            this.btnSignIn.Effect_2 = true;
            this.btnSignIn.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnSignIn.Effect_2_Transparency = 20;
            this.btnSignIn.Font = new System.Drawing.Font("Arial", 11F);
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnSignIn.Lighting = false;
            this.btnSignIn.LinearGradient_Background = false;
            this.btnSignIn.LinearGradientPen = false;
            this.btnSignIn.Location = new System.Drawing.Point(1668, 826);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.PenWidth = 15;
            this.btnSignIn.Rounding = true;
            this.btnSignIn.RoundingInt = 70;
            this.btnSignIn.Size = new System.Drawing.Size(221, 90);
            this.btnSignIn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSignIn.TabIndex = 35;
            this.btnSignIn.Tag = "Cyber";
            this.btnSignIn.TextButton = "Đăng nhập";
            this.btnSignIn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSignIn.Timer_Effect_1 = 5;
            this.btnSignIn.Timer_RGB = 300;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnBack
            // 
            this.btnBack.Alpha = 20;
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Background = true;
            this.btnBack.Background_WidthPen = 4F;
            this.btnBack.BackgroundPen = true;
            this.btnBack.ColorBackground = System.Drawing.Color.Black;
            this.btnBack.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnBack.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnBack.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnBack.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnBack.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnBack.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnBack.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnBack.Effect_1 = true;
            this.btnBack.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnBack.Effect_1_Transparency = 25;
            this.btnBack.Effect_2 = true;
            this.btnBack.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnBack.Effect_2_Transparency = 20;
            this.btnBack.Font = new System.Drawing.Font("Arial", 11F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnBack.Lighting = false;
            this.btnBack.LinearGradient_Background = false;
            this.btnBack.LinearGradientPen = false;
            this.btnBack.Location = new System.Drawing.Point(1381, 826);
            this.btnBack.Name = "btnBack";
            this.btnBack.PenWidth = 15;
            this.btnBack.Rounding = true;
            this.btnBack.RoundingInt = 70;
            this.btnBack.Size = new System.Drawing.Size(221, 90);
            this.btnBack.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnBack.TabIndex = 37;
            this.btnBack.Tag = "Cyber";
            this.btnBack.TextButton = "Quay lại";
            this.btnBack.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnBack.Timer_Effect_1 = 5;
            this.btnBack.Timer_RGB = 300;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1439, 603);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1439, 419);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_QLNH.Properties.Resources.Login_page_character1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1189, 969);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdminLoginForSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2309, 1114);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.cbShow);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblLogIn);
            this.Controls.Add(this.lblOnlyAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAdminLoginForSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminLoginForSignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOnlyAdmin;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.CheckBox cbShow;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.CyberTextBox txtPassword;
        private ReaLTaiizor.Controls.CyberTextBox txtUsername;
        private ReaLTaiizor.Controls.CyberButton btnClear;
        private ReaLTaiizor.Controls.CyberButton btnSignIn;
        private ReaLTaiizor.Controls.CyberButton btnBack;
    }
}