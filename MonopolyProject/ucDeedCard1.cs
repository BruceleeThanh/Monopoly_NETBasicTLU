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
    public partial class ucDeedCard1 : DevExpress.XtraEditors.XtraUserControl {
        public ucDeedCard1() {
            InitializeComponent();
        }

        public ucDeedCard1(string name, string color, int leaseLand, int leaseOneHouse, int leaseTwoHouses, int leaseThreeHouses, int leaseFourHouses, int leaseRes, int priceHouse,
            int priceRes,int pawn) {
            InitializeComponent();
            lblName.Text = name;
            lblColor.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            lblLeaseLand.Text = lblLeaseLand.Text + leaseLand.ToString();
            lblLeaseOneHouse.Text = lblLeaseOneHouse.Text + leaseOneHouse.ToString();
            lblLeaseTwoHouses.Text = lblLeaseTwoHouses.Text + leaseTwoHouses.ToString();
            lblLeaseThreeHouses.Text = lblLeaseThreeHouses.Text + leaseThreeHouses.ToString();
            lblLeaseFourHouses.Text = lblLeaseFourHouses.Text + leaseFourHouses.ToString();
            lblLeaseRes.Text = lblLeaseRes.Text + leaseRes.ToString();
            lblPriceHouse.Text = lblPriceHouse.Text + priceHouse.ToString();
            lblPriceRes.Text = lblPriceRes.Text + priceRes.ToString();
            lblPawn.Text = lblPawn.Text + pawn.ToString();
        }
    }
}
