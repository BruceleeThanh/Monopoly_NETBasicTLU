using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyProject {
    public class LuckyDraw {
        public int Brand { get; set; }
        public int Money { get; set; }
        public int ToPlot { get; set; }
        public int Steps { get; set; }
        public int Type { get; set; }
        public string Content { get; set; }
        public int status { get; set; }

        public LuckyDraw(int Brand, int Money, int ToPlot, int Steps, int Type, string Content) {
            this.Brand = Brand;
            this.Money = Money;
            this.ToPlot = ToPlot;
            this.Steps = Steps;
            this.Type = Type;
            this.Content = Content;
        }

    }
}
