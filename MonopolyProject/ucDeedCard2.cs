using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Windows;

namespace MonopolyProject {
    public partial class ucDeedCard2 : DevExpress.XtraEditors.XtraUserControl {
        public ucDeedCard2() {
            InitializeComponent();
        }

        public ucDeedCard2(string name, string color) {
            InitializeComponent();
            lblName.Text = name;
            lblColor.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
        }

        private void picYes_Click(object sender, EventArgs e) {

        }

        private void picNo_Click(object sender, EventArgs e) {
            this.Dispose();
        }

    }
}
