using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GaleevTS.Sprint6.Task0.V5.Lib;

namespace Tyuiu.GaleevTS.Sprint6.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(5);
            double wait = -39.75;
            Assert.AreEqual(wait, res);
        }
    }
}
