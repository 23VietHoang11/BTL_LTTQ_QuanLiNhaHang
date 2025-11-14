namespace BTL_QLNH
{
    partial class frmUcUsersInfoManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShow = new ReaLTaiizor.Controls.CyberButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvUpdate = new System.Windows.Forms.DataGridView();
            this.lblUpdateUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Alpha = 20;
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.Background = true;
            this.btnShow.Background_WidthPen = 4F;
            this.btnShow.BackgroundPen = true;
            this.btnShow.ColorBackground = System.Drawing.Color.Black;
            this.btnShow.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnShow.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnShow.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnShow.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnShow.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnShow.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnShow.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnShow.Effect_1 = true;
            this.btnShow.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnShow.Effect_1_Transparency = 25;
            this.btnShow.Effect_2 = true;
            this.btnShow.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnShow.Effect_2_Transparency = 20;
            this.btnShow.Font = new System.Drawing.Font("Arial", 11F);
            this.btnShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnShow.Lighting = false;
            this.btnShow.LinearGradient_Background = false;
            this.btnShow.LinearGradientPen = false;
            this.btnShow.Location = new System.Drawing.Point(1996, 834);
            this.btnShow.Name = "btnShow";
            this.btnShow.PenWidth = 15;
            this.btnShow.Rounding = true;
            this.btnShow.RoundingInt = 70;
            this.btnShow.Size = new System.Drawing.Size(221, 54);
            this.btnShow.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnShow.TabIndex = 90;
            this.btnShow.Tag = "Cyber";
            this.btnShow.TextButton = "Tải lại";
            this.btnShow.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnShow.Timer_Effect_1 = 5;
            this.btnShow.Timer_RGB = 300;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSearch.Location = new System.Drawing.Point(196, 834);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(413, 61);
            this.txtSearch.TabIndex = 88;
            // 
            // dgvUpdate
            // 
            this.dgvUpdate.BackgroundColor = System.Drawing.Color.White;
            this.dgvUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdate.Location = new System.Drawing.Point(196, 926);
            this.dgvUpdate.Name = "dgvUpdate";
            this.dgvUpdate.RowHeadersWidth = 92;
            this.dgvUpdate.RowTemplate.Height = 37;
            this.dgvUpdate.Size = new System.Drawing.Size(2032, 515);
            this.dgvUpdate.TabIndex = 87;
            // 
            // lblUpdateUser
            // 
            this.lblUpdateUser.AutoSize = true;
            this.lblUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateUser.Location = new System.Drawing.Point(970, 46);
            this.lblUpdateUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUpdateUser.Name = "lblUpdateUser";
            this.lblUpdateUser.Size = new System.Drawing.Size(684, 89);
            this.lblUpdateUser.TabIndex = 86;
            this.lblUpdateUser.Text = "User\'s Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_QLNH.Properties.Resources.usersUpdate;
            this.pictureBox1.Location = new System.Drawing.Point(196, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 590);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // frmUcUsersInfoManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvUpdate);
            this.Controls.Add(this.lblUpdateUser);
            this.Name = "frmUcUsersInfoManager";
            this.Size = new System.Drawing.Size(2424, 1473);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton btnShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvUpdate;
        private System.Windows.Forms.Label lblUpdateUser;
    }
}
