using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPromotionEngine
{
    class ClassforAllTestData
    {
        public Hashtable hsItemHashTable = new Hashtable();
        public Hashtable hsPromotionHashTable = new Hashtable();

        public void AddItemTestData()
        {
            hsItemHashTable.Add('A', 50);
            hsItemHashTable.Add('B', 30);
            hsItemHashTable.Add('C', 20);
            hsItemHashTable.Add('D', 15);
        }

        public void AddPromotionTestData()
        {
            string PromotionData = "3~0~130";
            hsPromotionHashTable.Add('A', PromotionData);

            PromotionData = "2~0~45";
            hsPromotionHashTable.Add('B', PromotionData);

            PromotionData = "0~D~30";
            hsPromotionHashTable.Add('C', PromotionData);
        }

        public List<CustomerCart> CustomerOrderData()
        {
            List<CustomerCart> MyCustomerCartList = new List<CustomerCart>();
            MyCustomerCartList.Add(new CustomerCart('A', 5));
            MyCustomerCartList.Add(new CustomerCart('B', 5));
            MyCustomerCartList.Add(new CustomerCart('C', 1));
            //MyCustomerCartList.Add(new CustomerCart('D', 1));

            return MyCustomerCartList;
        }

    }
}
