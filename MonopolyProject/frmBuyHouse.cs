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
    public partial class frmBuyHouse : DevExpress.XtraEditors.XtraForm {

        frmMain afrmMain = null;
        PlotInfo aPlotInfo = new PlotInfo();

        public frmBuyHouse() {
            InitializeComponent();
        }

        public frmBuyHouse(frmMain afrmMain, PlotInfo aPlotInfo) {
            InitializeComponent();
            this.afrmMain = afrmMain;
            this.aPlotInfo = aPlotInfo;
            lblName.Text = aPlotInfo.Name;
            lblColor.BackColor = System.Drawing.ColorTranslator.FromHtml(aPlotInfo.Color);
            lblMoneyLand.Text = aPlotInfo.PricePlot.ToString();
            lblMoneyHouse.Text = "0";
            lblTotalMoney.Text = (int.Parse(lblMoneyLand.Text) + int.Parse(lblMoneyHouse.Text)).ToString();
            cbbHouse.SelectedIndex = 0;
            Random rand = new Random();
            int funtip = rand.Next(1, 5);
            tssFunTip.Text = this.FunTip(funtip);
        }
        private void cbbHouse_SelectedIndexChanged(object sender, EventArgs e) {
            lblMoneyHouse.Text = (cbbHouse.SelectedIndex == 5 ? (aPlotInfo.PriceHouse * 4 + aPlotInfo.PriceRes) : (aPlotInfo.PriceHouse * cbbHouse.SelectedIndex)).ToString();
            lblTotalMoney.Text = (int.Parse(lblMoneyLand.Text) + int.Parse(lblMoneyHouse.Text)).ToString();
        }

        private void pboBuy_Click(object sender, EventArgs e) {
            if(this.afrmMain.aListPlayer.Find(b => b.ID == this.afrmMain.turnPlayer).Money >= int.Parse(lblTotalMoney.Text)) {
                PlayerHouses aPlayHouse = new PlayerHouses();
                if(aPlotInfo.ID <= 11) {
                    aPlayHouse.HouseLabel.Location = new Point(aPlotInfo.X1Coord + 9, aPlotInfo.Y1Coord - 25);
                }
                else {
                    if(aPlotInfo.ID >= 32) {
                        aPlayHouse.HouseLabel.Location = new Point(aPlotInfo.X1Coord - 32, aPlotInfo.Y1Coord + 11);
                    }
                    else {
                        if(aPlotInfo.ID > 11 && aPlotInfo.ID <= 20) {
                            aPlayHouse.HouseLabel.Location = new Point(aPlotInfo.X2Coord + 2, aPlotInfo.Y2Coord - 40);
                        }
                        else {
                            aPlayHouse.HouseLabel.Location = new Point(aPlotInfo.X2Coord - 46, aPlotInfo.Y2Coord);
                        }
                    }
                }
                if(cbbHouse.SelectedIndex == 5) {
                    aPlayHouse.HouseLabel.Text = "1";
                    aPlayHouse.HouseLabel.Appearance.Image = global::MonopolyProject.Properties.Resources.hotel_icon;

                }
                else {
                    aPlayHouse.HouseLabel.Text = cbbHouse.SelectedIndex.ToString();
                    aPlayHouse.HouseLabel.Appearance.Image = global::MonopolyProject.Properties.Resources.house_icon;
                }
                aPlayHouse.IDPlot = aPlotInfo.ID;
                aPlayHouse.Name = aPlotInfo.Name + "("+cbbHouse.Text+")";
                aPlayHouse.Apartments = cbbHouse.SelectedIndex;
                aPlayHouse.Spent = int.Parse(lblTotalMoney.Text);
                aPlayHouse.Status = 1;
                string nameHouseLabel = this.afrmMain.turnPlayer.ToString() + this.aPlotInfo.ID.ToString();
                aPlayHouse.HouseLabel.Name = nameHouseLabel;
                aPlayHouse.HouseLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                aPlayHouse.HouseLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
                aPlayHouse.HouseLabel.Size = new System.Drawing.Size(40, 20);
                aPlayHouse.HouseLabel.ToolTip = "Nhà của " + this.afrmMain.aListPlayer.Find(b => b.ID == this.afrmMain.turnPlayer).Name;
                aPlayHouse.HouseLabel.Appearance.ForeColor = System.Drawing.ColorTranslator.FromHtml(aPlotInfo.Color);
                this.afrmMain.aListPlayer.Find(b => b.ID == this.afrmMain.turnPlayer).ListHouses.Add(aPlayHouse);
                this.afrmMain.Controls.Add(aPlayHouse.HouseLabel);
                aPlayHouse.HouseLabel.Show();
                this.afrmMain.aListPlayer.Find(b => b.ID == this.afrmMain.turnPlayer).Money -= int.Parse(lblTotalMoney.Text);
                this.afrmMain.bankMoney += int.Parse(lblTotalMoney.Text);
                this.afrmMain.aListPlotInfo.Find(b => b.ID == this.aPlotInfo.ID).Status = 1;
                this.afrmMain.Refresh();
                this.afrmMain.DisplayChangeMoneyPlayer(this.afrmMain.turnPlayer, int.Parse(lblTotalMoney.Text), false);
                this.afrmMain.terCountdownClock_Start();
                this.afrmMain.EnableDice();
                this.Close();
            }
            else {
                MessageBox.Show("Bạn không đủ tiền để xây nhà.", "Mua nhà", MessageBoxButtons.OK);
            }
        }

        public string FunTip(int pos) {
            if(pos == 1) {
                return "Mua ngay đi, giá nhà đất đang lên";
            }
            else {
                if(pos == 2) {
                    return "Thị trường đang trầm lắng, mua căn này liệu có ổn";
                }
                else {
                    if(pos == 3) {
                        return "Nghe nói dạo này, giá vật liệu đang tăng";
                    }
                    else {
                        return "Xây hotel trên đất này tha hồ lời";
                    }
                }
            }
        }

        private void pboExit_Click(object sender, EventArgs e) {
            this.afrmMain.terCountdownClock_Start();
            this.afrmMain.EnableDice();
            this.Close();
        }
    }
}