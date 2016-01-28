namespace MonopolyProject {
    partial class demo {
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
            this.ALO = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // ALO
            // 
            this.ALO.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ALO.Appearance.ForeColor = System.Drawing.Color.Fuchsia;
            this.ALO.Appearance.Image = global::MonopolyProject.Properties.Resources.hotel_icon;
            this.ALO.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ALO.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ALO.Location = new System.Drawing.Point(110, 69);
            this.ALO.Name = "ALO";
            this.ALO.Size = new System.Drawing.Size(40, 20);
            this.ALO.TabIndex = 0;
            this.ALO.Text = "4";
            this.ALO.ToolTip = "Hello";
            // 
            // demo
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 321);
            this.Controls.Add(this.ALO);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "demo";
            this.Text = "demo";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl ALO;
    }
}