namespace MonopolyProject {
    partial class frmSaleHouse {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.rdoSale = new DevExpress.XtraEditors.RadioGroup();
            this.lblBuyer = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblPaid = new DevExpress.XtraEditors.LabelControl();
            this.cbbBuyer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblExpectedPrice = new DevExpress.XtraEditors.LabelControl();
            this.txtExpectedPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblClosingPrice = new DevExpress.XtraEditors.LabelControl();
            this.pboSale = new DevExpress.XtraEditors.PictureEdit();
            this.pboExit = new DevExpress.XtraEditors.PictureEdit();
            this.lblPlotName = new DevExpress.XtraEditors.LabelControl();
            this.lblColor = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.rdoSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbBuyer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpectedPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboExit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoSale
            // 
            this.rdoSale.Location = new System.Drawing.Point(10, 118);
            this.rdoSale.Name = "rdoSale";
            this.rdoSale.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rdoSale.Properties.Appearance.Options.UseBackColor = true;
            this.rdoSale.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdoSale.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Cầm cố (cầm cố cho Ngân hàng - có thể chuộc lại)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Bán lại (bán cho người khác - không thể chuộc lại)")});
            this.rdoSale.Size = new System.Drawing.Size(267, 96);
            this.rdoSale.TabIndex = 0;
            this.rdoSale.SelectedIndexChanged += new System.EventHandler(this.rdoSale_SelectedIndexChanged);
            // 
            // lblBuyer
            // 
            this.lblBuyer.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBuyer.Location = new System.Drawing.Point(16, 221);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(60, 13);
            this.lblBuyer.TabIndex = 1;
            this.lblBuyer.Text = "Người mua";
            this.lblBuyer.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(16, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Đã đầu tư";
            // 
            // lblPaid
            // 
            this.lblPaid.Location = new System.Drawing.Point(124, 86);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(6, 13);
            this.lblPaid.TabIndex = 3;
            this.lblPaid.Text = "0";
            // 
            // cbbBuyer
            // 
            this.cbbBuyer.Location = new System.Drawing.Point(124, 217);
            this.cbbBuyer.Name = "cbbBuyer";
            this.cbbBuyer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbBuyer.Size = new System.Drawing.Size(143, 20);
            this.cbbBuyer.TabIndex = 4;
            this.cbbBuyer.Visible = false;
            // 
            // lblExpectedPrice
            // 
            this.lblExpectedPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblExpectedPrice.Location = new System.Drawing.Point(16, 257);
            this.lblExpectedPrice.Name = "lblExpectedPrice";
            this.lblExpectedPrice.Size = new System.Drawing.Size(42, 13);
            this.lblExpectedPrice.TabIndex = 5;
            this.lblExpectedPrice.Text = "Giá bán";
            this.lblExpectedPrice.Visible = false;
            // 
            // txtExpectedPrice
            // 
            this.txtExpectedPrice.Location = new System.Drawing.Point(124, 253);
            this.txtExpectedPrice.Name = "txtExpectedPrice";
            this.txtExpectedPrice.Size = new System.Drawing.Size(143, 20);
            this.txtExpectedPrice.TabIndex = 6;
            this.txtExpectedPrice.Visible = false;
            this.txtExpectedPrice.EditValueChanged += new System.EventHandler(this.txtExpectedPrice_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(16, 314);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Chốt giá";
            // 
            // lblClosingPrice
            // 
            this.lblClosingPrice.Location = new System.Drawing.Point(124, 314);
            this.lblClosingPrice.Name = "lblClosingPrice";
            this.lblClosingPrice.Size = new System.Drawing.Size(6, 13);
            this.lblClosingPrice.TabIndex = 8;
            this.lblClosingPrice.Text = "0";
            // 
            // pboSale
            // 
            this.pboSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboSale.EditValue = global::MonopolyProject.Properties.Resources.auction_icon;
            this.pboSale.Location = new System.Drawing.Point(219, 346);
            this.pboSale.Name = "pboSale";
            this.pboSale.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pboSale.Properties.Appearance.Options.UseBackColor = true;
            this.pboSale.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pboSale.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pboSale.Size = new System.Drawing.Size(48, 48);
            this.pboSale.TabIndex = 10;
            this.pboSale.ToolTip = "Bán";
            this.pboSale.Click += new System.EventHandler(this.pboSale_Click);
            // 
            // pboExit
            // 
            this.pboExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboExit.EditValue = global::MonopolyProject.Properties.Resources.Close_icon;
            this.pboExit.Location = new System.Drawing.Point(261, 3);
            this.pboExit.Name = "pboExit";
            this.pboExit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pboExit.Properties.Appearance.Options.UseBackColor = true;
            this.pboExit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pboExit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pboExit.Size = new System.Drawing.Size(32, 32);
            this.pboExit.TabIndex = 9;
            this.pboExit.ToolTip = "Thoát";
            this.pboExit.Click += new System.EventHandler(this.pboExit_Click);
            // 
            // lblPlotName
            // 
            this.lblPlotName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPlotName.Location = new System.Drawing.Point(84, 16);
            this.lblPlotName.Name = "lblPlotName";
            this.lblPlotName.Size = new System.Drawing.Size(113, 13);
            this.lblPlotName.TabIndex = 11;
            this.lblPlotName.Text = "Đại lộ Hồng Thập Tự";
            // 
            // lblColor
            // 
            this.lblColor.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.lblColor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblColor.Location = new System.Drawing.Point(28, 38);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(214, 10);
            this.lblColor.TabIndex = 12;
            // 
            // frmSaleHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 411);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPlotName);
            this.Controls.Add(this.pboSale);
            this.Controls.Add(this.pboExit);
            this.Controls.Add(this.lblClosingPrice);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtExpectedPrice);
            this.Controls.Add(this.lblExpectedPrice);
            this.Controls.Add(this.cbbBuyer);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblBuyer);
            this.Controls.Add(this.rdoSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSaleHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSaleHouse";
            ((System.ComponentModel.ISupportInitialize)(this.rdoSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbBuyer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpectedPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboExit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup rdoSale;
        private DevExpress.XtraEditors.LabelControl lblBuyer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblPaid;
        private DevExpress.XtraEditors.ComboBoxEdit cbbBuyer;
        private DevExpress.XtraEditors.LabelControl lblExpectedPrice;
        private DevExpress.XtraEditors.TextEdit txtExpectedPrice;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblClosingPrice;
        private DevExpress.XtraEditors.PictureEdit pboExit;
        private DevExpress.XtraEditors.PictureEdit pboSale;
        private DevExpress.XtraEditors.LabelControl lblPlotName;
        private DevExpress.XtraEditors.LabelControl lblColor;
    }
}