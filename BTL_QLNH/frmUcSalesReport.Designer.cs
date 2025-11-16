namespace BTL_QLNH
{
    partial class frmUcSalesReport
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
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new ReaLTaiizor.Controls.CyberButton();
            this.btnClear = new ReaLTaiizor.Controls.CyberButton();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblTK = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExcel = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalesReport
            // 
            this.lblSalesReport.AutoSize = true;
            this.lblSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReport.Location = new System.Drawing.Point(561, 32);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(490, 59);
            this.lblSalesReport.TabIndex = 35;
            this.lblSalesReport.Text = "Báo Cáo Bán Hàng";
            // 
            // dgvSales
            // 
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(98, 588);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 92;
            this.dgvSales.RowTemplate.Height = 37;
            this.dgvSales.Size = new System.Drawing.Size(1306, 355);
            this.dgvSales.TabIndex = 52;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Alpha = 20;
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.Background = true;
            this.btnGenerate.Background_WidthPen = 4F;
            this.btnGenerate.BackgroundPen = true;
            this.btnGenerate.ColorBackground = System.Drawing.Color.Black;
            this.btnGenerate.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnGenerate.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnGenerate.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnGenerate.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnGenerate.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnGenerate.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnGenerate.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnGenerate.Effect_1 = true;
            this.btnGenerate.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnGenerate.Effect_1_Transparency = 25;
            this.btnGenerate.Effect_2 = true;
            this.btnGenerate.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnGenerate.Effect_2_Transparency = 20;
            this.btnGenerate.Font = new System.Drawing.Font("Arial", 11F);
            this.btnGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnGenerate.Lighting = false;
            this.btnGenerate.LinearGradient_Background = false;
            this.btnGenerate.LinearGradientPen = false;
            this.btnGenerate.Location = new System.Drawing.Point(995, 519);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.PenWidth = 15;
            this.btnGenerate.Rounding = true;
            this.btnGenerate.RoundingInt = 70;
            this.btnGenerate.Size = new System.Drawing.Size(142, 51);
            this.btnGenerate.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnGenerate.TabIndex = 74;
            this.btnGenerate.Tag = "Cyber";
            this.btnGenerate.TextButton = "Tạo";
            this.btnGenerate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnGenerate.Timer_Effect_1 = 5;
            this.btnGenerate.Timer_RGB = 300;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click_1);
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
            this.btnClear.Location = new System.Drawing.Point(720, 519);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.PenWidth = 15;
            this.btnClear.Rounding = true;
            this.btnClear.RoundingInt = 70;
            this.btnClear.Size = new System.Drawing.Size(142, 51);
            this.btnClear.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnClear.TabIndex = 73;
            this.btnClear.Tag = "Cyber";
            this.btnClear.TextButton = "Dọn";
            this.btnClear.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnClear.Timer_Effect_1 = 5;
            this.btnClear.Timer_RGB = 300;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Black;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(1276, 1012);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(63, 29);
            this.lblMoney.TabIndex = 77;
            this.lblMoney.Text = "VND";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblTotalSales.Location = new System.Drawing.Point(1243, 960);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(162, 25);
            this.lblTotalSales.TabIndex = 76;
            this.lblTotalSales.Text = "Tổng Bán Hàng";
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.BackColor = System.Drawing.Color.Black;
            this.lblTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.ForeColor = System.Drawing.Color.White;
            this.lblTK.Location = new System.Drawing.Point(1335, 1012);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(45, 29);
            this.lblTK.TabIndex = 75;
            this.lblTK.Text = "0.0";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblEndDate.Location = new System.Drawing.Point(1144, 252);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(154, 25);
            this.lblEndDate.TabIndex = 79;
            this.lblEndDate.Text = "Ngày Kết Thúc";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblStartDate.Location = new System.Drawing.Point(748, 252);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(145, 25);
            this.lblStartDate.TabIndex = 78;
            this.lblStartDate.Text = "Ngày Bắt Đầu";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(752, 328);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(286, 26);
            this.dtpStartDate.TabIndex = 84;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(1148, 328);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(281, 26);
            this.dtpEndDate.TabIndex = 85;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_QLNH.Properties.Resources.Sales_Report_Vector_Illustration_;
            this.pictureBox1.Location = new System.Drawing.Point(53, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Alpha = 20;
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.Background = true;
            this.btnExcel.Background_WidthPen = 4F;
            this.btnExcel.BackgroundPen = true;
            this.btnExcel.ColorBackground = System.Drawing.Color.Black;
            this.btnExcel.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnExcel.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnExcel.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnExcel.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnExcel.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnExcel.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnExcel.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnExcel.Effect_1 = true;
            this.btnExcel.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnExcel.Effect_1_Transparency = 25;
            this.btnExcel.Effect_2 = true;
            this.btnExcel.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnExcel.Effect_2_Transparency = 20;
            this.btnExcel.Font = new System.Drawing.Font("Arial", 11F);
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnExcel.Lighting = false;
            this.btnExcel.LinearGradient_Background = false;
            this.btnExcel.LinearGradientPen = false;
            this.btnExcel.Location = new System.Drawing.Point(1210, 519);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.PenWidth = 15;
            this.btnExcel.Rounding = true;
            this.btnExcel.RoundingInt = 70;
            this.btnExcel.Size = new System.Drawing.Size(195, 51);
            this.btnExcel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnExcel.TabIndex = 86;
            this.btnExcel.Tag = "Cyber";
            this.btnExcel.TextButton = "Xuất ra Excel";
            this.btnExcel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnExcel.Timer_Effect_1 = 5;
            this.btnExcel.Timer_RGB = 300;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmUcSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.lblTK);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSalesReport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUcSalesReport";
            this.Size = new System.Drawing.Size(1549, 1115);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalesReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSales;
        private ReaLTaiizor.Controls.CyberButton btnGenerate;
        private ReaLTaiizor.Controls.CyberButton btnClear;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private ReaLTaiizor.Controls.CyberButton btnExcel;
    }
}
