using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MonopolyProject {
    public partial class frmFlashScreen : DevExpress.XtraEditors.XtraForm {
        public frmFlashScreen() {
            InitializeComponent();
            terDisplay.Start();
        }

        private void terDisplay_Tick(object sender, EventArgs e) {
            terDisplay.Stop();
            this.Close();
        }
    }
}