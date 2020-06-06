using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CustomerPromotionEngine
{
    public class XUnitPromotionEngineTestCases
    {
        // Here we can give test data through [Theory], but due to time limit I have creates just simple test case
        [Fact]
        public void TestCalculateCustomerTotal()
        {
            // Create instance to take test data
            ClassforAllTestData objPromotionEngineTestDataClass = new ClassforAllTestData();
            List<CustomerCart> objCustomerCartList = objPromotionEngineTestDataClass.CustomerOrderData();
            ICustomerTotal objCalculateTotalEngine = new EngineToCalculateTotal();
            Assert.Equal(370, objCalculateTotalEngine.CalculateCustomerTotal(objCustomerCartList));
        }
    }
}
