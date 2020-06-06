using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPromotionEngine
{
    // Class of Customer Cart (SkuID, Qty)
    class CustomerCart
    {
        private char skuid;
        private int qty;
        public CustomerCart(char SkuID, int Qty)
        {
            this.skuid = SkuID;
            this.qty = Qty;
        }

        public char SkuID
        { get { return skuid; } }

        public int Qty
        { get { return qty; } }
    }
}
