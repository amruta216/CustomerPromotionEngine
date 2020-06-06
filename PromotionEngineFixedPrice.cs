using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPromotionEngine
{
    class PromotionEngineFixedPrice : IPromotionEngineFixedPrice
    {
       public double CalcPromotionEngineFixedPrice(char CustomerItem, int CustomerQty, double ActualPrice, string PromotionalData, ref bool flgPromotionActivate)
            {
                int CustomerQuantity = 0;
                double PromotionPrice = 0;
                string[] ArrPromotionData;
                int PromotionQty;
                char ComboPromotionSkuID;
                double tempPromotionPrice = 0;

                try
                {

                    ArrPromotionData = PromotionalData.Split('~');

                    PromotionQty = Convert.ToInt16(ArrPromotionData[0]);
                    ComboPromotionSkuID = Convert.ToChar(ArrPromotionData[1]);

                    CustomerQuantity = CustomerQty;

                    while (CustomerQuantity > 0)
                    {
                        if (ComboPromotionSkuID != '0')
                        {
                            CustomerQuantity = 0;
                            break;
                        }
                        if (PromotionQty <= CustomerQuantity)
                        {
                            tempPromotionPrice = Convert.ToDouble(ArrPromotionData[2]);
                            CustomerQuantity = CustomerQty - PromotionQty;
                            flgPromotionActivate = true;
                            PromotionPrice = PromotionPrice + tempPromotionPrice;
                            CustomerQty = CustomerQuantity;
                        }
                        else if (CustomerQuantity < PromotionQty)
                        {
                            PromotionPrice = PromotionPrice + (ActualPrice * CustomerQuantity);
                            break;
                        }
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {

                }

                return PromotionPrice;
            }
        }
    }
