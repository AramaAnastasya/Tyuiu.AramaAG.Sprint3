﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint3.Task5.V8.Lib;

namespace Tyuiu.AramaAG.Sprint3.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 12;
            double res = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);
            Assert.AreEqual(119.066, res);
        }
    }
}
