using System;
using BSU.ASP1501.Day2.Bychkovsky.Task3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BSU.ASP1501.Day2.Bychkovsky.Task3.Test
{
    [TestClass]
    public class ToHexadecimalFormatProviderTest
    {
        [TestMethod]
        public void Format_100inHesSystem_64()
        {
            string ExpectedString = String.Format("{0:X}", 100);

            IFormatProvider fp = new ToHexadecimalFormatProvider();
            string result = String.Format(fp, "{0:H}", 100);

            Assert.AreEqual(ExpectedString, result);
        }
    

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Format_nullArgument_ArgumentNullException()
        {
            Exception error = new ArgumentNullException();

            IFormatProvider fp = new ToHexadecimalFormatProvider();
            string result = String.Format(fp, "{0:H}", null);

            Assert.AreEqual(error, result);
        }
    }
}
