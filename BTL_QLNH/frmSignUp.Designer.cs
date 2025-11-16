namespace BTL_QLNH
{
    partial class frmSignUp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.btnConfirm = new ReaLTaiizor.Controls.CyberButton();
            this.btnClear = new ReaLTaiizor.Controls.CyberButton();
            this.btnBack = new ReaLTaiizor.Controls.CyberButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtFullName = new ReaLTaiizor.Controls.CyberTextBox();
            this.txtUserName = new ReaLTaiizor.Controls.CyberTextBox();
            this.txtSetPassword = new ReaLTaiizor.Controls.CyberTextBox();
            this.txtConfirmPassword = new ReaLTaiizor.Controls.CyberTextBox();
            this.txtEmail = new ReaLTaiizor.Controls.CyberTextBox();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_QLNH.Properties.Resources.create_account;
            this.pictureBox1.Location = new System.Drawing.Point(872, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 608);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.Location = new System.Drawing.Point(270, 37);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(275, 46);
            this.lblCreateAccount.TabIndex = 42;
            this.lblCreateAccount.Text = "Tạo tài khoản";
            this.lblCreateAccount.Click += new System.EventHandler(this.lblCreateAccount_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(60, 141);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(125, 31);
            this.lblFullName.TabIndex = 43;
            this.lblFullName.Text = "Họ và tên";
            // 
            // lblGender
            // 
            this.lblGender.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(64, 286);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(110, 31);
            this.lblGender.TabIndex = 44;
            this.lblGender.Text = "Giới tính";
            // 
            // lblUsername
            // 
            this.lblUsername.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(414, 141);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(188, 31);
            this.lblUsername.TabIndex = 45;
            this.lblUsername.Text = "Tên đăng nhập";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblDOB
            // 
            this.lblDOB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(414, 286);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(129, 31);
            this.lblDOB.TabIndex = 46;
            this.lblDOB.Text = "Ngày sinh";
            // 
            // lblRole
            // 
            this.lblRole.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(64, 422);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(105, 31);
            this.lblRole.TabIndex = 47;
            this.lblRole.Text = "Chức vụ";
            // 
            // lblPassword
            // 
            this.lblPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(60, 583);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(171, 31);
            this.lblPassword.TabIndex = 48;
            this.lblPassword.Text = "Đặt mật khẩu";
            // 
            // lblEmail
            // 
            this.lblEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(414, 422);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 31);
            this.lblEmail.TabIndex = 49;
            this.lblEmail.Text = "Email:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(420, 578);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(236, 31);
            this.lblConfirmPassword.TabIndex = 50;
            this.lblConfirmPassword.Text = "Xác nhận mật khẩu";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Alpha = 20;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Background = true;
            this.btnConfirm.Background_WidthPen = 4F;
            this.btnConfirm.BackgroundPen = true;
            this.btnConfirm.ColorBackground = System.Drawing.Color.Black;
            this.btnConfirm.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnConfirm.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnConfirm.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnConfirm.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnConfirm.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnConfirm.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnConfirm.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnConfirm.Effect_1 = true;
            this.btnConfirm.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnConfirm.Effect_1_Transparency = 25;
            this.btnConfirm.Effect_2 = true;
            this.btnConfirm.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnConfirm.Effect_2_Transparency = 20;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 11F);
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnConfirm.Lighting = false;
            this.btnConfirm.LinearGradient_Background = false;
            this.btnConfirm.LinearGradientPen = false;
            this.btnConfirm.Location = new System.Drawing.Point(521, 761);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.PenWidth = 15;
            this.btnConfirm.Rounding = true;
            this.btnConfirm.RoundingInt = 70;
            this.btnConfirm.Size = new System.Drawing.Size(142, 62);
            this.btnConfirm.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnConfirm.TabIndex = 51;
            this.btnConfirm.Tag = "Cyber";
            this.btnConfirm.TextButton = "Xác nhận";
            this.btnConfirm.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnConfirm.Timer_Effect_1 = 5;
            this.btnConfirm.Timer_RGB = 300;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            this.btnClear.Location = new System.Drawing.Point(282, 761);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.PenWidth = 15;
            this.btnClear.Rounding = true;
            this.btnClear.RoundingInt = 70;
            this.btnClear.Size = new System.Drawing.Size(147, 62);
            this.btnClear.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnClear.TabIndex = 52;
            this.btnClear.Tag = "Cyber";
            this.btnClear.TextButton = "Dọn";
            this.btnClear.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnClear.Timer_Effect_1 = 5;
            this.btnClear.Timer_RGB = 300;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Alpha = 20;
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
            this.btnBack.Location = new System.Drawing.Point(69, 761);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.PenWidth = 15;
            this.btnBack.Rounding = true;
            this.btnBack.RoundingInt = 70;
            this.btnBack.Size = new System.Drawing.Size(142, 62);
            this.btnBack.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnBack.TabIndex = 53;
            this.btnBack.Tag = "Cyber";
            this.btnBack.TextButton = "Quay lại";
            this.btnBack.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnBack.Timer_Effect_1 = 5;
            this.btnBack.Timer_RGB = 300;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(425, 328);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(260, 26);
            this.dtpDOB.TabIndex = 54;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.Alpha = 20;
            this.txtFullName.BackColor = System.Drawing.Color.Transparent;
            this.txtFullName.Background_WidthPen = 3F;
            this.txtFullName.BackgroundPen = true;
            this.txtFullName.ColorBackground = System.Drawing.Color.White;
            this.txtFullName.ColorBackground_Pen = System.Drawing.Color.Black;
            this.txtFullName.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtFullName.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtFullName.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.txtFullName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txtFullName.Font = new System.Drawing.Font("Arial", 13F);
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.Lighting = false;
            this.txtFullName.LinearGradientPen = false;
            this.txtFullName.Location = new System.Drawing.Point(65, 185);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PenWidth = 15;
            this.txtFullName.RGB = false;
            this.txtFullName.Rounding = true;
            this.txtFullName.RoundingInt = 60;
            this.txtFullName.Size = new System.Drawing.Size(295, 54);
            this.txtFullName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txtFullName.TabIndex = 55;
            this.txtFullName.Tag = "Cyber";
            this.txtFullName.TextButton = "";
            this.txtFullName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtFullName.Timer_RGB = 300;
            // 
            // txtUserName
            // 
            this.txtUserName.Alpha = 20;
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.Background_WidthPen = 3F;
            this.txtUserName.BackgroundPen = true;
            this.txtUserName.ColorBackground = System.Drawing.Color.White;
            this.txtUserName.ColorBackground_Pen = System.Drawing.Color.Black;
            this.txtUserName.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtUserName.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtUserName.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.txtUserName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txtUserName.Font = new System.Drawing.Font("Arial", 13F);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Lighting = false;
            this.txtUserName.LinearGradientPen = false;
            this.txtUserName.Location = new System.Drawing.Point(419, 185);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PenWidth = 15;
            this.txtUserName.RGB = false;
            this.txtUserName.Rounding = true;
            this.txtUserName.RoundingInt = 60;
            this.txtUserName.Size = new System.Drawing.Size(295, 54);
            this.txtUserName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txtUserName.TabIndex = 56;
            this.txtUserName.Tag = "Cyber";
            this.txtUserName.TextButton = "";
            this.txtUserName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtUserName.Timer_RGB = 300;
            // 
            // txtSetPassword
            // 
            this.txtSetPassword.Alpha = 20;
            this.txtSetPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtSetPassword.Background_WidthPen = 3F;
            this.txtSetPassword.BackgroundPen = true;
            this.txtSetPassword.ColorBackground = System.Drawing.Color.White;
            this.txtSetPassword.ColorBackground_Pen = System.Drawing.Color.Black;
            this.txtSetPassword.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtSetPassword.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtSetPassword.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.txtSetPassword.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txtSetPassword.Font = new System.Drawing.Font("Arial", 13F);
            this.txtSetPassword.ForeColor = System.Drawing.Color.Black;
            this.txtSetPassword.Lighting = false;
            this.txtSetPassword.LinearGradientPen = false;
            this.txtSetPassword.Location = new System.Drawing.Point(65, 638);
            this.txtSetPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSetPassword.Name = "txtSetPassword";
            this.txtSetPassword.Password = true;
            this.txtSetPassword.PenWidth = 15;
            this.txtSetPassword.RGB = false;
            this.txtSetPassword.Rounding = true;
            this.txtSetPassword.RoundingInt = 60;
            this.txtSetPassword.Size = new System.Drawing.Size(295, 54);
            this.txtSetPassword.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txtSetPassword.TabIndex = 57;
            this.txtSetPassword.Tag = "Cyber";
            this.txtSetPassword.TextButton = "";
            this.txtSetPassword.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtSetPassword.Timer_RGB = 300;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Alpha = 20;
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.Background_WidthPen = 3F;
            this.txtConfirmPassword.BackgroundPen = true;
            this.txtConfirmPassword.ColorBackground = System.Drawing.Color.White;
            this.txtConfirmPassword.ColorBackground_Pen = System.Drawing.Color.Black;
            this.txtConfirmPassword.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtConfirmPassword.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtConfirmPassword.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.txtConfirmPassword.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Arial", 13F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.Lighting = false;
            this.txtConfirmPassword.LinearGradientPen = false;
            this.txtConfirmPassword.Location = new System.Drawing.Point(419, 638);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Password = true;
            this.txtConfirmPassword.PenWidth = 15;
            this.txtConfirmPassword.RGB = false;
            this.txtConfirmPassword.Rounding = true;
            this.txtConfirmPassword.RoundingInt = 60;
            this.txtConfirmPassword.Size = new System.Drawing.Size(295, 54);
            this.txtConfirmPassword.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txtConfirmPassword.TabIndex = 58;
            this.txtConfirmPassword.Tag = "Cyber";
            this.txtConfirmPassword.TextButton = "";
            this.txtConfirmPassword.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtConfirmPassword.Timer_RGB = 300;
            // 
            // txtEmail
            // 
            this.txtEmail.Alpha = 20;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Background_WidthPen = 3F;
            this.txtEmail.BackgroundPen = true;
            this.txtEmail.ColorBackground = System.Drawing.Color.White;
            this.txtEmail.ColorBackground_Pen = System.Drawing.Color.Black;
            this.txtEmail.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtEmail.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtEmail.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.txtEmail.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Lighting = false;
            this.txtEmail.LinearGradientPen = false;
            this.txtEmail.Location = new System.Drawing.Point(419, 469);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PenWidth = 15;
            this.txtEmail.RGB = false;
            this.txtEmail.Rounding = true;
            this.txtEmail.RoundingInt = 60;
            this.txtEmail.Size = new System.Drawing.Size(295, 48);
            this.txtEmail.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txtEmail.TabIndex = 59;
            this.txtEmail.Tag = "Cyber";
            this.txtEmail.TextButton = "";
            this.txtEmail.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtEmail.Timer_RGB = 300;
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Location = new System.Drawing.Point(634, 714);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(68, 24);
            this.cbShow.TabIndex = 62;
            this.cbShow.Text = "Hiện";
            this.cbShow.UseVisualStyleBackColor = true;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbRole);
            this.panel1.Controls.Add(this.cbGender);
            this.panel1.Controls.Add(this.cbShow);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.txtSetPassword);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.dtpDOB);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.lblConfirmPassword);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.lblDOB);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.lblCreateAccount);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 878);
            this.panel1.TabIndex = 24;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(69, 491);
            this.cbRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(233, 28);
            this.cbRole.TabIndex = 84;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(69, 330);
            this.cbGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(233, 28);
            this.cbGender.TabIndex = 83;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 884);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSignUp";
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblConfirmPassword;
        private ReaLTaiizor.Controls.CyberButton btnConfirm;
        private ReaLTaiizor.Controls.CyberButton btnClear;
        private ReaLTaiizor.Controls.CyberButton btnBack;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private ReaLTaiizor.Controls.CyberTextBox txtFullName;
        private ReaLTaiizor.Controls.CyberTextBox txtUserName;
        private ReaLTaiizor.Controls.CyberTextBox txtSetPassword;
        private ReaLTaiizor.Controls.CyberTextBox txtConfirmPassword;
        private ReaLTaiizor.Controls.CyberTextBox txtEmail;
        private System.Windows.Forms.CheckBox cbShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.ComboBox cbGender;
    }
}