using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace MonopolyProject {
    public class Player {
        public int ID { get; set; }
        public string Name {get; set;}
        public string Vehicle { get; set; }
        public int Money { get; set; }
        public int Position { get; set; } // plot = ?
        public int OutOfJailCard { get; set; }
        public bool GoPrisonByLuckyDraw { get; set; }

        public List<PlayerOwes> ListOwes = new List<PlayerOwes>();

        public List<PlayerHouses> ListHouses = new List<PlayerHouses>();
        public PictureEdit VehicleImage { get; set; }

    }

    public class PlayerOwes {
        public int IDLender { get; set; }
        public int Money { get; set; }
    }

    public class PlayerHouses {
        public int IDPlot { get; set; }
        public string Name { get; set; }
        public int Apartments { get; set; }
        public int Spent { get; set; }
        public int Status { get; set; }

        public LabelControl HouseLabel = new LabelControl();

    }
}
