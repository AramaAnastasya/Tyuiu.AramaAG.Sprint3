using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint3.Task6.V9.Lib;

namespace Tyuiu.AramaAG.Sprint3.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 19;
            int stopValue = 30;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(53, res);
        }
    }
}
