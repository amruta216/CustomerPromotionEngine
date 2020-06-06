using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPromotionEngine
{
   class PromotionEngineComboOffer : IPromotionEngineComboOffer
    {

        public double CalcPromotionEngineComboOffer(char CustomerItem, int CustomerQty, double ActualPrice, string PromotionData, ref bool flgPromotionActivate, ref HashSet<char> hsComboSkuID)
        {

            double PromotionPrice = 0;
            string[] ArrPromotionData;
            int PromotionQty;
            char ComboPromotionSkuID;

            try
            {
                ArrPromotionData = PromotionData.Split('~');

                PromotionQty = Convert.ToInt16(ArrPromotionData[0]);
                ComboPromotionSkuID = Convert.ToChar(ArrPromotionData[1]);

                if (ComboPromotionSkuID != '0')
                {
                    hsComboSkuID.Add(ComboPromotionSkuID);
                    PromotionPrice = Convert.ToDouble(ArrPromotionData[2]);
                    flgPromotionActivate = true;
                    CustomerQty = CustomerQty - 1;
                    PromotionPrice = PromotionPrice + (ActualPrice * CustomerQty);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {

            }
            return PromotionPrice;

        }
    }
}
