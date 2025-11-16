namespace BTL_QLNH
{
    partial class frmUcAdd
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
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtFoodId = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblFoodId = new System.Windows.Forms.Label();
            this.btnAdd = new ReaLTaiizor.Controls.CyberButton();
            this.btnShow = new ReaLTaiizor.Controls.CyberButton();
            this.btnClear = new ReaLTaiizor.Controls.CyberButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddFood = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(1122, 492);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(360, 37);
            this.cmbCategory.TabIndex = 95;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPrice.Location = new System.Drawing.Point(1568, 478);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(339, 61);
            this.txtPrice.TabIndex = 94;
            // 
            // txtFoodName
            // 
            this.txtFoodName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFoodName.Location = new System.Drawing.Point(1568, 309);
            this.txtFoodName.Multiline = true;
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(339, 61);
            this.txtFoodName.TabIndex = 93;
            // 
            // txtFoodId
            // 
            this.txtFoodId.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFoodId.Location = new System.Drawing.Point(1122, 309);
            this.txtFoodId.Multiline = true;
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.Size = new System.Drawing.Size(360, 61);
            this.txtFoodId.TabIndex = 92;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(1562, 412);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(72, 35);
            this.lblPrice.TabIndex = 91;
            this.lblPrice.Text = "Giá:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(1116, 412);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(82, 35);
            this.lblCategory.TabIndex = 90;
            this.lblCategory.Text = "Loại:";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.Location = new System.Drawing.Point(1562, 254);
            this.lblFoodName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(144, 35);
            this.lblFoodName.TabIndex = 89;
            this.lblFoodName.Text = "Tên món:";
            // 
            // lblFoodId
            // 
            this.lblFoodId.AutoSize = true;
            this.lblFoodId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodId.Location = new System.Drawing.Point(1116, 254);
            this.lblFoodId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFoodId.Name = "lblFoodId";
            this.lblFoodId.Size = new System.Drawing.Size(40, 35);
            this.lblFoodId.TabIndex = 88;
            this.lblFoodId.Text = "Id";
            // 
            // btnAdd
            // 
            this.btnAdd.Alpha = 20;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Background = true;
            this.btnAdd.Background_WidthPen = 4F;
            this.btnAdd.BackgroundPen = true;
            this.btnAdd.ColorBackground = System.Drawing.Color.Black;
            this.btnAdd.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnAdd.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnAdd.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnAdd.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnAdd.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnAdd.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnAdd.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnAdd.Effect_1 = true;
            this.btnAdd.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnAdd.Effect_1_Transparency = 25;
            this.btnAdd.Effect_2 = true;
            this.btnAdd.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnAdd.Effect_2_Transparency = 20;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 11F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnAdd.Lighting = false;
            this.btnAdd.LinearGradient_Background = false;
            this.btnAdd.LinearGradientPen = false;
            this.btnAdd.Location = new System.Drawing.Point(2039, 455);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PenWidth = 15;
            this.btnAdd.Rounding = true;
            this.btnAdd.RoundingInt = 70;
            this.btnAdd.Size = new System.Drawing.Size(221, 74);
            this.btnAdd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnAdd.TabIndex = 87;
            this.btnAdd.Tag = "Cyber";
            this.btnAdd.TextButton = "Thêm";
            this.btnAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAdd.Timer_Effect_1 = 5;
            this.btnAdd.Timer_RGB = 300;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
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
            this.btnShow.Location = new System.Drawing.Point(2039, 762);
            this.btnShow.Name = "btnShow";
            this.btnShow.PenWidth = 15;
            this.btnShow.Rounding = true;
            this.btnShow.RoundingInt = 70;
            this.btnShow.Size = new System.Drawing.Size(221, 54);
            this.btnShow.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnShow.TabIndex = 86;
            this.btnShow.Tag = "Cyber";
            this.btnShow.TextButton = "Tải lại";
            this.btnShow.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnShow.Timer_Effect_1 = 5;
            this.btnShow.Timer_RGB = 300;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
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
            this.btnClear.Location = new System.Drawing.Point(2039, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.PenWidth = 15;
            this.btnClear.Rounding = true;
            this.btnClear.RoundingInt = 70;
            this.btnClear.Size = new System.Drawing.Size(221, 74);
            this.btnClear.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnClear.TabIndex = 85;
            this.btnClear.Tag = "Cyber";
            this.btnClear.TextButton = "Clear";
            this.btnClear.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnClear.Timer_Effect_1 = 5;
            this.btnClear.Timer_RGB = 300;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_QLNH.Properties.Resources.fast_food_illustration_512x368_owd7wme9;
            this.pictureBox1.Location = new System.Drawing.Point(228, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // lblAddFood
            // 
            this.lblAddFood.AutoSize = true;
            this.lblAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddFood.Location = new System.Drawing.Point(1129, 72);
            this.lblAddFood.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddFood.Name = "lblAddFood";
            this.lblAddFood.Size = new System.Drawing.Size(527, 89);
            this.lblAddFood.TabIndex = 83;
            this.lblAddFood.Text = "Thêm món ăn";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSearch.Location = new System.Drawing.Point(228, 762);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(413, 61);
            this.txtSearch.TabIndex = 82;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // dgvAdd
            // 
            this.dgvAdd.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdd.Location = new System.Drawing.Point(228, 854);
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.RowHeadersWidth = 92;
            this.dgvAdd.RowTemplate.Height = 37;
            this.dgvAdd.Size = new System.Drawing.Size(2032, 515);
            this.dgvAdd.TabIndex = 81;
            // 
            // frmUcAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.txtFoodId);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblFoodName);
            this.Controls.Add(this.lblFoodId);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAddFood);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvAdd);
            this.Name = "frmUcAdd";
            this.Size = new System.Drawing.Size(2489, 1441);
            this.Load += new System.EventHandler(this.frmUcAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtFoodId;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblFoodId;
        private ReaLTaiizor.Controls.CyberButton btnAdd;
        private ReaLTaiizor.Controls.CyberButton btnShow;
        private ReaLTaiizor.Controls.CyberButton btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddFood;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvAdd;
    }
}
