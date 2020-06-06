using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPromotionEngine
{

    interface IPromotionEngineFixedPrice
    {
        double CalcPromotionEngineFixedPrice();
    }
    interface IPromotionEngineComboOffer
  {
        double CalcPromotionEngineComboOffer();
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
