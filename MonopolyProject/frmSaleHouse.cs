using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace MonopolyProject {
    public partial class frmSaleHouse : DevExpress.XtraEditors.XtraForm {

        frmMain afrmMain = null;
        int pawn = 0;
        int IDPlayer = 0;
        int IDPlot = 0;

        public frmSaleHouse() {
            InitializeComponent();
        }

        public frmSaleHouse(frmMain afrmMain, int IDPlayer, int IDPlot) {
            InitializeComponent();
            this.afrmMain = afrmMain;
            this.IDPlayer = IDPlayer;
            this.IDPlot = IDPlot;
            pawn = this.afrmMain.aListPlotInfo.Find(b => b.ID == IDPlot).Pawn;
            lblPlotName.Text = this.afrmMain.aListPlotInfo.Find(b => b.ID == IDPlot).Name;
            lblColor.BackColor = System.Drawing.ColorTranslator.FromHtml(this.afrmMain.aListPlotInfo.Find(b => b.ID == IDPlot).Color);
            lblPaid.Text = this.afrmMain.aListPlayer.Find(b=>b.ID == IDPlayer).ListHouses.Find(c=>c.IDPlot == IDPlot).Spent.ToString();
            foreach(Player temp in this.afrmMain.aListPlayer){
                if(temp.ID != IDPlayer) {
                    cbbBuyer.Properties.Items.Add(temp.Name);
                }
            }
            rdoSale.SelectedIndex = 0;
            cbbBuyer.SelectedIndex = 0;
        }

        private void pboExit_Click(object sender, EventArgs e) {
            this.afrmMain.terCountdownClock_Start();
            this.Close();
        }

        private void txtExpectedPrice_EditValueChanged(object sender, EventArgs e) {
            try {
                int ClosingPrice = int.Parse(txtExpectedPrice.Text);
                lblClosingPrice.Text = ClosingPrice.ToString();
            }
            catch(Exception ex) {
                MessageBox.Show("Giá bán phải là một số.", "Bán nhà", MessageBoxButtons.OK);
                txtExpectedPrice.Text = "";
            }
            
        }

        private void rdoSale_SelectedIndexChanged(object sender, EventArgs e) {
            if(rdoSale.SelectedIndex == 0) {
                lblBuyer.Visible = false;
                lblExpectedPrice.Visible = false;
                cbbBuyer.Visible = false;
                txtExpectedPrice.Visible = false;
                lblClosingPrice.Text = pawn.ToString();
            }
            else {
                if(rdoSale.SelectedIndex == 1) {
                    lblBuyer.Visible = true;
                    lblExpectedPrice.Visible = true;
                    cbbBuyer.Visible = true;
                    txtExpectedPrice.Visible = true;
                    lblClosingPrice.Text = "0";
                }
            }
        }

        private void pboSale_Click(object sender, EventArgs e) {
            PlayerHouses aPlayerHouse = new PlayerHouses();
            aPlayerHouse = this.afrmMain.aListPlayer.Find(b => b.ID == IDPlayer).ListHouses.Find(c => c.IDPlot == IDPlot);
            if(rdoSale.SelectedIndex == 0) {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cầm cố miếng đất này cho Ngân hàng?", "Bán nhà", MessageBoxButtons.YesNoCancel);
                if(result == DialogResult.Yes) {
                    this.afrmMain.bankMoney -= int.Parse(lblClosingPrice.Text);
                    this.afrmMain.aListPlayer.Find(b => b.ID == IDPlayer).Money += int.Parse(lblClosingPrice.Text);
                    this.afrmMain.aListPlayer.Find(b => b.ID == IDPlayer).ListHouses.Find(c => c.IDPlot == IDPlot).Status = 0;
                    string nameHouseLabel = IDPlayer.ToString() + IDPlot.ToString();
                    this.afrmMain.Controls.Find(nameHouseLabel, false).First().Visible = false;
                    this.afrmMain.DisplayChangeMoneyPlayer(IDPlayer, int.Parse(lblClosingPrice.Text), true);
                }
            }
            else {
                if(rdoSale.SelectedIndex == 1) {
                    if(this.afrmMain.aListPlayer.Find(b => b.Name == cbbBuyer.Text).Money < int.Parse(lblClosingPrice.Text)) {
                        string contentMessageBox = cbbBuyer.Text + " không đủ tiền để mua lại mảnh đất này!";
                        MessageBox.Show(contentMessageBox, "Bán nhà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else {
                        string contentDialog = "Bạn có chắc chắn muốn bán miếng đất này cho " + cbbBuyer.Text + "?";
                        DialogResult result = MessageBox.Show(contentDialog, "Bán nhà", MessageBoxButtons.YesNoCancel);
                        if(result == DialogResult.Yes) {
                            contentDialog = cbbBuyer.Text + ", bạn có chắc chắn muốn mua mảnh đất này của "
                                + this.afrmMain.aListPlayer.Find(b => b.ID == IDPlayer).Name + " với giá " + int.Parse(lblClosingPrice.Text) + "?";
                            DialogResult finalResult = MessageBox.Show(contentDialog, "Bán nhà", MessageBoxButtons.YesNoCancel);
                            if(finalResult == DialogResult.Yes) {
                                this.afrmMain.aListPlayer.Find(b => b.ID == IDPlayer).Money += int.Parse(lblClosingPrice.Text);
                                this.afrmMain.aListPlayer.Find(b => b.ID == IDPlayer).ListHouses.Remove(aPlayerHouse);
                                aPlayerHouse.Spent = int.Parse(lblClosingPrice.Text);
                                string nameHouseLabel = IDPlayer.ToString() + IDPlot.ToString();
                                LabelControl temp = new LabelControl();
                                temp = (LabelControl)this.afrmMain.Controls[nameHouseLabel];
                                this.afrmMain.Controls.RemoveByKey(nameHouseLabel);
                                nameHouseLabel = this.afrmMain.aListPlayer.Find(b => b.Name == cbbBuyer.Text).ID + IDPlot.ToString();
                                temp.Name = nameHouseLabel;
                                temp.ToolTip = "Nhà của " + cbbBuyer.Text;
                                this.afrmMain.Controls.Add(temp);
                                aPlayerHouse.HouseLabel = temp;
                                this.afrmMain.aListPlayer.Find(b => b.Name == cbbBuyer.Text).ListHouses.Add(aPlayerHouse);
                                this.afrmMain.aListPlayer.Find(b => b.Name == cbbBuyer.Text).Money -= int.Parse(lblClosingPrice.Text);
                                this.afrmMain.DisplayChangeMoneyPlayer(IDPlayer, int.Parse(lblClosingPrice.Text), true);
                                this.afrmMain.DisplayChangeMoneyPlayer(this.afrmMain.aListPlayer.Find(b => b.Name == cbbBuyer.Text).ID, int.Parse(lblClosingPrice.Text), false);
                            }
                        }
                    }
                }
            }
            this.afrmMain.Refresh();
            this.afrmMain.terCountdownClock_Start();
            this.afrmMain.EnableDice();
            this.Close();
        }

    }
}