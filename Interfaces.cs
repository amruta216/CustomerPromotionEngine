using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPromotionEngine
{

    interface IPromotionEngineFixedPrice
    {
        double CalcPromotionEngineFixedPrice(char CustomerItemID, int CustomerQty, double ActualPrice, string PromotionData, ref bool flgPromotionActivate);
    }
    interface IPromotionEngineComboOffer
    {
        double CalcPromotionEngineComboOffer(char CustomerItemID, int CustomerQty, double ActualPrice, string PromotionData, ref bool flgPromotionActivate, ref HashSet<char> hsComboSkuID);
    }

    // Similarly interface for %
    //interface IPromotionEnginePercentage
    //{
    //    double CalcPromotionEnginePercentage();
    //}
    interface ICustomerTotal
    {       
        double CalculateCustomerTotal(List<CustomerCart> objCustomerCartList);
    }
}
