using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BSU.ASP1501.Day2.Bychkovsky.Task2;

namespace BSU.ASP1501.Day2.Bychkovsky.Task2.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void ToString_withoutArg_allProperties()
        {
            string name = "Eugene";
            string contactPhone = "+ 375 29 887 16 58";
            decimal revenue = 7500000000;
            string ExpectedResult = String.Format("Customer name: {0}\nContact phone: {1}\nRevenue: {2:C}", name, contactPhone, revenue);
              
            Customer user = new Customer("Eugene", "+ 375 29 887 16 58", 7500000000);

            Assert.AreEqual(ExpectedResult, user.ToString());
        }

        [TestMethod]
        public void ToString_withArgN_Name()
        {
            string name = "Eugene";

            string ExpectedResult = String.Format("Customer name: {0}", name);


            Customer user = new Customer("Eugene", "+ 375 29 887 16 58", 7500000000);

            Assert.AreEqual(ExpectedResult, user.ToString("N"));
        }

        [TestMethod]
        public void ToString_withArgP_Phone()
        {
            string contactPhone = "+ 375 29 887 16 58";
            string ExpectedResult = String.Format("Contact phone: "+ contactPhone);

            Customer user = new Customer("Eugene", "+ 375 29 887 16 58", 7500000000);

            Assert.AreEqual(ExpectedResult, user.ToString("P"));
        }

        [TestMethod]
        public void ToString_withArgR_Revenue()
        {
            decimal rev = 7500000000;
            string ExpectedResult = String.Format("Revenue: {0:C}",rev);

            Customer user = new Customer("Eugene", "+ 375 29 887 16 58", 7500000000);

            Assert.AreEqual(ExpectedResult, user.ToString("R"));
        }

        [TestMethod]
        public void ToString_withArgNP_NamePhone()
        {
            string name = "Eugene";
            string contactPhone = "+ 375 29 887 16 58";
            string ExpectedResult = String.Format("Customer name: {0}\nContact phone: {1}", name, contactPhone);

            Customer user = new Customer("Eugene", "+ 375 29 887 16 58", 7500000000);

            Assert.AreEqual(ExpectedResult, user.ToString("NP"));
        }

        [TestMethod]
        public void ToString_withArgNR_NameRev()
        {
            string name = "Eugene";
            decimal revenue = 7500000000;
            string ExpectedResult = String.Format("Customer name: {0}\nRevenue: {1:C}", name, revenue);

            Customer user = new Customer("Eugene", "+ 375 29 887 16 58", 7500000000);

            Assert.AreEqual(ExpectedResult, user.ToString("NR"));
        }

        [TestMethod]
        public void ToString_withArgPR_PhoneRev()
        {
            string contactPhone = "+ 375 29 887 16 58";
            decimal revenue = 7500000000;
            string ExpectedResult = String.Format("Contact phone: {0}\nRevenue: {1:C}", contactPhone, revenue);

            Customer user = new Customer("Eugene", "+ 375 29 887 16 58", 7500000000);

            Assert.AreEqual(ExpectedResult, user.ToString("PR"));
        }

        [TestMethod]
        public void ToString_withUserProvider_allPropertiesLocalUk()
        {
            string name = "Eugene";
            string contactPhone = "+ 375 29 887 16 58";
            decimal revenue = 7500000000;
            CultureInfo uk = new CultureInfo("en-US");
            string ExpectedResult = String.Format(uk, "Customer name: {0}\nContact phone: {1}\nRevenue: {2:C}", name, contactPhone, revenue);

            Customer user = new Customer("Eugene", "+ 375 29 887 16 58", 7500000000);

            Assert.AreEqual(ExpectedResult, user.ToString(uk));
        }
    }
}
