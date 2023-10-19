using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint3.Task1.V10.Lib;

namespace Tyuiu.AramaAG.Sprint3.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();
            double value = 5;
            int startValue = 1;
            int stopValue = 17;
            double p = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(0.168, p);
        }
    }
}
