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
        int countTick = 0;
        int tickLimit = 0;
        int X = 0;
        int Y = 0;


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

        public void frmMain_Load() {
            aListPlotInfo = this.ReadFilePlotInfo();
            this.ClassifyLuckyDraw(this.ReadFileLuckyDraw());

            //aucLuckyDrawCard = new ucLuckyDrawCard(1, aListCommunityChest[0].Content);
            //aucLuckyDrawCard.Location = new Point(630, 450);
            //this.Controls.Add(aucLuckyDrawCard);
            //aucLuckyDrawCard.BringToFront();
            //aucLuckyDrawCard.Visible = true;

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
                int type = int.Parse(read.ReadLine());
                string content = read.ReadLine();
                aList.Add(new LuckyDraw(brand, money, type, content));
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
            if(amountPlayer == 3) {
                lblNamePlayer3.Text = aListPlayer[2].Name;
                lblMoneyPlayer3.Text = aListPlayer[2].Money.ToString();
            }
            else {
                if(amountPlayer == 4) {
                    lblNamePlayer3.Text = aListPlayer[2].Name;
                    lblMoneyPlayer3.Text = aListPlayer[2].Money.ToString();
                    lblNamePlayer4.Text = aListPlayer[3].Name;
                    lblMoneyPlayer4.Text = aListPlayer[3].Money.ToString();
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

        public void terCountdownClockStart(){
            terCountdownClock.Start();
        }
    #endregion

    #region Xử lý xúc xắc
        private void pboDice_Click(object sender, EventArgs e) {
            this.StartDice();
        }

        private void terDice_Tick(object sender, EventArgs e) {
            pboResultDice1.Visible = false;
            pboResultDice2.Visible = false;
            pboDice.Visible = true;
            terDice.Stop();
        }

        private void terHidenDice_Tick(object sender, EventArgs e) {
            this.EnalbleDice();
        }

        public void StartDice() {
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
                    destinationVehicle = aListPlayer.Find(b => b.ID == turnPlayer).Position + currentDice;
                    if(destinationVehicle > 40) {
                        destinationVehicle -= 40;
                    }
                    this.MoveVehicleNormal(destinationVehicle);
                    terHidenDice.Start();
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
                        this.MoveVehicleNormal(destinationVehicle);
                        terHidenDice.Start();
                    }
                    else {

                    }
                }
            }
        }

        public void MoveVehicleNormal(int end) {
            aListPlayer.Find(b => b.ID == turnPlayer).VehicleImage.Location = this.PositionCenter(end);
            aListPlayer.Find(b => b.ID == turnPlayer).VehicleImage.BringToFront();
            aListPlayer.Find(b => b.ID == turnPlayer).Position = end;
            tssPlayerMoving.Text = aListPlayer.Find(b => b.ID == turnPlayer).Name;
            tssPlayerMovingPlot.Text = aListPlotInfo.Find(b => b.ID == end).Name;
            
            this.PlotAccess(end);
        }

        public void EnalbleDice() {
            this.popDeedCard2.Visible = false;
            this.popStatusMoneyPlayer.Visible = false;
            this.pboDice.Enabled = true;
            this.terHidenDice.Stop();
            this.NextTurnEffect();
        }

    #endregion

        public void PlayingProcess(){
            //terWaitDice.Start();
        }

        public void PlotAccess(int pos) {
            this.currentPosition = pos;
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
                    if(aPlotInfo.Type == 0) {
                        this.MoneyTaxPlot(pos);
                    }
                }
            }
            else {
                if(aPlotInfo.Status == 1 && aPlotInfo.Type == 3) {
                    this.MoneyLeasePlot1(pos);
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

        public void MoneyLeasePlot1(int pos) {
            foreach(Player temp in aListPlayer) {
                foreach(PlayerHouses temp1 in temp.ListHouses) {
                    if(temp1.IDPlot == pos) {
                        if(turnPlayer != temp.ID) {
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
                            aListPlayer.Find(b => b.ID == turnPlayer).Money -= money;
                            lblStatusMoneyPlayer.Text = aListPlayer.Find(b => b.ID == turnPlayer).Name + " vừa trả " + temp.Name + " tiền thuê nhà: " + money.ToString();
                            popStatusMoneyPlayer.Location = this.PositionCenter(pos);
                            popStatusMoneyPlayer.BringToFront();
                            popStatusMoneyPlayer.Show();
                            this.LoadPlayer();
                            break;
                        }
                    }
                }
            }
        }

        public void MoneyTaxPlot(int pos) {
            PlotInfo aPlotInfo = new PlotInfo();
            aPlotInfo = aListPlotInfo.Find(b => b.ID == pos);
            if(aPlotInfo.PricePlot > 0) {
                aListPlayer.Find(b => b.ID == turnPlayer).Money -= aPlotInfo.PricePlot;
                lblStatusMoneyPlayer.Text = aListPlayer.Find(b => b.ID == turnPlayer).Name + " vừa trả " + aPlotInfo.Name + ": " + aPlotInfo.PricePlot.ToString();
                popStatusMoneyPlayer.Location = this.PositionCenter(pos);
                popStatusMoneyPlayer.BringToFront();
                popStatusMoneyPlayer.Show();
                this.LoadPlayer();
            }
        }

        private void terWaitDice_Tick(object sender, EventArgs e) {
            this.StartDice();
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
                MessageBox.Show("Bạn không đủ tiền để mua ô đất này.", "Mua đất", MessageBoxButtons.OK);
                this.popDeedCard2.Visible = false;
                this.EnalbleDice();
            }
            
        }

        private void picNo_DeedCard2_Click(object sender, EventArgs e) {
            this.popDeedCard2.Visible = false;
            this.EnalbleDice();
        }

        

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
