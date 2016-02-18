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
    public partial class frmDetailHouse : DevExpress.XtraEditors.XtraForm {

        frmMain afrmMain = null;
        int pawn = 0;
        int IDPlayer = 0;
        int IDPlot = 0;

        public frmDetailHouse() {
            InitializeComponent();
        }

        public frmDetailHouse(frmMain afrmMain, int IDPlayer, int IDPlot) {
            InitializeComponent();
            PlayerHouses aPlayHouse = new PlayerHouses();
            this.afrmMain = afrmMain;
            this.IDPlayer = IDPlayer;
            this.IDPlot = IDPlot;
            pawn = this.afrmMain.aListPlotInfo.Find(b => b.ID == IDPlot).Pawn;
            lblPlotName.Text = this.afrmMain.aListPlotInfo.Find(b => b.ID == IDPlot).Name;
            lblColor.BackColor = System.Drawing.ColorTranslator.FromHtml(this.afrmMain.aListPlotInfo.Find(b => b.ID == IDPlot).Color);
            lblOwner.Text = this.afrmMain.aListPlayer.Find(b => b.ID == IDPlayer).Name;
            aPlayHouse = this.afrmMain.aListPlayer.Find(b => b.ID == IDPlayer).ListHouses.Find(c => c.IDPlot == IDPlot);
            lblPaid.Text = aPlayHouse.Spent.ToString();
            if(aPlayHouse.Apartments == 5) {
                lblSize.Text = "Nhà hàng";
            }
            else {
                lblSize.Text = aPlayHouse.Apartments.ToString() + " căn";
            }
            int money = 0;
            PlotInfo aPlotInfo = this.afrmMain.aListPlotInfo.Find(b => b.ID == IDPlot);
            if(aPlayHouse.Apartments == 0) {
                money = aPlotInfo.LeaseLand;
            }
            else {
                if(aPlayHouse.Apartments == 1) {
                    money = aPlotInfo.LeaseOneHouse;
                }
                else {
                    if(aPlayHouse.Apartments == 2) {
                        money = aPlotInfo.LeaseTwoHouses;
                    }
                    else {
                        if(aPlayHouse.Apartments == 3) {
                            money = aPlotInfo.LeaseThreeHouses;
                        }
                        else {
                            if(aPlayHouse.Apartments == 4) {
                                money = aPlotInfo.LeaseFourHouses;
                            }
                            else {
                                if(aPlayHouse.Apartments == 5) {
                                    money = aPlotInfo.LeaseRes;
                                }
                            }
                        }
                    }
                }
            }
            lblLease.Text = money.ToString();
            lblPawn.Text = aPlotInfo.Pawn.ToString();
            if(aPlayHouse.Status == 1) {
                lblStatus.Text = "Bình thường";
            }
            else {
                if(aPlayHouse.Status == 0) {
                    lblStatus.Text = "Đang cầm cố";
                    pboRedeem.Visible = true;
                }
            }
        }

        private void pboRedeem_Click(object sender, EventArgs e) {
            int total = pawn + (int)(pawn * ((double)this.afrmMain.percentCommission / 100));
            this.afrmMain.bankMoney += total;
            this.afrmMain.aListPlayer.Find(b => b.ID == IDPlayer).Money -= total;
            this.afrmMain.aListPlayer.Find(b => b.ID == IDPlayer).ListHouses.Find(c => c.IDPlot == IDPlot).Status = 1;
            string nameHouseLabel = IDPlayer.ToString() + IDPlot.ToString();
            this.afrmMain.Controls.Find(nameHouseLabel, false).First().Visible = true;
            this.afrmMain.DisplayChangeMoneyPlayer(IDPlayer, total, false);
        }

        private void pboExit_Click(object sender, EventArgs e) {
            this.afrmMain.terCountdownClock_Start();
            this.Close();
        }

    }
}