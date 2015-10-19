using System;
using BSU.ASP1501.Day2.Bychkovsky.Task4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BSU.ASP1501.Day2.Bychkovsky.Task4.Test
{
    [TestClass]
    public class LogicEuclidMethodTest
    {
        [TestMethod]
        public void GCD_35and15_5()
        {
            int ExpectedResult = 5;

            Assert.AreEqual(ExpectedResult, LogicEuclidMethod.GCD(35, 15));
        }

        [TestMethod]
        public void GCD_36and15and27_3()
        {
            int ExpectedResult = 3;

            Assert.AreEqual(ExpectedResult, LogicEuclidMethod.GCD(36, 15, 27));
        }

        [TestMethod]
        public void GCD_36and155and33and345and12_1()
        {
            int ExpectedResult = 1;

            Assert.AreEqual(ExpectedResult, LogicEuclidMethod.GCD(36, 155, 33, 345, 12));
        }

        [TestMethod]
        public void BinaryAlgorithm_45and15_15()
        {
            int ExpectedResult = 15;

            Assert.AreEqual(ExpectedResult, LogicEuclidMethod.BinaryAlgorithm(45, 15));
        }

        [TestMethod]
        public void BinaryAlgorithm_36and15and27_3()
        {
            int ExpectedResult = 3;

            Assert.AreEqual(ExpectedResult, LogicEuclidMethod.BinaryAlgorithm(36, 15, 27));
        }

        [TestMethod]
        public void BinaryAlgorithm_36and15and27and414and3000_3()
        {
            int ExpectedResult = 3;

            Assert.AreEqual(ExpectedResult, LogicEuclidMethod.BinaryAlgorithm(36, 15, 27, 414, 3000));
        }
    }
}
