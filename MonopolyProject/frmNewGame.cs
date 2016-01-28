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
    public partial class frmNewGame : DevExpress.XtraEditors.XtraForm {

        List<Player> aListPlayer = new List<Player>();
        public frmMain afrmMain = null;

        public frmNewGame(frmMain afrmMain) {
            InitializeComponent();
            this.afrmMain = afrmMain;
        }

        private void pboNext_Click(object sender, EventArgs e) {
            if(int.Parse(spiBankMoney.Text) < 0 || int.Parse(spiMoneyStart.Text) < 0 || int.Parse(spiTime.Text) < 0) {
                spiBankMoney.Value = 5000;
                spiMoneyStart.Value = 200;
                spiTime.Value = 30;
                MessageBox.Show("Không được nhập giá trị âm!", "Cài đặt", MessageBoxButtons.OK);
            }
            else {
                int player = int.Parse(cbbPlayer.Text);
                int money = int.Parse(spiMoneyStart.Text);
                int dice = int.Parse(cbbDice.Text);
                int countdownTime = int.Parse(spiTime.Text);
                int bankMoney = int.Parse(spiBankMoney.Text);
                this.Visible = false;
                frmNewGame_Step2 afrmNewGame_Step2 = new frmNewGame_Step2(this, player, money, dice);
                afrmNewGame_Step2.ShowDialog();
                this.afrmMain.LoadSetting(aListPlayer, player, dice, countdownTime, bankMoney);
                this.Close();
            }
        }

        public void LoadListPlayer(List<Player> aListPlayer) {
            this.aListPlayer = aListPlayer;
        }

        private void pboExit_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thoát ứng dụng", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}