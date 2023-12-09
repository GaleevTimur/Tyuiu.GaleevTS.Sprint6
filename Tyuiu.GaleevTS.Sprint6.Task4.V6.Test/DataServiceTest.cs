using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GaleevTS.Sprint6.Task4.V6.Lib;

namespace Tyuiu.GaleevTS.Sprint6.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest

    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] wait = ds.GetMassFunction(startValue, stopValue);
            double[] res = { 23.917, 18.876, 13.096, 7.238, 1.798, -8, -5.695, -11.257, -17.117, -22.883, -27.915 };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
