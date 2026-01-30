using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Rahim.Sprint2.Task4.V12.Lib
{
    public class DataService:ISprint2Task4V12
    {
        public double Calculate(double x, double y)
        {
            // استفاده از عملگر سه‌تایی (Ternary Operator)
            double result = (Math.Sqrt(x) > y && x >= 2)
                ? Math.Pow(7 + (2 / Math.Pow(y, 2)), x)
                : (3 * Math.Pow(x, 2) - Math.Pow(Math.Cos(y), 2) + 10) / (Math.Pow(y, 2) - Math.Pow(Math.Sin(x), 2) + 12);

            return Math.Round(result, 3);
        }
    }
}