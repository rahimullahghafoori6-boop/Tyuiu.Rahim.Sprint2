using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Rahim.Sprint2.Task1.V1.Lib
{
    public class DataService:ISprint2Task1V1
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] results = new bool[6];

            // 1
            results[0] = (a < b) && (c < d);

            // 2
            results[1] = (a > b) || (c > d);

            // 3
            results[2] = (a + 10 == b - 75) ^ (c != d);

            // 4
            results[3] = !(a <= b) && (c >= d);

            // 5
            results[4] = (a + 100 > b) || (c < d - 150);

            // 6
            results[5] = (b == c) && (a != d);

            return results;
        }
    }
}