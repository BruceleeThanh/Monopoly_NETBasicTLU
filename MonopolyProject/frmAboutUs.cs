using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace MonopolyProject {
    public partial class frmAboutUs : DevExpress.XtraEditors.XtraForm {

        frmMain afrmMain = null;

        public frmAboutUs() {
            InitializeComponent();
        }

        public frmAboutUs(frmMain afrmMain) {
            InitializeComponent();
            this.afrmMain = afrmMain;
        }

        private void lblEmail_Click(object sender, EventArgs e) {
            Process.Start("https://mail.google.com");
        }

        private void lblFacebook_Click(object sender, EventArgs e) {
            Process.Start("https://facebook.com/brucelee.thanh");
        }

        private void pboExit_Click(object sender, EventArgs e) {
            this.afrmMain.terCountdownClock_Start();
            this.Close();
        }
    }
}