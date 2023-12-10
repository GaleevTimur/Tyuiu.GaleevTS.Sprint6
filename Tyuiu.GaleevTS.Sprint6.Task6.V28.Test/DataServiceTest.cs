using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.GaleevTS.Sprint6.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\timur_8n182p8\source\repos\Tyuiu.GaleevTS.Sprint6\Tyuiu.GaleevTS.Sprint6.Task6.V28\bin\Debug\InPutFileTask6V28.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
