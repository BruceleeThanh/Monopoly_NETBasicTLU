using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MonopolyProject {
    public class PlotInfo {
        public int ID { get; set; }
        public int X1Coord{get; set;}
        public int Y1Coord { get; set; }
        public int X2Coord { get; set; }
        public int Y2Coord { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int PricePlot { get; set; }
        public int Type { get; set; } // 0: corner, tax / 1: COMMUNITY CHEST / 2: CHANCE / 3: House / 4: Coach station / 5: Company
        public int LeaseLand { get; set; }
        public int LeaseOneHouse { get; set; }
        public int LeaseTwoHouses { get; set; }
        public int LeaseThreeHouses { get; set; }
        public int LeaseFourHouses { get; set; }
        public int LeaseRes { get; set; } // Res is Restaurant
        public int PriceHouse { get; set; }
        public int PriceRes { get; set; } // Res is Restaurant
        public int Pawn { get; set; }

        public int Status { get; set; }

        public PlotInfo() {

        }

        public PlotInfo(int ID, int X1Coord, int Y1Coord, int X2Coord, int Y2Coord, string Name, string Color, int PricePlot, int Type,
            int LeaseLand, int LeaseOneHouse, int LeaseTwoHouses, int LeaseThreeHouses, int LeaseFourHouses, int LeaseRes, int PriceHouse, int PriceRes, int Pawn, int Status) {
            this.ID = ID;
            this.X1Coord = X1Coord;
            this.Y1Coord = Y1Coord;
            this.X2Coord = X2Coord;
            this.Y2Coord = Y2Coord;
            this.Name = Name;
            this.Color = Color;
            this.PricePlot = PricePlot;
            this.Type = Type;
            this.LeaseLand = LeaseLand;
            this.LeaseOneHouse = LeaseOneHouse;
            this.LeaseTwoHouses = LeaseTwoHouses;
            this.LeaseThreeHouses = LeaseThreeHouses;
            this.LeaseFourHouses = LeaseFourHouses;
            this.LeaseRes = LeaseRes;
            this.PriceHouse = PriceHouse;
            this.PriceRes = PriceRes;
            this.Pawn = Pawn;
            this.Status = Status;
        }

    }
}
