﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            double CustomerTotal;

            // Create instance to take test data
            ClassforAllTestData objPromotionEngineTestDataClass = new ClassforAllTestData();
            List<CustomerCart> objCustomerCartList = objPromotionEngineTestDataClass.CustomerOrderData();

            // Important method to calculate customer Total
            ICustomerTotal objCalculateTotalEngine = new EngineToCalculateTotal();

            CustomerTotal = objCalculateTotalEngine.CalculateCustomerTotal(objCustomerCartList);

            Console.WriteLine("CustomerTotal: " + CustomerTotal);

            Console.ReadLine();
        }
    }
}
