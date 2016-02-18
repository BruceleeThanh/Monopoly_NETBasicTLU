using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MonopolyProject.Properties;
using DevExpress.XtraEditors;
using System.Windows.Threading;
using System.Threading;

namespace MonopolyProject {
    public partial class frmMain : Form {

        ToolTip tt = new ToolTip();

        public List<PlotInfo> aListPlotInfo = new List<PlotInfo>();
        List<LuckyDraw> aListCommunityChest = new List<LuckyDraw>(); // Community Chest = 1
        List<LuckyDraw> aListChance = new List<LuckyDraw>(); // Chance = 0
        public List<Player> aListPlayer = new List<Player>();
        List<NextTurnCoord> aListNextTurnCoord = new List<NextTurnCoord>();

        ucDeedCard1 aucDeedCard1;
        ucLuckyDrawCard aucLuckyDrawCard;

        int amountPlayer = 2;
        int amountDice = 1;
        public int bankMoney = 0;
        int currentDice = 0;
        public int turnPlayer = 1;
        int directionVehicle = 0;
        int destinationVehicle = 0;
        int currentPosition = 0;
        int passedPosition = 0;
        int countTick = 0;
        int tickLimit = 0;
        int X = 0;
        int Y = 0;
        public int percentCommission = 20; // Tỷ lệ phần trăm số tiền chuộc lại nhà từ Ngân hàng.
        int pointerCommunityChest = 0; // Con trỏ bốc Khí Vận
        int pointerChance = 0; // Con trỏ bốc Cơ Hội


        bool pressKeyStatus = false;
        bool isDiceMove = true;
        bool isDoneMoveVehicle = false;

        DispatcherTimer dtiMoveVehicle = null;

    #region Biến xử lý đồng hồ đếm ngược
        int minutes = 0;
        int seconds = 59;
    #endregion

        public frmMain() {
            InitializeComponent();
            this.frmMain_Load();
            frmFlashScreen afrmFlashScreen = new frmFlashScreen();
            afrmFlashScreen.ShowDialog();
            frmNewGame afrmNewGame = new frmNewGame(this);
            afrmNewGame.ShowDialog();
            this.Refresh();
            terCountdownClock.Start();
            this.CreateVehicle();
            this.LoadPlayer();
            this.PlayingProcess();
        }

        public override void Refresh() {
            base.Refresh();
            this.LoadPlayer();
            lblBankMoney.Text = bankMoney.ToString();
        }

        public void frmMain_Load() {
            aListPlotInfo = this.ReadFilePlotInfo();
            this.ClassifyLuckyDraw(this.ReadFileLuckyDraw());
        }

        public List<PlotInfo> ReadFilePlotInfo() {
            List<PlotInfo> aList = new List<PlotInfo>();
            StreamReader read = new StreamReader("Resources/PlotInfo.txt", System.Text.Encoding.Default);
            while(!read.EndOfStream){
                int id = int.Parse(read.ReadLine());
                string temp = read.ReadLine();
                string[] deg = temp.Split(' ');
                string name = read.ReadLine();
                string color = read.ReadLine();
                int pricePlot = int.Parse(read.ReadLine());
                int type = int.Parse(read.ReadLine());
                temp = read.ReadLine();
                string[] house = temp.Split(' ');
                int leaseLand = int.Parse(house[0]);
                int leaseOneHouse = int.Parse(house[1]);
                int leaseTwoHouses = int.Parse(house[2]);
                int leaseThreeHouses = int.Parse(house[3]);
                int leaseFourHouses = int.Parse(house[4]);
                int leaseRes = int.Parse(house[5]);
                int priceHouse = int.Parse(house[6]);
                int priceRes = int.Parse(house[7]);
                int pawn = int.Parse(house[8]);
                aList.Add(new PlotInfo(id, int.Parse(deg[0]), int.Parse(deg[1]), int.Parse(deg[2]), int.Parse(deg[3]), name, color, pricePlot, type, leaseLand, leaseOneHouse,
                    leaseTwoHouses, leaseThreeHouses, leaseFourHouses, leaseRes, priceHouse, priceRes, pawn, 0));
            }
            return aList;
        }

        public List<LuckyDraw> ReadFileLuckyDraw() {
            List<LuckyDraw> aList = new List<LuckyDraw>();
            StreamReader read = new StreamReader("Resources/LuckyDraw.txt", System.Text.Encoding.Default);
            while(!read.EndOfStream) {
                int brand = int.Parse(read.ReadLine());
                int money = int.Parse(read.ReadLine());
                int toPlot = int.Parse(read.ReadLine());
                int steps = int.Parse(read.ReadLine());
                int type = int.Parse(read.ReadLine());
                string content = read.ReadLine();
                aList.Add(new LuckyDraw(brand, money, toPlot, steps, type, content));
            }
            return aList;
        }

        public void ClassifyLuckyDraw(List<LuckyDraw> aList) {
            foreach(LuckyDraw temp in aList) {
                if(temp.Brand == 1) {
                    aListCommunityChest.Add(temp);
                }
                else {
                    aListChance.Add(temp);
                }
            }
        }

        public void LoadPlayer() {
            lblNamePlayer1.Text = aListPlayer[0].Name;
            lblMoneyPlayer1.Text = aListPlayer[0].Money.ToString();
            dgvItemPlayer1.DataSource = aListPlayer[0].ListHouses;
            dgvItemPlayer1.RefreshDataSource();
            lblNamePlayer2.Text = aListPlayer[1].Name;
            lblMoneyPlayer2.Text = aListPlayer[1].Money.ToString();
            dgvItemPlayer2.DataSource = aListPlayer[1].ListHouses;
            dgvItemPlayer2.RefreshDataSource();
            if(amountPlayer == 3) {
                lblNamePlayer3.Text = aListPlayer[2].Name;
                lblMoneyPlayer3.Text = aListPlayer[2].Money.ToString();
                dgvItemPlayer3.DataSource = aListPlayer[2].ListHouses;
                dgvItemPlayer3.RefreshDataSource();
            }
            else {
                if(amountPlayer == 4) {
                    lblNamePlayer3.Text = aListPlayer[2].Name;
                    lblMoneyPlayer3.Text = aListPlayer[2].Money.ToString();
                    dgvItemPlayer3.DataSource = aListPlayer[2].ListHouses;
                    dgvItemPlayer3.RefreshDataSource();
                    lblNamePlayer4.Text = aListPlayer[3].Name;
                    lblMoneyPlayer4.Text = aListPlayer[3].Money.ToString();
                    dgvItemPlayer4.DataSource = aListPlayer[3].ListHouses;
                    dgvItemPlayer4.RefreshDataSource();
                }
            }
        }

        public void LoadSetting(List<Player> aListPlayer, int amountPlayer, int amountDice, int countdownTime, int bankMoney) {
            this.aListPlayer = aListPlayer;
            this.amountPlayer = amountPlayer;
            this.amountDice = amountDice;
            this.minutes = countdownTime;
            this.bankMoney = bankMoney;
            lblBankMoney.Text = this.bankMoney.ToString();
            NextTurnCoord aNextTurnCoord = new NextTurnCoord();
            aListNextTurnCoord = aNextTurnCoord.CreateListNextTurnCoord(amountPlayer);
            if(amountPlayer == 2) {
                dgvItemPlayer3.Visible = false;
                dgvItemPlayer4.Visible = false;
            }
            else {
                if(amountPlayer == 3) {
                    dgvItemPlayer4.Visible = false;
                }
            }
        }

        public void CreateVehicle() {
            foreach(Player temp in aListPlayer) {
                temp.VehicleImage.Location = this.PositionCenter(1);
                this.Controls.Add(temp.VehicleImage);
                temp.VehicleImage.Visible = true;
            }
        }


        public Point PositionCenter(int postion) {
            PlotInfo temp = aListPlotInfo.Find(b => b.ID == postion);
            int width = (temp.X1Coord + temp.X2Coord) / 2;
            int height = (temp.Y1Coord + temp.Y2Coord) / 2;
            width -= 40;
            height -= 20;
            Point result = new Point(width,height);
            return result;
        }

    #region Xử lý Click vào bàn cờ để xem thông tin ô đất

        private void frmMain_MouseClick(object sender, MouseEventArgs e) {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Controls.Remove(aucDeedCard1);
            foreach(PlotInfo temp in aListPlotInfo) {
                if(temp.X1Coord < e.X && temp.X2Coord > e.X && temp.Y1Coord < e.Y && temp.Y2Coord > e.Y) {
                    aucDeedCard1 = new ucDeedCard1(temp.Name, temp.Color, temp.LeaseLand, temp.LeaseOneHouse, temp.LeaseTwoHouses, temp.LeaseThreeHouses, temp.LeaseFourHouses,
                        temp.LeaseRes, temp.PriceHouse, temp.PriceRes, temp.Pawn);
                    if(width - e.X < 275 && height - e.Y < 216) {
                        aucDeedCard1.Location = new Point(e.X - 275, e.Y - 216);
                    }
                    if(width - e.X < 275 && height - e.Y >= 216) {
                        aucDeedCard1.Location = new Point(e.X - 275, e.Y);
                    }
                    if(width - e.X >= 275 && height - e.Y < 216) {
                        aucDeedCard1.Location = new Point(e.X, e.Y - 216);
                    }
                    if(width - e.X >= 275 && height - e.Y >= 216) {
                        aucDeedCard1.Location = new Point(e.X, e.Y);
                    }
                    this.Controls.Add(aucDeedCard1);
                    aucDeedCard1.BringToFront();
                    aucDeedCard1.Visible = true;
                    break;
                }
            }
            terDeedCard1.Stop();
            terDeedCard1.Start();
        }

        private void terDeedCard1_Tick(object sender, EventArgs e) {
            this.Controls.Remove(aucDeedCard1);
            terDeedCard1.Stop();
        }
    #endregion

    #region Xử lý Show Tooltip của các nút bấm
        private void pboExit_MouseHover(object sender, EventArgs e) {
            tt.Show("Thoát", this.pboExit);
        }

        private void pboAboutUs_MouseHover(object sender, EventArgs e) {
            tt.Show("Thông tin", this.pboAboutUs);
        }

        private void pboSetting_MouseHover(object sender, EventArgs e) {
            tt.Show("Cài đặt", this.pboSetting);
        }

        private void pboStartGame_MouseHover(object sender, EventArgs e) {
            tt.Show("Ván mới", this.pboStartGame);
        }

        private void pboDice_MouseHover(object sender, EventArgs e) {
            tt.Show("Gieo xúc xắc", this.pboDice);
        }
    #endregion

    #region Xử lý đồng hồ đếm ngược - thời gian chơi
        private void terCountdownClock_Tick(object sender, EventArgs e) {
            seconds -= 1;
            if(seconds == -1) {
                minutes -= 1;
                seconds = 59;
            }
            if(minutes == 0 && seconds == 0) {
                terCountdownClock.Stop();
                MessageBox.Show("Hết thời gian. Trò chơi kết thúc.", "Trò chơi kết thúc", MessageBoxButtons.OK);
            }
            lblCountdownClock_Minutes.Text = minutes.ToString();
            lblCountdownClock_Seconds.Text = seconds.ToString();
        }

        public void terCountdownClock_Start(){
            terCountdownClock.Start();
        }
    #endregion

    #region Xử lý xúc xắc
        private void pboDice_Click(object sender, EventArgs e) {
            this.StartDice();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            switch (keyData) {
                case Keys.Space:
                    if(pressKeyStatus) {
                        this.StartDice();
                    }
                break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void terDice_Tick(object sender, EventArgs e) {
            pboResultDice1.Visible = false;
            pboResultDice2.Visible = false;
            pboDice.Visible = true;
            terDice.Stop();
        }

        private void terHidenDice_Tick(object sender, EventArgs e) {
            this.EnableDice();
        }

        public void StartDice() {
            pressKeyStatus = false;
            this.pboDice.Enabled = false;
            this.popDeedCard2.Visible = false;
            terWaitDice.Stop();
            if(amountDice == 1) {
                Random rand = new Random();
                int dice1 = rand.Next(1, 7);
                currentDice = dice1;
                pboResultDice1.Load("Resources/" + dice1.ToString() + "dice.png");
                pboDice.Visible = false;
                pboResultDice1.Location = new Point(620, 344);
                pboResultDice1.Visible = true;
                terDice.Start();
                if(isDiceMove) {
                    if(aListPlayer.Find(b => b.ID == turnPlayer).Position != 31) {
                        destinationVehicle = aListPlayer.Find(b => b.ID == turnPlayer).Position + currentDice;
                        if(destinationVehicle > 40) {
                            destinationVehicle -= 40;
                        }
                        this.MoveVehicleNormal(turnPlayer, destinationVehicle, true, true);
                        terHidenDice.Start();
                    }
                    else {
                        if(currentDice == 6) {
                            destinationVehicle = aListPlayer.Find(b => b.ID == turnPlayer).Position + currentDice;
                            if(destinationVehicle > 40) {
                                destinationVehicle -= 40;
                            }
                            this.MoveVehicleNormal(turnPlayer, destinationVehicle, true, true);
                            terHidenDice.Start();
                        }
                        else {
                            terHidenDice.Start();
                        }
                    }
                    
                }
                else {

                }
            }
            else {
                if(amountDice == 2) {
                    Random rand = new Random();
                    int dice1 = rand.Next(1, 7);
                    int dice2 = rand.Next(1, 7);
                    currentDice = dice1 + dice2;
                    pboResultDice1.Load("Resources/" + dice1.ToString() + "dice.png");
                    pboResultDice2.Load("Resources/" + dice2.ToString() + "dice.png");
                    pboDice.Visible = false;
                    pboResultDice1.Visible = true;
                    pboResultDice2.Visible = true;
                    terDice.Start();
                    if(isDiceMove) {
                        destinationVehicle = aListPlayer.Find(b => b.ID == turnPlayer).Position + currentDice;
                        if(destinationVehicle > 40) {
                            destinationVehicle -= 40;
                        }
                        this.MoveVehicleNormal(turnPlayer, destinationVehicle, true, true);
                        terHidenDice.Start();
                    }
                    else {

                    }
                }
            }
        }

        public void MoveVehicleNormal(int IDPlayer, int end, bool isMoveByDice, bool isPassDeparturePosition) {
            passedPosition = aListPlayer.Find(b => b.ID == IDPlayer).Position;
            aListPlayer.Find(b => b.ID == IDPlayer).VehicleImage.Location = this.PositionCenter(end);
            aListPlayer.Find(b => b.ID == IDPlayer).VehicleImage.BringToFront();
            aListPlayer.Find(b => b.ID == IDPlayer).Position = end;
            tssPlayerMoving.Text = aListPlayer.Find(b => b.ID == IDPlayer).Name;
            tssPlayerMovingPlot.Text = aListPlotInfo.Find(b => b.ID == end).Name;
            this.PlotAccess(IDPlayer, end, isMoveByDice, isPassDeparturePosition);
        }

        public void EnableDice() {
            popDeedCard2.Visible = false;
            lblStatusMoneyPlayer.Text = "";
            lblStatusMoneyPlayer.Visible = false;
            lblChangeMoneyPlayer1.Visible = false;
            lblChangeMoneyPlayer2.Visible = false;
            lblChangeMoneyPlayer3.Visible = false;
            lblChangeMoneyPlayer4.Visible = false;
            pboDice.Enabled = true;
            terHidenDice.Stop();
            NextTurnEffect();
            pressKeyStatus = true;
            this.Focus();
        }

    #endregion

        public void PlayingProcess(){
            //terWaitDice.Start();
        }

        public void PlotAccess(int IDPlayer, int pos, bool isMoveByDice, bool isPassDeparturePosition) {
            currentPosition = pos;
            if(isPassDeparturePosition) {
                this.passDepartureStation_Money(IDPlayer, passedPosition, pos);
            }
            PlotInfo aPlotInfo = aListPlotInfo.Find(b => b.ID == pos);
            if(aPlotInfo.Status == 0) {
                if(aPlotInfo.Type == 3 || aPlotInfo.Type == 4 || aPlotInfo.Type == 5) {
                    lblName_DeedCard2.Text = aPlotInfo.Name;
                    lblColor_DeedCard2.BackColor = System.Drawing.ColorTranslator.FromHtml(aPlotInfo.Color);
                    if(pos <= 11) {
                        popDeedCard2.Location = new Point(aPlotInfo.X1Coord - 128, aPlotInfo.Y1Coord - 116);
                    }
                    else {
                        if(pos >= 32) {
                            popDeedCard2.Location = new Point(aPlotInfo.X1Coord - 257, aPlotInfo.Y1Coord - 58);
                        }
                        else {
                            if(pos > 11 && pos <= 20) {
                                popDeedCard2.Location = new Point(aPlotInfo.X2Coord, aPlotInfo.Y2Coord - 58);
                            }
                            else {
                                popDeedCard2.Location = new Point(aPlotInfo.X2Coord - 128, aPlotInfo.Y2Coord);
                            }
                        }
                    }
                    popDeedCard2.BringToFront();
                    popDeedCard2.Focus();
                    popDeedCard2.Show();
                }
                else {
                    if(aPlotInfo.Type == 0 && isMoveByDice && aPlotInfo.ID != 1) {
                        this.MoneyTaxPlot(turnPlayer, pos);
                    }
                    else {
                        if(aPlotInfo.Type == 1) {
                            this.takeLuckyDraw(turnPlayer, 1);
                        }
                        else {
                            if(aPlotInfo.Type == 2) {
                                this.takeLuckyDraw(turnPlayer, 0);
                            }
                        }
                    }
                }
            }
            else {
                if(aPlotInfo.Status == 1 && aPlotInfo.Type == 3 && isMoveByDice) {
                    this.MoneyLeasePlot1(turnPlayer, pos);
                }
            }
            
            //else {
            //    if
            //}
        }

        public void NextTurnEffect() {
            turnPlayer++;
            if(turnPlayer > amountPlayer) {
                turnPlayer = 1;
            }
            pboTurnPlayer.Location = aListNextTurnCoord.Find(b => b.ID == turnPlayer).Location;
            lblBankMoney.Text = bankMoney.ToString();
        }

        public bool passDepartureStation(int start, int end) {
            if(start > end) {
                return true;
            }
            else {
                return false;
            }
        }

        public void passDepartureStation_Money(int IDPlayer, int start, int end) {
            if(this.passDepartureStation(start, end)) {
                aListPlayer.Find(b => b.ID == IDPlayer).Money += 200;
                bankMoney -= 200;
                this.DisplayChangeMoneyPlayer(IDPlayer, 200, true);
                lblStatusMoneyPlayer.Text = lblStatusMoneyPlayer.Text + aListPlayer.Find(b => b.ID == IDPlayer).Name + " vừa được thưởng tiền khi qua Trạm khởi hành.\n";
                lblStatusMoneyPlayer.BringToFront();
                lblStatusMoneyPlayer.Show();
            }
        }

        public void MoneyLeasePlot1(int IDPlayer, int pos) {
            foreach(Player temp in aListPlayer) {
                foreach(PlayerHouses temp1 in temp.ListHouses) {
                    if(temp1.IDPlot == pos) {
                        if(temp1.Status == 1) {
                            if(IDPlayer != temp.ID) {
                                int money = 0;
                                PlotInfo aPlotInfo = aListPlotInfo.Find(b => b.ID == pos);
                                if(temp1.Apartments == 0) {
                                    money = aPlotInfo.LeaseLand;
                                }
                                else {
                                    if(temp1.Apartments == 1) {
                                        money = aPlotInfo.LeaseOneHouse;
                                    }
                                    else {
                                        if(temp1.Apartments == 2) {
                                            money = aPlotInfo.LeaseTwoHouses;
                                        }
                                        else {
                                            if(temp1.Apartments == 3) {
                                                money = aPlotInfo.LeaseThreeHouses;
                                            }
                                            else {
                                                if(temp1.Apartments == 4) {
                                                    money = aPlotInfo.LeaseFourHouses;
                                                }
                                                else {
                                                    if(temp1.Apartments == 5) {
                                                        money = aPlotInfo.LeaseRes;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                temp.Money += money;
                                aListPlayer.Find(b => b.ID == IDPlayer).Money -= money;
                                lblStatusMoneyPlayer.Text = lblStatusMoneyPlayer.Text + aListPlayer.Find(b => b.ID == IDPlayer).Name + " vừa trả " + temp.Name + " tiền thuê nhà: " + money.ToString();
                                lblStatusMoneyPlayer.BringToFront();
                                lblStatusMoneyPlayer.Show();
                                this.DisplayChangeMoneyPlayer(IDPlayer, money, false);
                                this.DisplayChangeMoneyPlayer(temp.ID, money, true);
                                this.Refresh();
                                break;
                            }
                        }
                    }
                }
            }
        }

        public void MoneyTaxPlot(int IDPlayer, int pos) {
            PlotInfo aPlotInfo = new PlotInfo();
            aPlotInfo = aListPlotInfo.Find(b => b.ID == pos);
            if(aPlotInfo.PricePlot > 0 && pos != 0) {
                aListPlayer.Find(b => b.ID == IDPlayer).Money -= aPlotInfo.PricePlot;
                lblStatusMoneyPlayer.Text = lblStatusMoneyPlayer.Text + aListPlayer.Find(b => b.ID == IDPlayer).Name + " vừa trả " + aPlotInfo.Name + ": " + aPlotInfo.PricePlot.ToString();
                lblStatusMoneyPlayer.BringToFront();
                lblStatusMoneyPlayer.Show();
                this.DisplayChangeMoneyPlayer(IDPlayer, aPlotInfo.PricePlot, false);
                this.Refresh();
            }
        }

        private void terWaitDice_Tick(object sender, EventArgs e) {
            this.StartDice();
        }

        public void DisplayChangeMoneyPlayer(int player, int money, bool status) {
            if(player == 1) {
                if(status) {
                    lblChangeMoneyPlayer1.Text = "+ " + money.ToString();
                    lblChangeMoneyPlayer1.ForeColor = System.Drawing.Color.DarkGreen;
                }
                else {
                    lblChangeMoneyPlayer1.Text = "- " + money.ToString();
                    lblChangeMoneyPlayer1.ForeColor = System.Drawing.Color.DarkRed;
                }
                lblChangeMoneyPlayer1.Visible = true;
            }
            else {
                if(player == 2) {
                    if(status) {
                        lblChangeMoneyPlayer2.Text = "+ " + money.ToString();
                        lblChangeMoneyPlayer2.ForeColor = System.Drawing.Color.DarkGreen;
                    }
                    else {
                        lblChangeMoneyPlayer2.Text = "- " + money.ToString();
                        lblChangeMoneyPlayer2.ForeColor = System.Drawing.Color.DarkRed;
                    }
                    lblChangeMoneyPlayer2.Visible = true;
                }
                else {
                    if(player == 3) {
                        if(status) {
                            lblChangeMoneyPlayer3.Text = "+ " + money.ToString();
                            lblChangeMoneyPlayer3.ForeColor = System.Drawing.Color.DarkGreen;
                        }
                        else {
                            lblChangeMoneyPlayer3.Text = "- " + money.ToString();
                            lblChangeMoneyPlayer3.ForeColor = System.Drawing.Color.DarkRed;
                        }
                        lblChangeMoneyPlayer3.Visible = true;
                    }
                    else {
                        if(player == 4) {
                            if(status) {
                                lblChangeMoneyPlayer4.Text = "+ " + money.ToString();
                                lblChangeMoneyPlayer4.ForeColor = System.Drawing.Color.DarkGreen;
                            }
                            else {
                                lblChangeMoneyPlayer4.Text = "- " + money.ToString();
                                lblChangeMoneyPlayer4.ForeColor = System.Drawing.Color.DarkRed;
                            }
                            lblChangeMoneyPlayer4.Visible = true;
                        }
                    }
                }
            }
        }



    #region Xử lý di chuyển phương tiện - Quá khoai tạm thời dừng lại đã
        //private void terMoveVehicle_Tick(object sender, EventArgs e) {
            

        //    if(turnPlayer == 1) {
        //        pboVehiclePlayer1.Location = new Point(pboVehiclePlayer1.Location.X + X, pboVehiclePlayer1.Location.Y + Y);
        //        if(this.CheckCorner(pboVehiclePlayer1.Location)) {
        //            if(directionVehicle < 4) {
        //                directionVehicle++;
        //            }
        //            else {
        //                directionVehicle = 0;
        //            }
        //        }
        //        if(this.CheckDestination(pboVehiclePlayer1.Location, destinationVehicle)) {
        //            terMoveVehicle.Stop();
        //        }
        //    }
        //    else {
        //        if(turnPlayer == 2) {
        //            pboVehiclePlayer2.Location = new Point(pboVehiclePlayer2.Location.X + X, pboVehiclePlayer2.Location.Y + Y);
        //            if(this.CheckCorner(pboVehiclePlayer2.Location)) {
        //                if(directionVehicle < 4) {
        //                    directionVehicle++;
        //                }
        //                else {
        //                    directionVehicle = 0;
        //                }
        //            }
        //            if(this.CheckDestination(pboVehiclePlayer2.Location, destinationVehicle)) {
        //                terMoveVehicle.Stop();
        //            }
        //        }
        //        else {
        //            if(turnPlayer == 3) {
        //                pboVehiclePlayer3.Location = new Point(pboVehiclePlayer3.Location.X + X, pboVehiclePlayer3.Location.Y + Y);
        //                if(this.CheckCorner(pboVehiclePlayer3.Location)) {
        //                    if(directionVehicle < 4) {
        //                        directionVehicle++;
        //                    }
        //                    else {
        //                        directionVehicle = 0;
        //                    }
        //                }
        //                if(this.CheckDestination(pboVehiclePlayer3.Location, destinationVehicle)) {
        //                    terMoveVehicle.Stop();
        //                }
        //            }
        //            else {
        //                if(turnPlayer == 4) {
        //                    pboVehiclePlayer4.Location = new Point(pboVehiclePlayer4.Location.X + X, pboVehiclePlayer4.Location.Y + Y);
        //                    if(this.CheckCorner(pboVehiclePlayer4.Location)) {
        //                        if(directionVehicle < 4) {
        //                            directionVehicle++;
        //                        }
        //                        else {
        //                            directionVehicle = 0;
        //                        }
        //                    }
        //                    if(this.CheckDestination(pboVehiclePlayer4.Location, destinationVehicle)) {
        //                        terMoveVehicle.Stop();
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //public bool CheckCorner(Point aPoint) {
        //    if(this.CheckDestination(aPoint,1)) {
        //        return true;
        //    }
        //    if(this.CheckDestination(aPoint, 11)) {
        //        return true;
        //    }
        //    if(this.CheckDestination(aPoint, 21)) {
        //        return true;
        //    }
        //    if(this.CheckDestination(aPoint, 31)) {
        //        return true;
        //    }
        //    return false;
        //}

        //public bool CheckDestination(Point aPoint, int destinationPostion) {
        //    int X = this.PositionCenter(destinationPostion).X;
        //    int Y = this.PositionCenter(destinationPostion).Y;
        //    if(((aPoint.X - X) <= 3 && (aPoint.X - X) >= -3) || ((aPoint.Y - Y) <= 3 && (aPoint.Y - Y) >= -3)) {
        //        return true;
        //    }
        //    else {
        //        return false;
        //    }
        //}

        //public void MoveVehicle(int start, int end) {
        //    dtiMoveVehicle = new DispatcherTimer(DispatcherPriority.Send);
        //    dtiMoveVehicle.Tick += new System.EventHandler(dtiMoveVehicle_Tick);
        //    dtiMoveVehicle.Interval = new TimeSpan(120);
        //    while(start != end){
        //        if(start % 10 == 1) {
        //            directionVehicle = start / 10 + 1;
        //        }
        //        if(directionVehicle == 1) {
        //            X = -1;
        //            Y = 0;
        //            tickLimit = this.PositionCenter(start).X - this.PositionCenter(start + 1).X;
        //        }
        //        else {
        //            if(directionVehicle == 2) {
        //                X = 0;
        //                Y = -1;
        //                tickLimit = this.PositionCenter(start).Y - this.PositionCenter(start + 1).Y;
        //            }
        //            else {
        //                if(directionVehicle == 3) {
        //                    X = 1;
        //                    Y = 0;
        //                    tickLimit = this.PositionCenter(start + 1).X - this.PositionCenter(start).X;
        //                }
        //                else {
        //                    if(directionVehicle == 4) {
        //                        X = 0;
        //                        Y = 1;
        //                        tickLimit = this.PositionCenter(start + 1).Y - this.PositionCenter(start).Y;
        //                    }
        //                }
        //            }
        //        }
        //        currentPosition = start;
        //        dtiMoveVehicle.Start();
        //        start++;
        //        start = start > 40 ? 1 : start;
        //    }
        //    aListPlayer.Find(b => b.ID == turnPlayer).Position = end;
        //}

        //private void dtiMoveVehicle_Tick(object sender, System.EventArgs e) {
        //    if(countTick == tickLimit) {
        //        dtiMoveVehicle.Stop();
        //        countTick = 0;
        //        tickLimit = 0;
        //    }
        //    else {
        //        if(turnPlayer == 1) {
        //            pboVehiclePlayer1.Location = new Point(pboVehiclePlayer1.Location.X + X, pboVehiclePlayer1.Location.Y + Y);
        //        }
        //        else {
        //            if(turnPlayer == 2) {
        //                pboVehiclePlayer2.Location = new Point(pboVehiclePlayer2.Location.X + X, pboVehiclePlayer2.Location.Y + Y);
        //            }
        //            else {
        //                if(turnPlayer == 3) {
        //                    pboVehiclePlayer3.Location = new Point(pboVehiclePlayer3.Location.X + X, pboVehiclePlayer3.Location.Y + Y);
        //                }
        //                else {
        //                    if(turnPlayer == 4) {
        //                        pboVehiclePlayer4.Location = new Point(pboVehiclePlayer4.Location.X + X, pboVehiclePlayer4.Location.Y + Y);
        //                    }
        //                }
        //            }
        //        }
        //        countTick++;
        //    }
        //}
    #endregion




        private void pboAboutUs_Click(object sender, EventArgs e) {
            terCountdownClock.Stop();
            terHidenDice.Stop();
            frmAboutUs afrmAboutUs = new frmAboutUs(this);
            afrmAboutUs.ShowDialog();
        }   

        private void pboExit_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu lại phiên chơi này?", "Thoát ứng dụng", MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes) {
                // Luu lai phien lam viec
                System.Windows.Forms.Application.Exit();
            }
            else {
                if(result == DialogResult.No)
                    System.Windows.Forms.Application.Exit();
            }
        }

        private void picYes_DeedCard2_Click(object sender, EventArgs e) {
            PlotInfo aPlotInfo = aListPlotInfo.Find(b => b.ID == this.currentPosition);
            if(aListPlayer.Find(b => b.ID == turnPlayer).Money >= aPlotInfo.PricePlot) {
                terCountdownClock.Stop();
                terHidenDice.Stop();
                this.popDeedCard2.Visible = false;
                frmBuyHouse afrmBuyHouse = new frmBuyHouse(this, aPlotInfo);
                afrmBuyHouse.ShowDialog();
            }
            else {
                MessageBox.Show("Bạn không đủ tiền để mua ô đất này.", "Mua đất", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.popDeedCard2.Visible = false;
                this.EnableDice();
            }
            
        }

        private void picNo_DeedCard2_Click(object sender, EventArgs e) {
            this.popDeedCard2.Visible = false;
            this.EnableDice();
        }

    #region Xử lý GridControls ItemPlayer
        private void btnDetailItemPlayer1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            terCountdownClock.Stop();
            frmDetailHouse afrmDetailHouse = new frmDetailHouse(this, 1, int.Parse(viewItemPlayer1.GetFocusedRowCellValue("IDPlot").ToString()));
            afrmDetailHouse.ShowDialog();
        }

        private void btnSaleItemPlayer1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if(aListPlayer.Find(b => b.ID == 1).ListHouses.Find(c => c.IDPlot == int.Parse(viewItemPlayer1.GetFocusedRowCellValue("IDPlot").ToString())).Status == 1) {
                terCountdownClock.Stop();
                frmSaleHouse afrmSaleHouse = new frmSaleHouse(this, 1, int.Parse(viewItemPlayer1.GetFocusedRowCellValue("IDPlot").ToString()));
                afrmSaleHouse.ShowDialog();
            }
            else {
                if(aListPlayer.Find(b => b.ID == 1).ListHouses.Find(c => c.IDPlot == int.Parse(viewItemPlayer1.GetFocusedRowCellValue("IDPlot").ToString())).Status == 0) {
                    MessageBox.Show("Miếng đất này đã được cầm cố cho Ngân hàng, không thể bán được!", "Bán nhà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDetailItemPlayer2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            terCountdownClock.Stop();
            frmDetailHouse afrmDetailHouse = new frmDetailHouse(this, 2, int.Parse(viewItemPlayer2.GetFocusedRowCellValue("IDPlot").ToString()));
            afrmDetailHouse.ShowDialog();
        }

        private void btnSaleItemPlayer2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if(aListPlayer.Find(b => b.ID == 2).ListHouses.Find(c => c.IDPlot == int.Parse(viewItemPlayer2.GetFocusedRowCellValue("IDPlot").ToString())).Status == 1) {
                terCountdownClock.Stop();
                frmSaleHouse afrmSaleHouse = new frmSaleHouse(this, 2, int.Parse(viewItemPlayer2.GetFocusedRowCellValue("IDPlot").ToString()));
                afrmSaleHouse.ShowDialog();
            }
            else {
                if(aListPlayer.Find(b => b.ID == 2).ListHouses.Find(c => c.IDPlot == int.Parse(viewItemPlayer2.GetFocusedRowCellValue("IDPlot").ToString())).Status == 0) {
                    MessageBox.Show("Miếng đất này đã được cầm cố cho Ngân hàng, không thể bán được!", "Bán nhà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDetailItemPlayer3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            terCountdownClock.Stop();
            frmDetailHouse afrmDetailHouse = new frmDetailHouse(this, 3, int.Parse(viewItemPlayer3.GetFocusedRowCellValue("IDPlot").ToString()));
            afrmDetailHouse.ShowDialog();
        }

        private void btnSaleItemPlayer3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if(aListPlayer.Find(b => b.ID == 3).ListHouses.Find(c => c.IDPlot == int.Parse(viewItemPlayer3.GetFocusedRowCellValue("IDPlot").ToString())).Status == 1) {
                terCountdownClock.Stop();
                frmSaleHouse afrmSaleHouse = new frmSaleHouse(this, 3, int.Parse(viewItemPlayer3.GetFocusedRowCellValue("IDPlot").ToString()));
                afrmSaleHouse.ShowDialog();
            }
            else {
                if(aListPlayer.Find(b => b.ID == 3).ListHouses.Find(c => c.IDPlot == int.Parse(viewItemPlayer3.GetFocusedRowCellValue("IDPlot").ToString())).Status == 0) {
                    MessageBox.Show("Miếng đất này đã được cầm cố cho Ngân hàng, không thể bán được!", "Bán nhà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDetailItemPlayer4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            terCountdownClock.Stop();
            frmDetailHouse afrmDetailHouse = new frmDetailHouse(this, 4, int.Parse(viewItemPlayer4.GetFocusedRowCellValue("IDPlot").ToString()));
            afrmDetailHouse.ShowDialog();
        }

        private void btnSaleItemPlayer4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if(aListPlayer.Find(b => b.ID == 4).ListHouses.Find(c => c.IDPlot == int.Parse(viewItemPlayer4.GetFocusedRowCellValue("IDPlot").ToString())).Status == 1) {
                terCountdownClock.Stop();
                frmSaleHouse afrmSaleHouse = new frmSaleHouse(this, 4, int.Parse(viewItemPlayer4.GetFocusedRowCellValue("IDPlot").ToString()));
                afrmSaleHouse.ShowDialog();
            }
            else {
                if(aListPlayer.Find(b => b.ID == 4).ListHouses.Find(c => c.IDPlot == int.Parse(viewItemPlayer4.GetFocusedRowCellValue("IDPlot").ToString())).Status == 0) {
                    MessageBox.Show("Miếng đất này đã được cầm cố cho Ngân hàng, không thể bán được!", "Bán nhà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    #endregion

    #region Xử lý Khí Vận và Cơ Hội

        public void takeLuckyDraw(int IDPlayer, int brand) {
            this.Controls.Remove(aucLuckyDrawCard);
            if(brand == 1) {
                aucLuckyDrawCard = new ucLuckyDrawCard(brand, aListCommunityChest[pointerCommunityChest].Content);
                aucLuckyDrawCard.Location = new Point(630, 440);
                this.Controls.Add(aucLuckyDrawCard);
                aucLuckyDrawCard.BringToFront();
                aucLuckyDrawCard.Visible = true;
                this.processLuckyDraw(IDPlayer, aListCommunityChest[pointerCommunityChest]);
                pointerCommunityChest++;
            }
            else {
                if(brand == 0) {
                    aucLuckyDrawCard = new ucLuckyDrawCard(brand, aListChance[pointerChance].Content);
                    aucLuckyDrawCard.Location = new Point(430, 150);
                    this.Controls.Add(aucLuckyDrawCard);
                    aucLuckyDrawCard.BringToFront();
                    aucLuckyDrawCard.Visible = true;
                    this.processLuckyDraw(IDPlayer, aListChance[pointerChance]);
                    pointerChance++;
                }
            }
        }

        public void processLuckyDraw(int IDPlayer, LuckyDraw aLuckyDraw) {
            if(aLuckyDraw.Type == 0) {
                this.LuckyDraw_Type0(IDPlayer, aLuckyDraw.Money);
                return;
            }
            if(aLuckyDraw.Type == 1) {
                this.LuckyDraw_Type1(IDPlayer, aLuckyDraw.Money);
                return;
            }
            if(aLuckyDraw.Type == 2) {
                this.LuckyDraw_Type2(IDPlayer, aLuckyDraw.ToPlot);
                return;
            }
            if(aLuckyDraw.Type == 3) {
                this.LuckyDraw_Type3(IDPlayer, aLuckyDraw.ToPlot);
                return;
            }
            if(aLuckyDraw.Type == 4) {
                this.LuckyDraw_Type4(IDPlayer, aLuckyDraw.Steps);
                return;
            }
            if(aLuckyDraw.Type == 5) {
                if(aLuckyDraw.Brand == 1) {
                    this.LuckyDraw_Type5(IDPlayer, 0);
                }
                else {
                    this.LuckyDraw_Type5(IDPlayer, 1);
                }
                return;
            }
            if(aLuckyDraw.Type == 6) {
                this.LuckyDraw_Type6(IDPlayer);
                return;
            }
            if(aLuckyDraw.Type == 7) {
                this.LuckyDraw_Type7(IDPlayer);
                return;
            }
            if(aLuckyDraw.Type == 8) {
                this.LuckyDraw_Type8(IDPlayer, aLuckyDraw.Money);
                return;
            }
        }

        // Được tiền hoặc mất tiền với Ngân hàng
        public void LuckyDraw_Type0(int IDPlayer, int money) {
            if(money >= 0){
                aListPlayer.Find(b => b.ID == IDPlayer).Money += money;
                this.DisplayChangeMoneyPlayer(IDPlayer, money, true);
            }
            else {
                aListPlayer.Find(b => b.ID == IDPlayer).Money += money;
                this.DisplayChangeMoneyPlayer(IDPlayer, -money, false);
            }
            this.Refresh();
        }

        // Được tiền hoặc mất tiền với người chơi khác
        public void LuckyDraw_Type1(int IDPlayer, int money) {
            if(money >= 0) {
                foreach(Player temp in aListPlayer) {
                    if(temp.ID == IDPlayer) {
                        aListPlayer.Find(b => b.ID == IDPlayer).Money += money;
                        this.DisplayChangeMoneyPlayer(IDPlayer, money, true);
                    }
                    else {
                        aListPlayer.Find(b => b.ID == IDPlayer).Money -= money;
                        this.DisplayChangeMoneyPlayer(IDPlayer, money, false);
                    }
                }
            }
            else {
                foreach(Player temp in aListPlayer) {
                    if(temp.ID == IDPlayer) {
                        aListPlayer.Find(b => b.ID == IDPlayer).Money += money;
                        this.DisplayChangeMoneyPlayer(IDPlayer, -money, false);
                    }
                    else {
                        aListPlayer.Find(b => b.ID == IDPlayer).Money -= money;
                        this.DisplayChangeMoneyPlayer(IDPlayer, -money, true);
                    }
                }
            }
            this.Refresh();
        }

        // Đi đến nơi nào đó
        public void LuckyDraw_Type2(int IDPlayer, int IDPlot) {
            this.MoveVehicleNormal(IDPlayer, IDPlot, false, false);
        }

        // Đi đến nơi nào đó và được thưởng tiền
        public void LuckyDraw_Type3(int IDPlayer, int IDPlot) {
            this.MoveVehicleNormal(IDPlayer, IDPlot, false, true);
        }

        // Tiến hoặc lùi ? bước
        public void LuckyDraw_Type4(int IDPlayer, int Steps) {
            int end = aListPlayer.Find(b=>b.ID==IDPlayer).Position += Steps;
            if(end > 40) {
                end -= 40;
            }
            this.MoveVehicleNormal(IDPlayer, end, false, false);
        }

        // Lấy 1 giấy Khí Vận hoặc Cơ Hội
        public void LuckyDraw_Type5(int IDPlayer, int brand) {
            this.takeLuckyDraw(IDPlayer, brand);
        }

        // Vô tù
        public void LuckyDraw_Type6(int IDPlayer) {
            this.MoveVehicleNormal(IDPlayer, 31, false, false);
            aListPlayer.Find(b => b.ID == IDPlayer).GoPrisonByLuckyDraw = true;
        }

        // Thẻ ra tù
        public void LuckyDraw_Type7(int IDPlayer) {
            aListPlayer.Find(b => b.ID == IDPlayer).OutOfJailCard++;
            this.Refresh();
        }

        // Sửa nhà
        public void LuckyDraw_Type8(int IDPlayer, int money) {
            int amountHouse = 0;
            int amountRes = 0;
            foreach(PlayerHouses temp in aListPlayer.Find(b => b.ID == IDPlayer).ListHouses) {
                if(temp.Apartments == 5) {
                    amountRes++;
                }
                else {
                    if(temp.Apartments <= 4 && temp.Apartments >= 1) {
                        amountHouse++;
                    }
                }
            }
            if(money == 300) {
                aListPlayer.Find(b => b.ID == IDPlayer).Money -= (amountRes * 300);
                this.DisplayChangeMoneyPlayer(IDPlayer, money, false);
            }
            else {
                if(money == 25100) {
                    aListPlayer.Find(b => b.ID == IDPlayer).Money -= (amountRes * 100 + amountHouse * 25);
                    this.DisplayChangeMoneyPlayer(IDPlayer, money, false);
                }
            }
        }

    #endregion




    }

    class NextTurnCoord {
        public int ID { get; set; }
        public Point Location { get; set; }

        public NextTurnCoord() {

        }

        public NextTurnCoord(int ID, Point aPoint) {
            this.ID = ID;
            this.Location = aPoint;
        }

        public List<NextTurnCoord> CreateListNextTurnCoord(int amountPlayer){
            List<NextTurnCoord> aListNextTurnCoord = new List<NextTurnCoord>();
            aListNextTurnCoord.Add(new NextTurnCoord(1, new Point(0, 40)));
            aListNextTurnCoord.Add(new NextTurnCoord(2, new Point(1013, 40)));
            if(amountPlayer == 3) {
                aListNextTurnCoord.Add(new NextTurnCoord(3, new Point(0, 363)));
            }
            else {
                if(amountPlayer == 4) {
                    aListNextTurnCoord.Add(new NextTurnCoord(3, new Point(0, 363)));
                    aListNextTurnCoord.Add(new NextTurnCoord(4, new Point(1013, 363)));
                }
            }
            return aListNextTurnCoord;
        }
    }

}
