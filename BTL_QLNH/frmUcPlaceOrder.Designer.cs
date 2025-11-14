namespace BTL_QLNH
{
    partial class frmUcPlaceOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPlaceOrder = new System.Windows.Forms.DataGridView();
            this.btnPrint = new ReaLTaiizor.Controls.CyberButton();
            this.btnRemove = new ReaLTaiizor.Controls.CyberButton();
            this.btnConfirm = new ReaLTaiizor.Controls.CyberButton();
            this.btnAddToCart = new ReaLTaiizor.Controls.CyberButton();
            this.btnClear = new ReaLTaiizor.Controls.CyberButton();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTK = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPlaceOrder = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaceOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2412, 1455);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPlaceOrder);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Controls.Add(this.btnAddToCart);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.nudQuantity);
            this.panel3.Controls.Add(this.dtpOrderDate);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.txtItemName);
            this.panel3.Controls.Add(this.txtCustomerName);
            this.panel3.Controls.Add(this.txtOrderId);
            this.panel3.Controls.Add(this.lblMoney);
            this.panel3.Controls.Add(this.lblCustomerName);
            this.panel3.Controls.Add(this.lblGrandTotal);
            this.panel3.Controls.Add(this.lblTK);
            this.panel3.Controls.Add(this.lblOrderDate);
            this.panel3.Controls.Add(this.lblOrderId);
            this.panel3.Controls.Add(this.lblItemName);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.lblPrice);
            this.panel3.Controls.Add(this.lblQuantity);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(763, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1649, 1455);
            this.panel3.TabIndex = 1;
            // 
            // dgvPlaceOrder
            // 
            this.dgvPlaceOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlaceOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlaceOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaceOrder.EnableHeadersVisualStyles = false;
            this.dgvPlaceOrder.Location = new System.Drawing.Point(292, 855);
            this.dgvPlaceOrder.Name = "dgvPlaceOrder";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlaceOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlaceOrder.RowHeadersVisible = false;
            this.dgvPlaceOrder.RowHeadersWidth = 92;
            this.dgvPlaceOrder.RowTemplate.Height = 37;
            this.dgvPlaceOrder.Size = new System.Drawing.Size(1133, 391);
            this.dgvPlaceOrder.TabIndex = 90;
            this.dgvPlaceOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlaceOrder_CellClick_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Alpha = 20;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.Background = true;
            this.btnPrint.Background_WidthPen = 4F;
            this.btnPrint.BackgroundPen = true;
            this.btnPrint.ColorBackground = System.Drawing.Color.Black;
            this.btnPrint.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnPrint.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnPrint.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnPrint.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnPrint.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnPrint.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnPrint.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnPrint.Effect_1 = true;
            this.btnPrint.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnPrint.Effect_1_Transparency = 25;
            this.btnPrint.Effect_2 = true;
            this.btnPrint.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnPrint.Effect_2_Transparency = 20;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 11F);
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnPrint.Lighting = false;
            this.btnPrint.LinearGradient_Background = false;
            this.btnPrint.LinearGradientPen = false;
            this.btnPrint.Location = new System.Drawing.Point(1204, 1314);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PenWidth = 15;
            this.btnPrint.Rounding = true;
            this.btnPrint.RoundingInt = 70;
            this.btnPrint.Size = new System.Drawing.Size(221, 74);
            this.btnPrint.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPrint.TabIndex = 89;
            this.btnPrint.Tag = "Cyber";
            this.btnPrint.TextButton = "In";
            this.btnPrint.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnPrint.Timer_Effect_1 = 5;
            this.btnPrint.Timer_RGB = 300;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Alpha = 20;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Background = true;
            this.btnRemove.Background_WidthPen = 4F;
            this.btnRemove.BackgroundPen = true;
            this.btnRemove.ColorBackground = System.Drawing.Color.Black;
            this.btnRemove.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnRemove.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnRemove.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnRemove.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnRemove.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnRemove.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnRemove.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnRemove.Effect_1 = true;
            this.btnRemove.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnRemove.Effect_1_Transparency = 25;
            this.btnRemove.Effect_2 = true;
            this.btnRemove.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnRemove.Effect_2_Transparency = 20;
            this.btnRemove.Font = new System.Drawing.Font("Arial", 11F);
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnRemove.Lighting = false;
            this.btnRemove.LinearGradient_Background = false;
            this.btnRemove.LinearGradientPen = false;
            this.btnRemove.Location = new System.Drawing.Point(302, 1314);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.PenWidth = 15;
            this.btnRemove.Rounding = true;
            this.btnRemove.RoundingInt = 70;
            this.btnRemove.Size = new System.Drawing.Size(221, 74);
            this.btnRemove.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnRemove.TabIndex = 88;
            this.btnRemove.Tag = "Cyber";
            this.btnRemove.TextButton = "Bỏ";
            this.btnRemove.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnRemove.Timer_Effect_1 = 5;
            this.btnRemove.Timer_RGB = 300;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
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
            this.btnConfirm.Location = new System.Drawing.Point(1120, 660);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.PenWidth = 15;
            this.btnConfirm.Rounding = true;
            this.btnConfirm.RoundingInt = 70;
            this.btnConfirm.Size = new System.Drawing.Size(305, 74);
            this.btnConfirm.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnConfirm.TabIndex = 87;
            this.btnConfirm.Tag = "Cyber";
            this.btnConfirm.TextButton = "Xác nhận";
            this.btnConfirm.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnConfirm.Timer_Effect_1 = 5;
            this.btnConfirm.Timer_RGB = 300;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click_1);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Alpha = 20;
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.Background = true;
            this.btnAddToCart.Background_WidthPen = 4F;
            this.btnAddToCart.BackgroundPen = true;
            this.btnAddToCart.ColorBackground = System.Drawing.Color.Black;
            this.btnAddToCart.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnAddToCart.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnAddToCart.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnAddToCart.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnAddToCart.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnAddToCart.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnAddToCart.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnAddToCart.Effect_1 = true;
            this.btnAddToCart.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnAddToCart.Effect_1_Transparency = 25;
            this.btnAddToCart.Effect_2 = true;
            this.btnAddToCart.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnAddToCart.Effect_2_Transparency = 20;
            this.btnAddToCart.Font = new System.Drawing.Font("Arial", 11F);
            this.btnAddToCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnAddToCart.Lighting = false;
            this.btnAddToCart.LinearGradient_Background = false;
            this.btnAddToCart.LinearGradientPen = false;
            this.btnAddToCart.Location = new System.Drawing.Point(1120, 535);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.PenWidth = 15;
            this.btnAddToCart.Rounding = true;
            this.btnAddToCart.RoundingInt = 70;
            this.btnAddToCart.Size = new System.Drawing.Size(305, 74);
            this.btnAddToCart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnAddToCart.TabIndex = 86;
            this.btnAddToCart.Tag = "Cyber";
            this.btnAddToCart.TextButton = "Thêm vào giỏ";
            this.btnAddToCart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAddToCart.Timer_Effect_1 = 5;
            this.btnAddToCart.Timer_RGB = 300;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click_1);
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
            this.btnClear.Location = new System.Drawing.Point(292, 660);
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
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(292, 554);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(166, 35);
            this.nudQuantity.TabIndex = 84;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged_1);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(1065, 123);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(403, 35);
            this.dtpOrderDate.TabIndex = 83;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTotal.Location = new System.Drawing.Point(1065, 404);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(360, 61);
            this.txtTotal.TabIndex = 82;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPrice.Location = new System.Drawing.Point(1065, 253);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(360, 61);
            this.txtPrice.TabIndex = 81;
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtItemName.Location = new System.Drawing.Point(292, 404);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(360, 61);
            this.txtItemName.TabIndex = 80;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCustomerName.Location = new System.Drawing.Point(292, 265);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(360, 61);
            this.txtCustomerName.TabIndex = 79;
            // 
            // txtOrderId
            // 
            this.txtOrderId.BackColor = System.Drawing.SystemColors.Menu;
            this.txtOrderId.Location = new System.Drawing.Point(292, 125);
            this.txtOrderId.Multiline = true;
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(360, 61);
            this.txtOrderId.TabIndex = 78;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Black;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(762, 1348);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(93, 40);
            this.lblMoney.TabIndex = 34;
            this.lblMoney.Text = "VND";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblCustomerName.Location = new System.Drawing.Point(286, 199);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(237, 35);
            this.lblCustomerName.TabIndex = 38;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblGrandTotal.Location = new System.Drawing.Point(748, 1277);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(177, 35);
            this.lblGrandTotal.TabIndex = 33;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.BackColor = System.Drawing.Color.Black;
            this.lblTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.ForeColor = System.Drawing.Color.White;
            this.lblTK.Location = new System.Drawing.Point(853, 1348);
            this.lblTK.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(67, 40);
            this.lblTK.TabIndex = 32;
            this.lblTK.Text = "0.0";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblOrderDate.Location = new System.Drawing.Point(1059, 67);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(166, 35);
            this.lblOrderDate.TabIndex = 37;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblOrderId.Location = new System.Drawing.Point(286, 67);
            this.lblOrderId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(131, 35);
            this.lblOrderId.TabIndex = 36;
            this.lblOrderId.Text = "Order ID";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblItemName.Location = new System.Drawing.Point(286, 348);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(163, 35);
            this.lblItemName.TabIndex = 32;
            this.lblItemName.Text = "Item Name";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblTotal.Location = new System.Drawing.Point(1059, 348);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 35);
            this.lblTotal.TabIndex = 35;
            this.lblTotal.Text = "Total";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblPrice.Location = new System.Drawing.Point(1059, 203);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(86, 35);
            this.lblPrice.TabIndex = 33;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblQuantity.Location = new System.Drawing.Point(286, 493);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(130, 35);
            this.lblQuantity.TabIndex = 34;
            this.lblQuantity.Text = "Quantity";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.lblCategory);
            this.panel2.Controls.Add(this.lblPlaceOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 1455);
            this.panel2.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(65, 404);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(457, 37);
            this.cmbCategory.TabIndex = 81;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged_1);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSearch.Location = new System.Drawing.Point(65, 585);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(457, 61);
            this.txtSearch.TabIndex = 80;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 47;
            this.listBox1.Location = new System.Drawing.Point(65, 684);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(555, 660);
            this.listBox1.TabIndex = 31;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblCategory.Location = new System.Drawing.Point(59, 322);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 35);
            this.lblCategory.TabIndex = 30;
            this.lblCategory.Text = "Loại";
            // 
            // lblPlaceOrder
            // 
            this.lblPlaceOrder.AutoSize = true;
            this.lblPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceOrder.Location = new System.Drawing.Point(157, 97);
            this.lblPlaceOrder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPlaceOrder.Name = "lblPlaceOrder";
            this.lblPlaceOrder.Size = new System.Drawing.Size(463, 89);
            this.lblPlaceOrder.TabIndex = 29;
            this.lblPlaceOrder.Text = "Place Order";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item\'s Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 225;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 225;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 225;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 225;
            // 
            // frmUcPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "frmUcPlaceOrder";
            this.Size = new System.Drawing.Size(2412, 1455);
            this.Load += new System.EventHandler(this.frmUcPlaceOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaceOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPlaceOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.DataGridView dgvPlaceOrder;
        private ReaLTaiizor.Controls.CyberButton btnPrint;
        private ReaLTaiizor.Controls.CyberButton btnRemove;
        private ReaLTaiizor.Controls.CyberButton btnConfirm;
        private ReaLTaiizor.Controls.CyberButton btnAddToCart;
        private ReaLTaiizor.Controls.CyberButton btnClear;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
