using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPromotionEngine
{
    class EngineToCalculateTotal : ICustomerTotal
    {
        public double CalculateCustomerTotal(List<CustomerCart> objCustomerCartList)
        {
            double CustomerTotal = 0;
            double tempPromotionPrice = 0;
            double ActualPrice = 0;
            double ComboPromotionPrice = 0;
            double FixedPromotionPrice = 0;
            double tempCustomerTotal = 0;
            char CustomerItem;
            int CustomerQty;
            bool flgPromotionComboActivate = false;
            bool flgPromotionFixedActivate = false;
            string PromotionalData;

            try
            {

                ClassforAllTestData objPromotionEngineTestDataClass = new ClassforAllTestData();
                objPromotionEngineTestDataClass.AddItemTestData();
                objPromotionEngineTestDataClass.AddPromotionTestData();

                Hashtable hsItemAndPromotionPrice = new Hashtable();

                HashSet<Char> hsComboSkuID = new HashSet<Char>();

                IPromotionEngineFixedPrice objPromotionEngineFixedPrice = new PromotionEngineFixedPrice();
                IPromotionEngineComboOffer objPromotionEngineComboOffer = new PromotionEngineComboOffer();

                foreach (var item in objCustomerCartList)
                {
                    CustomerItem = item.SkuID;
                    CustomerQty = item.Qty;

                    ActualPrice = Convert.ToDouble(objPromotionEngineTestDataClass.hsItemHashTable[CustomerItem]);
                    PromotionalData = Convert.ToString(objPromotionEngineTestDataClass.hsPromotionHashTable[CustomerItem]);

                    if (flgPromotionComboActivate == false)
                    {
                        FixedPromotionPrice = objPromotionEngineFixedPrice.CalcPromotionEngineFixedPrice(CustomerItem, CustomerQty, ActualPrice, PromotionalData, ref flgPromotionFixedActivate);
                    }
                    else if (flgPromotionFixedActivate == false)
                    {
                        ComboPromotionPrice = objPromotionEngineComboOffer.CalcPromotionEngineComboOffer(CustomerItem, CustomerQty, ActualPrice, PromotionalData, ref flgPromotionComboActivate, ref hsComboSkuID);
                    }

                    if (hsComboSkuID.Contains(CustomerItem))
                    {
                        CustomerQty = CustomerQty - 1;
                        tempPromotionPrice = CustomerQty * ActualPrice;
                    }
                    else if (flgPromotionComboActivate == false && FixedPromotionPrice == 0)
                    {
                        tempPromotionPrice = CustomerQty * ActualPrice;
                    }

                    tempCustomerTotal = FixedPromotionPrice + ComboPromotionPrice + tempPromotionPrice;
                    FixedPromotionPrice = 0;
                    ComboPromotionPrice = 0;
                    tempPromotionPrice = 0;

                    CustomerTotal = CustomerTotal + tempCustomerTotal;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {

            }

            return CustomerTotal;
        }
    }
}
