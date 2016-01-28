using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyProject {
    public class LuckyDraw {
        public int Brand { get; set; }
        public int Money { get; set; }
        public int Type { get; set; }
        public string Content { get; set; }

        public LuckyDraw(int Brand, int Money, int Type, string Content) {
            this.Brand = Brand;
            this.Money = Money;
            this.Type = Type;
            this.Content = Content;
        }

    }
}
