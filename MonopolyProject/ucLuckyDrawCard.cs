using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MonopolyProject {
    public partial class ucLuckyDrawCard : DevExpress.XtraEditors.XtraUserControl {
        public ucLuckyDrawCard() {
            InitializeComponent();
        }
        public ucLuckyDrawCard(int brand, string content) {
            InitializeComponent();
            if(brand == 1) { // Community Chest
                this.BackgroundImage = MonopolyProject.Properties.Resources.communitychest_background;
                lblName.Text = "Khí vận";
                lblContent.Text = content;
            }
            else { // Chance
                this.BackgroundImage = MonopolyProject.Properties.Resources.chance_background;
                lblName.Text = "Cơ hội";
                lblContent.Text = content;
            }
            terWaitting.Start();
        }

        private void terWaitting_Tick(object sender, EventArgs e) {
            this.BackgroundImage = MonopolyProject.Properties.Resources.luckydraw;
            lblName.Visible = true;
            lblContent.Visible = true;
            pboOk.Visible = true;
            terWaitting.Stop();
        }

        private void pboOk_Click(object sender, EventArgs e) {
            this.Dispose();
        }


    }
}
