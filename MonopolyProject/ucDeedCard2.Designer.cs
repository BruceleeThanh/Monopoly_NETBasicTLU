namespace MonopolyProject {
    partial class ucDeedCard2 {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblColor = new System.Windows.Forms.Label();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.picNo = new DevExpress.XtraEditors.PictureEdit();
            this.picYes = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Yellow;
            this.lblColor.Location = new System.Drawing.Point(15, 28);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(228, 11);
            this.lblColor.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblName.LineColor = System.Drawing.Color.Yellow;
            this.lblName.Location = new System.Drawing.Point(71, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Đại lộ Hồng Thập Tự";
            // 
            // picNo
            // 
            this.picNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNo.EditValue = global::MonopolyProject.Properties.Resources.shop_cart_exclude_icon;
            this.picNo.Location = new System.Drawing.Point(147, 57);
            this.picNo.Name = "picNo";
            this.picNo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picNo.Properties.Appearance.Options.UseBackColor = true;
            this.picNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picNo.Size = new System.Drawing.Size(48, 48);
            this.picNo.TabIndex = 5;
            this.picNo.ToolTipTitle = "Bỏ qua";
            this.picNo.Click += new System.EventHandler(this.picNo_Click);
            // 
            // picYes
            // 
            this.picYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picYes.EditValue = global::MonopolyProject.Properties.Resources.shop;
            this.picYes.Location = new System.Drawing.Point(38, 57);
            this.picYes.Name = "picYes";
            this.picYes.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picYes.Properties.Appearance.Options.UseBackColor = true;
            this.picYes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picYes.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.StretchVertical;
            this.picYes.Size = new System.Drawing.Size(48, 48);
            this.picYes.TabIndex = 4;
            this.picYes.ToolTipTitle = "Mua";
            this.picYes.Click += new System.EventHandler(this.picYes_Click);
            // 
            // ucDeedCard2
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picNo);
            this.Controls.Add(this.picYes);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblColor);
            this.Name = "ucDeedCard2";
            this.Size = new System.Drawing.Size(257, 116);
            ((System.ComponentModel.ISupportInitialize)(this.picNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYes.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.PictureEdit picYes;
        private DevExpress.XtraEditors.PictureEdit picNo;
    }
}
