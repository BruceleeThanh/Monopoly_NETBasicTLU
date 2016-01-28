﻿namespace MonopolyProject {
    partial class ucLuckyDrawCard {
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
            this.components = new System.ComponentModel.Container();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.terWaitting = new System.Windows.Forms.Timer(this.components);
            this.pboOk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboOk)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContent
            // 
            this.lblContent.BackColor = System.Drawing.Color.Transparent;
            this.lblContent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(7, 22);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(240, 94);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "Khí vận";
            this.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContent.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(106, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Khí vận";
            this.lblName.Visible = false;
            // 
            // terWaitting
            // 
            this.terWaitting.Interval = 1000;
            this.terWaitting.Tick += new System.EventHandler(this.terWaitting_Tick);
            // 
            // pboOk
            // 
            this.pboOk.BackColor = System.Drawing.Color.Transparent;
            this.pboOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboOk.Image = global::MonopolyProject.Properties.Resources.check_icon;
            this.pboOk.Location = new System.Drawing.Point(115, 116);
            this.pboOk.Name = "pboOk";
            this.pboOk.Size = new System.Drawing.Size(24, 25);
            this.pboOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboOk.TabIndex = 3;
            this.pboOk.TabStop = false;
            this.pboOk.Visible = false;
            this.pboOk.Click += new System.EventHandler(this.pboOk_Click);
            // 
            // ucLuckyDrawCard
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MonopolyProject.Properties.Resources.chance_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pboOk);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblContent);
            this.Name = "ucLuckyDrawCard";
            this.Size = new System.Drawing.Size(252, 144);
            ((System.ComponentModel.ISupportInitialize)(this.pboOk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContent;
        private DevExpress.XtraEditors.LabelControl lblName;
        private System.Windows.Forms.Timer terWaitting;
        private System.Windows.Forms.PictureBox pboOk;
    }
}
