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
    public partial class frmNewGame_Step2 : DevExpress.XtraEditors.XtraForm {

        int player = 0;
        int money = 0;
        int dice = 0;
        int[] aListCurrentVehicle = { -2, -2, -2, -2 };
        List<Player> aListPlayer = new List<Player>();
        public frmNewGame afrmNewGame = null;

        public frmNewGame_Step2() {
            InitializeComponent();
        }

        public frmNewGame_Step2(frmNewGame afrmNewGame, int player, int money, int dice) {
            InitializeComponent();
            this.player = player;
            this.money = money;
            this.dice = dice;
            if(this.player == 2) {
                grcPlayer3.Enabled = false;
                grcPlayer4.Enabled = false;
            }
            else {
                if(this.player == 3) {
                    grcPlayer4.Enabled = false;
                }
            }
            this.afrmNewGame = afrmNewGame;
        }

        private void pboStartGame_Click(object sender, EventArgs e) {
            //string name = icbVehicle1.EditValue.ToString();
            for(int i = 0; i < this.player; i++) {
                Player temp = new Player();
                temp.ID = i + 1;
                temp.Money = this.money;
                temp.Position = 1;
                aListPlayer.Add(temp);
            }
            if(txtNamePlayer1.Text == "" || txtNamePlayer2.Text == "") {
                MessageBox.Show("Vui lòng nhập tên người chơi!", "Nhập tên người chơi", MessageBoxButtons.OK);
                return;
            }
            else {
                if(icbVehicle1.SelectedIndex < 0 || icbVehicle2.SelectedIndex < 0) {
                    MessageBox.Show("Vui lòng chọn phương tiện!", "Chọn phương tiện", MessageBoxButtons.OK);
                    return;
                }
                else {
                    aListPlayer[0].Name = txtNamePlayer1.Text;
                    aListPlayer[0].VehicleImage = new DevExpress.XtraEditors.PictureEdit();
                    aListPlayer[0].VehicleImage = this.CreateVehicleDetail(icbVehicle1.EditValue.ToString(), txtNamePlayer1.Text);
                    aListPlayer[1].Name = txtNamePlayer2.Text;
                    aListPlayer[1].VehicleImage = new DevExpress.XtraEditors.PictureEdit();
                    aListPlayer[1].VehicleImage = this.CreateVehicleDetail(icbVehicle2.EditValue.ToString(), txtNamePlayer2.Text);
                }
                if(this.player == 3) {
                    if(txtNamePlayer1.Text == "" || txtNamePlayer2.Text == "" || txtNamePlayer3.Text == "") {
                        MessageBox.Show("Vui lòng nhập tên người chơi!", "Nhập tên người chơi", MessageBoxButtons.OK);
                        return;
                    }
                    else {
                        if(icbVehicle3.SelectedIndex < 0) {
                            MessageBox.Show("Vui lòng chọn phương tiện!", "Chọn phương tiện", MessageBoxButtons.OK);
                            return;
                        }
                        else {
                            aListPlayer[2].Name = txtNamePlayer3.Text;
                            aListPlayer[2].VehicleImage = new DevExpress.XtraEditors.PictureEdit();
                            aListPlayer[2].VehicleImage = this.CreateVehicleDetail(icbVehicle3.EditValue.ToString(), txtNamePlayer3.Text);
                        }
                    }

                }
                else {
                    if(this.player == 4) {
                        if(txtNamePlayer1.Text == "" || txtNamePlayer2.Text == "" || txtNamePlayer3.Text == "" || txtNamePlayer4.Text == "") {
                            MessageBox.Show("Vui lòng nhập tên người chơi!", "Nhập tên người chơi", MessageBoxButtons.OK);
                            return;
                        }
                        else {
                            if(icbVehicle3.SelectedIndex < 0 || icbVehicle4.SelectedIndex < 0) {
                                MessageBox.Show("Vui lòng chọn phương tiện!", "Chọn phương tiện", MessageBoxButtons.OK);
                                return;
                            }
                            else {
                                aListPlayer[2].Name = txtNamePlayer3.Text;
                                aListPlayer[2].VehicleImage = new DevExpress.XtraEditors.PictureEdit();
                                aListPlayer[2].VehicleImage = this.CreateVehicleDetail(icbVehicle3.EditValue.ToString(), txtNamePlayer3.Text);
                                aListPlayer[3].Name = txtNamePlayer4.Text;
                                aListPlayer[3].VehicleImage = new DevExpress.XtraEditors.PictureEdit();
                                aListPlayer[3].VehicleImage = this.CreateVehicleDetail(icbVehicle4.EditValue.ToString(), txtNamePlayer4.Text);
                            }
                        }
                    }
                }
            }
            this.afrmNewGame.LoadListPlayer(aListPlayer);
            this.afrmNewGame.Close();
            this.Dispose();
        }

        public PictureEdit CreateVehicleDetail(string vehicle, string namePlayer) {
            DevExpress.XtraEditors.PictureEdit result = new PictureEdit();
            result.BackColor = System.Drawing.Color.Transparent;
            result.Cursor = System.Windows.Forms.Cursors.Hand;
            result.LoadAsync("Resources/" + vehicle + ".png");
            result.ToolTip = namePlayer;
            result.Size = new System.Drawing.Size(80, 44);
            result.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            result.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            result.BringToFront();
            return result;
        }

        private void icbVehicle1_SelectedIndexChanged(object sender, EventArgs e) {
            if(aListCurrentVehicle.Any(b => b == icbVehicle1.SelectedIndex)) {
                MessageBox.Show("Phương tiện này đã được chọn, vui lòng chọn phương tiện khác!", "Chọn phương tiện", MessageBoxButtons.OK);
                icbVehicle1.SelectedItem = null;
            }
            else {
                aListCurrentVehicle[0] = icbVehicle1.SelectedIndex;
            }
        }

        private void icbVehicle2_SelectedIndexChanged(object sender, EventArgs e) {
            if(aListCurrentVehicle.Any(b => b == icbVehicle2.SelectedIndex)) {
                MessageBox.Show("Phương tiện này đã được chọn, vui lòng chọn phương tiện khác!", "Chọn phương tiện", MessageBoxButtons.OK);
                icbVehicle2.SelectedItem = null;
            }
            else {
                aListCurrentVehicle[1] = icbVehicle2.SelectedIndex;
            }
        }

        private void icbVehicle3_SelectedIndexChanged(object sender, EventArgs e) {
            if(aListCurrentVehicle.Any(b => b == icbVehicle3.SelectedIndex)) {
                MessageBox.Show("Phương tiện này đã được chọn, vui lòng chọn phương tiện khác!", "Chọn phương tiện", MessageBoxButtons.OK);
                icbVehicle3.SelectedItem = null;
            }
            else {
                aListCurrentVehicle[2] = icbVehicle3.SelectedIndex;
            }
        }

        private void icbVehicle4_SelectedIndexChanged(object sender, EventArgs e) {
            if(aListCurrentVehicle.Any(b=>b == icbVehicle4.SelectedIndex)) {
                MessageBox.Show("Phương tiện này đã được chọn, vui lòng chọn phương tiện khác!", "Chọn phương tiện", MessageBoxButtons.OK);
                icbVehicle4.SelectedItem = null;
            }
            else {
                aListCurrentVehicle[3] = icbVehicle4.SelectedIndex;
            }
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