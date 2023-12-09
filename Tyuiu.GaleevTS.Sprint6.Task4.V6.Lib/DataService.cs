using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GaleevTS.Sprint6.Task4.V6.Lib
{
    public class DataService : ISprint6Task4V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mtrx;
            int len = (stopValue - startValue) + 1;
            mtrx = new double[len];
            int index = 0;
            double y = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Round(((3 * Math.Cos(i)) / (4 * i - 0.5)) + Math.Sin(i) - 5 * i - 2, 3);
                mtrx[index] = y;
                index++;
            }
            return mtrx;
        }
    }
}
