namespace MonopolyProject {
    partial class frmBuyHouse {
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
            this.pboExit = new DevExpress.XtraEditors.PictureEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.lblColor = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblMoneyLand = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbbHouse = new System.Windows.Forms.ComboBox();
            this.lblMoneyHouse = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalMoney = new DevExpress.XtraEditors.LabelControl();
            this.pboBuy = new DevExpress.XtraEditors.PictureEdit();
            this.sstStatusBottom = new System.Windows.Forms.StatusStrip();
            this.tssFunTip = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pboExit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBuy.Properties)).BeginInit();
            this.sstStatusBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pboExit
            // 
            this.pboExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboExit.EditValue = global::MonopolyProject.Properties.Resources.Close_icon;
            this.pboExit.Location = new System.Drawing.Point(364, 4);
            this.pboExit.Name = "pboExit";
            this.pboExit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pboExit.Properties.Appearance.Options.UseBackColor = true;
            this.pboExit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pboExit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pboExit.Size = new System.Drawing.Size(32, 32);
            this.pboExit.TabIndex = 0;
            this.pboExit.ToolTip = "Thoát";
            this.pboExit.Click += new System.EventHandler(this.pboExit_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblName.LineColor = System.Drawing.Color.Yellow;
            this.lblName.Location = new System.Drawing.Point(135, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Đại lộ Hồng Thập Tự";
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Yellow;
            this.lblColor.Location = new System.Drawing.Point(64, 35);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(256, 10);
            this.lblColor.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(13, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Tiền mua đất:";
            // 
            // lblMoneyLand
            // 
            this.lblMoneyLand.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMoneyLand.Location = new System.Drawing.Point(291, 90);
            this.lblMoneyLand.Name = "lblMoneyLand";
            this.lblMoneyLand.Size = new System.Drawing.Size(21, 13);
            this.lblMoneyLand.TabIndex = 7;
            this.lblMoneyLand.Text = "100";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(13, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Xây nhà:";
            // 
            // cbbHouse
            // 
            this.cbbHouse.FormattingEnabled = true;
            this.cbbHouse.Items.AddRange(new object[] {
            "Không",
            "1 căn",
            "2 căn",
            "3 căn",
            "4 căn",
            "Nhà hàng"});
            this.cbbHouse.Location = new System.Drawing.Point(105, 124);
            this.cbbHouse.Name = "cbbHouse";
            this.cbbHouse.Size = new System.Drawing.Size(102, 21);
            this.cbbHouse.TabIndex = 9;
            this.cbbHouse.SelectedIndexChanged += new System.EventHandler(this.cbbHouse_SelectedIndexChanged);
            // 
            // lblMoneyHouse
            // 
            this.lblMoneyHouse.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMoneyHouse.Location = new System.Drawing.Point(291, 127);
            this.lblMoneyHouse.Name = "lblMoneyHouse";
            this.lblMoneyHouse.Size = new System.Drawing.Size(28, 13);
            this.lblMoneyHouse.TabIndex = 10;
            this.lblMoneyHouse.Text = "1000";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(291, 159);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "___________";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(13, 206);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Tổng tiền:";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalMoney.Location = new System.Drawing.Point(291, 206);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(28, 13);
            this.lblTotalMoney.TabIndex = 13;
            this.lblTotalMoney.Text = "1000";
            // 
            // pboBuy
            // 
            this.pboBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboBuy.EditValue = global::MonopolyProject.Properties.Resources.shop;
            this.pboBuy.Location = new System.Drawing.Point(288, 246);
            this.pboBuy.Name = "pboBuy";
            this.pboBuy.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pboBuy.Properties.Appearance.Options.UseBackColor = true;
            this.pboBuy.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pboBuy.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pboBuy.Size = new System.Drawing.Size(54, 48);
            this.pboBuy.TabIndex = 14;
            this.pboBuy.ToolTip = "Mua nhà";
            this.pboBuy.Click += new System.EventHandler(this.pboBuy_Click);
            // 
            // sstStatusBottom
            // 
            this.sstStatusBottom.Dock = System.Windows.Forms.DockStyle.None;
            this.sstStatusBottom.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.sstStatusBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssFunTip});
            this.sstStatusBottom.Location = new System.Drawing.Point(0, 286);
            this.sstStatusBottom.Name = "sstStatusBottom";
            this.sstStatusBottom.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.sstStatusBottom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sstStatusBottom.Size = new System.Drawing.Size(72, 22);
            this.sstStatusBottom.TabIndex = 16;
            // 
            // tssFunTip
            // 
            this.tssFunTip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tssFunTip.Name = "tssFunTip";
            this.tssFunTip.Size = new System.Drawing.Size(24, 17);
            this.tssFunTip.Text = "TIP";
            // 
            // frmBuyHouse
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 308);
            this.Controls.Add(this.sstStatusBottom);
            this.Controls.Add(this.pboBuy);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lblMoneyHouse);
            this.Controls.Add(this.cbbHouse);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblMoneyLand);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pboExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuyHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuyHouse";
            ((System.ComponentModel.ISupportInitialize)(this.pboExit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBuy.Properties)).EndInit();
            this.sstStatusBottom.ResumeLayout(false);
            this.sstStatusBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pboExit;
        private DevExpress.XtraEditors.LabelControl lblName;
        private System.Windows.Forms.Label lblColor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblMoneyLand;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cbbHouse;
        private DevExpress.XtraEditors.LabelControl lblMoneyHouse;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblTotalMoney;
        private DevExpress.XtraEditors.PictureEdit pboBuy;
        private System.Windows.Forms.StatusStrip sstStatusBottom;
        private System.Windows.Forms.ToolStripStatusLabel tssFunTip;
    }
}