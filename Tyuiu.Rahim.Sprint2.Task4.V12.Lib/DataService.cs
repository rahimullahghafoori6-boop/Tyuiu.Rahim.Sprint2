using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Rahim.Sprint2.Task4.V12.Lib
{
    public class DataService:ISprint2Task4V12
    {
        public double Calculate(double x, double y)
        {
            double result;

            if (Math.Sqrt(x) > y && x >= 2)
            {
                double baseValue = 7 + (2 / (y * y));
                result = Math.Pow(baseValue, x);
            }
            else
            {
                double numerator = (3 * x * x) - Math.Pow(Math.Cos(y), 2) + 10;
                double denominator = (y * y) - Math.Pow(Math.Sin(x), 2) + 12;
                result = numerator / denominator;
            }

            // گرد کردن فقط در انتها
            return Math.Round(result, 3, MidpointRounding.AwayFromZero);
        }
    }
}