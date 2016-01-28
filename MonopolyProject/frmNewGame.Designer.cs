namespace MonopolyProject {
    partial class frmNewGame {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewGame));
            this.xtcOptionGame = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.pboNext = new DevExpress.XtraEditors.PictureEdit();
            this.spiBankMoney = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.spiTime = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbbDice = new System.Windows.Forms.ComboBox();
            this.cbbPlayer = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.spiMoneyStart = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.pboExit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcOptionGame)).BeginInit();
            this.xtcOptionGame.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboNext.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiBankMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiMoneyStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboExit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtcOptionGame
            // 
            this.xtcOptionGame.Location = new System.Drawing.Point(8, 15);
            this.xtcOptionGame.Name = "xtcOptionGame";
            this.xtcOptionGame.SelectedTabPage = this.xtraTabPage1;
            this.xtcOptionGame.Size = new System.Drawing.Size(234, 295);
            this.xtcOptionGame.TabIndex = 0;
            this.xtcOptionGame.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.pboNext);
            this.xtraTabPage1.Controls.Add(this.spiBankMoney);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.spiTime);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.cbbDice);
            this.xtraTabPage1.Controls.Add(this.cbbPlayer);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.spiMoneyStart);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(228, 267);
            this.xtraTabPage1.Text = "Chơi mới";
            // 
            // pboNext
            // 
            this.pboNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboNext.EditValue = global::MonopolyProject.Properties.Resources.next_icon;
            this.pboNext.Location = new System.Drawing.Point(156, 211);
            this.pboNext.Name = "pboNext";
            this.pboNext.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pboNext.Properties.Appearance.Options.UseBackColor = true;
            this.pboNext.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pboNext.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pboNext.Size = new System.Drawing.Size(48, 48);
            this.pboNext.TabIndex = 15;
            this.pboNext.ToolTip = "Tiếp theo";
            this.pboNext.Click += new System.EventHandler(this.pboNext_Click);
            // 
            // spiBankMoney
            // 
            this.spiBankMoney.EditValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.spiBankMoney.Location = new System.Drawing.Point(116, 134);
            this.spiBankMoney.Name = "spiBankMoney";
            this.spiBankMoney.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spiBankMoney.Properties.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spiBankMoney.Properties.IsFloatValue = false;
            this.spiBankMoney.Properties.Mask.EditMask = "N00";
            this.spiBankMoney.Size = new System.Drawing.Size(71, 20);
            this.spiBankMoney.TabIndex = 14;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(11, 138);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Ngân khố";
            // 
            // spiTime
            // 
            this.spiTime.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spiTime.Location = new System.Drawing.Point(116, 175);
            this.spiTime.Name = "spiTime";
            this.spiTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spiTime.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spiTime.Properties.IsFloatValue = false;
            this.spiTime.Properties.Mask.EditMask = "N00";
            this.spiTime.Size = new System.Drawing.Size(71, 20);
            this.spiTime.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(11, 180);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Thời gian (phút)";
            // 
            // cbbDice
            // 
            this.cbbDice.FormattingEnabled = true;
            this.cbbDice.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbDice.Location = new System.Drawing.Point(116, 9);
            this.cbbDice.Name = "cbbDice";
            this.cbbDice.Size = new System.Drawing.Size(71, 21);
            this.cbbDice.TabIndex = 10;
            this.cbbDice.Text = "1";
            // 
            // cbbPlayer
            // 
            this.cbbPlayer.FormattingEnabled = true;
            this.cbbPlayer.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.cbbPlayer.Location = new System.Drawing.Point(116, 51);
            this.cbbPlayer.Name = "cbbPlayer";
            this.cbbPlayer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbPlayer.Size = new System.Drawing.Size(71, 21);
            this.cbbPlayer.TabIndex = 9;
            this.cbbPlayer.Text = "2";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(11, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Số xúc xắc";
            // 
            // spiMoneyStart
            // 
            this.spiMoneyStart.EditValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.spiMoneyStart.Location = new System.Drawing.Point(116, 93);
            this.spiMoneyStart.Name = "spiMoneyStart";
            this.spiMoneyStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spiMoneyStart.Properties.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spiMoneyStart.Properties.IsFloatValue = false;
            this.spiMoneyStart.Properties.Mask.EditMask = "N00";
            this.spiMoneyStart.Size = new System.Drawing.Size(71, 20);
            this.spiMoneyStart.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(11, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tiền khởi động";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(11, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Số người";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(228, 267);
            this.xtraTabPage2.Text = "Chơi tiếp";
            // 
            // pboExit
            // 
            this.pboExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboExit.EditValue = global::MonopolyProject.Properties.Resources.Close_icon;
            this.pboExit.Location = new System.Drawing.Point(210, 1);
            this.pboExit.Name = "pboExit";
            this.pboExit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pboExit.Properties.Appearance.Options.UseBackColor = true;
            this.pboExit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pboExit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pboExit.Size = new System.Drawing.Size(32, 32);
            this.pboExit.TabIndex = 1;
            this.pboExit.ToolTip = "Thoát";
            this.pboExit.Click += new System.EventHandler(this.pboExit_Click);
            // 
            // frmNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 314);
            this.Controls.Add(this.pboExit);
            this.Controls.Add(this.xtcOptionGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cờ tỷ phú";
            ((System.ComponentModel.ISupportInitialize)(this.xtcOptionGame)).EndInit();
            this.xtcOptionGame.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboNext.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiBankMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiMoneyStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboExit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtcOptionGame;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.ComboBox cbbDice;
        private System.Windows.Forms.ComboBox cbbPlayer;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit spiMoneyStart;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit spiTime;
        private DevExpress.XtraEditors.SpinEdit spiBankMoney;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PictureEdit pboExit;
        private DevExpress.XtraEditors.PictureEdit pboNext;
    }
}