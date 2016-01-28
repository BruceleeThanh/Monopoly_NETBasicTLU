namespace MonopolyProject {
    partial class frmNewGame_Step2 {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewGame_Step2));
            this.grcPlayer1 = new DevExpress.XtraEditors.GroupControl();
            this.icbVehicle1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.icoListVehicle = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNamePlayer1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grcPlayer2 = new DevExpress.XtraEditors.GroupControl();
            this.icbVehicle2 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtNamePlayer2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grcPlayer3 = new DevExpress.XtraEditors.GroupControl();
            this.icbVehicle3 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNamePlayer3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grcPlayer4 = new DevExpress.XtraEditors.GroupControl();
            this.icbVehicle4 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNamePlayer4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pboStartGame = new DevExpress.XtraEditors.PictureEdit();
            this.pboExit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPlayer1)).BeginInit();
            this.grcPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbVehicle1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoListVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamePlayer1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPlayer2)).BeginInit();
            this.grcPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbVehicle2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamePlayer2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPlayer3)).BeginInit();
            this.grcPlayer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbVehicle3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamePlayer3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPlayer4)).BeginInit();
            this.grcPlayer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbVehicle4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamePlayer4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboStartGame.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboExit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcPlayer1
            // 
            this.grcPlayer1.Controls.Add(this.icbVehicle1);
            this.grcPlayer1.Controls.Add(this.labelControl5);
            this.grcPlayer1.Controls.Add(this.txtNamePlayer1);
            this.grcPlayer1.Controls.Add(this.labelControl1);
            this.grcPlayer1.Location = new System.Drawing.Point(3, 37);
            this.grcPlayer1.Name = "grcPlayer1";
            this.grcPlayer1.Size = new System.Drawing.Size(271, 190);
            this.grcPlayer1.TabIndex = 0;
            this.grcPlayer1.Text = "Người chơi 1";
            // 
            // icbVehicle1
            // 
            this.icbVehicle1.Location = new System.Drawing.Point(92, 69);
            this.icbVehicle1.Name = "icbVehicle1";
            this.icbVehicle1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbVehicle1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tàu thuỷ", "boat", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Trực thăng", "helicopter", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Phi cơ", "plane", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tàu điện", "train", 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe thùng xanh", "truck", 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe tải to", "truck_car", 5),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe gas", "truck_gas", 6),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe bồn", "truck_gas1", 7)});
            this.icbVehicle1.Properties.LargeImages = this.icoListVehicle;
            this.icbVehicle1.Size = new System.Drawing.Size(163, 22);
            this.icbVehicle1.TabIndex = 5;
            this.icbVehicle1.SelectedIndexChanged += new System.EventHandler(this.icbVehicle1_SelectedIndexChanged);
            // 
            // icoListVehicle
            // 
            this.icoListVehicle.ImageSize = new System.Drawing.Size(32, 20);
            this.icoListVehicle.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icoListVehicle.ImageStream")));
            this.icoListVehicle.Images.SetKeyName(0, "boat.png");
            this.icoListVehicle.Images.SetKeyName(1, "helicopter.png");
            this.icoListVehicle.Images.SetKeyName(2, "plane.png");
            this.icoListVehicle.Images.SetKeyName(3, "train.png");
            this.icoListVehicle.Images.SetKeyName(4, "truck.png");
            this.icoListVehicle.Images.SetKeyName(5, "truck_car.png");
            this.icoListVehicle.Images.SetKeyName(6, "truck_gas.png");
            this.icoListVehicle.Images.SetKeyName(7, "truck_gas1.png");
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(5, 72);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Phương tiện";
            // 
            // txtNamePlayer1
            // 
            this.txtNamePlayer1.Location = new System.Drawing.Point(92, 31);
            this.txtNamePlayer1.Name = "txtNamePlayer1";
            this.txtNamePlayer1.Size = new System.Drawing.Size(163, 20);
            this.txtNamePlayer1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(5, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên";
            // 
            // grcPlayer2
            // 
            this.grcPlayer2.Controls.Add(this.icbVehicle2);
            this.grcPlayer2.Controls.Add(this.labelControl6);
            this.grcPlayer2.Controls.Add(this.txtNamePlayer2);
            this.grcPlayer2.Controls.Add(this.labelControl2);
            this.grcPlayer2.Location = new System.Drawing.Point(280, 37);
            this.grcPlayer2.Name = "grcPlayer2";
            this.grcPlayer2.Size = new System.Drawing.Size(271, 190);
            this.grcPlayer2.TabIndex = 1;
            this.grcPlayer2.Text = "Người chơi 2";
            // 
            // icbVehicle2
            // 
            this.icbVehicle2.Location = new System.Drawing.Point(91, 69);
            this.icbVehicle2.Name = "icbVehicle2";
            this.icbVehicle2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbVehicle2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tàu thuỷ", "boat", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Trực thăng", "helicopter", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Phi cơ", "plane", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tàu điện", "train", 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe thùng xanh", "truck", 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe tải to", "truck_car", 5),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe gas", "truck_gas", 6),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe bồn", "truck_gas1", 7)});
            this.icbVehicle2.Properties.LargeImages = this.icoListVehicle;
            this.icbVehicle2.Size = new System.Drawing.Size(163, 22);
            this.icbVehicle2.TabIndex = 6;
            this.icbVehicle2.SelectedIndexChanged += new System.EventHandler(this.icbVehicle2_SelectedIndexChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(5, 72);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(68, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Phương tiện";
            // 
            // txtNamePlayer2
            // 
            this.txtNamePlayer2.Location = new System.Drawing.Point(91, 31);
            this.txtNamePlayer2.Name = "txtNamePlayer2";
            this.txtNamePlayer2.Size = new System.Drawing.Size(163, 20);
            this.txtNamePlayer2.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(5, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(21, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên";
            // 
            // grcPlayer3
            // 
            this.grcPlayer3.Controls.Add(this.icbVehicle3);
            this.grcPlayer3.Controls.Add(this.labelControl7);
            this.grcPlayer3.Controls.Add(this.txtNamePlayer3);
            this.grcPlayer3.Controls.Add(this.labelControl3);
            this.grcPlayer3.Location = new System.Drawing.Point(3, 233);
            this.grcPlayer3.Name = "grcPlayer3";
            this.grcPlayer3.Size = new System.Drawing.Size(271, 190);
            this.grcPlayer3.TabIndex = 1;
            this.grcPlayer3.Text = "Người chơi 3";
            // 
            // icbVehicle3
            // 
            this.icbVehicle3.Location = new System.Drawing.Point(92, 68);
            this.icbVehicle3.Name = "icbVehicle3";
            this.icbVehicle3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbVehicle3.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tàu thuỷ", "boat", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Trực thăng", "helicopter", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Phi cơ", "plane", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tàu điện", "train", 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe thùng xanh", "truck", 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe tải to", "truck_car", 5),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe gas", "truck_gas", 6),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe bồn", "truck_gas1", 7)});
            this.icbVehicle3.Properties.LargeImages = this.icoListVehicle;
            this.icbVehicle3.Size = new System.Drawing.Size(163, 22);
            this.icbVehicle3.TabIndex = 6;
            this.icbVehicle3.SelectedIndexChanged += new System.EventHandler(this.icbVehicle3_SelectedIndexChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(5, 72);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(68, 13);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Phương tiện";
            // 
            // txtNamePlayer3
            // 
            this.txtNamePlayer3.Location = new System.Drawing.Point(92, 30);
            this.txtNamePlayer3.Name = "txtNamePlayer3";
            this.txtNamePlayer3.Size = new System.Drawing.Size(163, 20);
            this.txtNamePlayer3.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(5, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(21, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tên";
            // 
            // grcPlayer4
            // 
            this.grcPlayer4.Controls.Add(this.icbVehicle4);
            this.grcPlayer4.Controls.Add(this.labelControl8);
            this.grcPlayer4.Controls.Add(this.txtNamePlayer4);
            this.grcPlayer4.Controls.Add(this.labelControl4);
            this.grcPlayer4.Location = new System.Drawing.Point(280, 233);
            this.grcPlayer4.Name = "grcPlayer4";
            this.grcPlayer4.Size = new System.Drawing.Size(271, 190);
            this.grcPlayer4.TabIndex = 1;
            this.grcPlayer4.Text = "Người chơi 4";
            // 
            // icbVehicle4
            // 
            this.icbVehicle4.Location = new System.Drawing.Point(91, 68);
            this.icbVehicle4.Name = "icbVehicle4";
            this.icbVehicle4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbVehicle4.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tàu thuỷ", "boat", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Trực thăng", "helicopter", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Phi cơ", "plane", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tàu điện", "train", 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe thùng xanh", "truck", 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe tải to", "truck_car", 5),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe gas", "truck_gas", 6),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xe bồn", "truck_gas1", 7)});
            this.icbVehicle4.Properties.LargeImages = this.icoListVehicle;
            this.icbVehicle4.Size = new System.Drawing.Size(163, 22);
            this.icbVehicle4.TabIndex = 7;
            this.icbVehicle4.SelectedIndexChanged += new System.EventHandler(this.icbVehicle4_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(5, 72);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(68, 13);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Phương tiện";
            // 
            // txtNamePlayer4
            // 
            this.txtNamePlayer4.Location = new System.Drawing.Point(91, 30);
            this.txtNamePlayer4.Name = "txtNamePlayer4";
            this.txtNamePlayer4.Size = new System.Drawing.Size(163, 20);
            this.txtNamePlayer4.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(5, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(21, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Tên";
            // 
            // pboStartGame
            // 
            this.pboStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboStartGame.EditValue = global::MonopolyProject.Properties.Resources.play_icon;
            this.pboStartGame.Location = new System.Drawing.Point(484, 430);
            this.pboStartGame.Name = "pboStartGame";
            this.pboStartGame.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pboStartGame.Properties.Appearance.Options.UseBackColor = true;
            this.pboStartGame.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pboStartGame.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pboStartGame.Size = new System.Drawing.Size(48, 48);
            this.pboStartGame.TabIndex = 4;
            this.pboStartGame.ToolTip = "Bắt đầu";
            this.pboStartGame.Click += new System.EventHandler(this.pboStartGame_Click);
            // 
            // pboExit
            // 
            this.pboExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboExit.EditValue = global::MonopolyProject.Properties.Resources.Close_icon;
            this.pboExit.Location = new System.Drawing.Point(520, 1);
            this.pboExit.Name = "pboExit";
            this.pboExit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pboExit.Properties.Appearance.Options.UseBackColor = true;
            this.pboExit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pboExit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pboExit.Size = new System.Drawing.Size(32, 32);
            this.pboExit.TabIndex = 3;
            this.pboExit.ToolTip = "Thoát";
            this.pboExit.Click += new System.EventHandler(this.pboExit_Click);
            // 
            // frmNewGame_Step2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 486);
            this.Controls.Add(this.pboStartGame);
            this.Controls.Add(this.pboExit);
            this.Controls.Add(this.grcPlayer4);
            this.Controls.Add(this.grcPlayer3);
            this.Controls.Add(this.grcPlayer2);
            this.Controls.Add(this.grcPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewGame_Step2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cờ tỷ phú";
            ((System.ComponentModel.ISupportInitialize)(this.grcPlayer1)).EndInit();
            this.grcPlayer1.ResumeLayout(false);
            this.grcPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbVehicle1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoListVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamePlayer1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPlayer2)).EndInit();
            this.grcPlayer2.ResumeLayout(false);
            this.grcPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbVehicle2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamePlayer2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPlayer3)).EndInit();
            this.grcPlayer3.ResumeLayout(false);
            this.grcPlayer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbVehicle3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamePlayer3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPlayer4)).EndInit();
            this.grcPlayer4.ResumeLayout(false);
            this.grcPlayer4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbVehicle4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamePlayer4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboStartGame.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboExit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grcPlayer1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtNamePlayer1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl grcPlayer2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtNamePlayer2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl grcPlayer3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtNamePlayer3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl grcPlayer4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtNamePlayer4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.Utils.ImageCollection icoListVehicle;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbVehicle1;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbVehicle2;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbVehicle3;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbVehicle4;
        private DevExpress.XtraEditors.PictureEdit pboExit;
        private DevExpress.XtraEditors.PictureEdit pboStartGame;
    }
}