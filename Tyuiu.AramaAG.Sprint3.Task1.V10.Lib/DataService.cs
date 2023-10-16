using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AramaAG.Sprint3.Task1.V10.Lib
{
    public class DataService : ISprint3Task1V10
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double p = 0;
            while(startValue <= stopValue)
            {
                p += Math.Pow(1.0 / (startValue + Math.Pow(value, startValue)), startValue);
                startValue++;
            }
            return Math.Round(p, 3);
        }
    }
}
