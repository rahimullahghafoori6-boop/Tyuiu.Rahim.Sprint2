using System;

namespace Tyuiu.Rahim.Sprint2.Task3.V21.Lib
{
    public class DataService
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                // y = x * ((x+9)/(x-1))^x
                double fraction = (x + 9) / (x - 1);
                y = x * Math.Pow(fraction, x);
            }
            else if (x == 0)
            {
                y = (Math.Pow(x, 2) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
                // برای x=0: (0+10)/(0 - sin(0) + 12) = 10/12 = 0.833333...
            }
            else if (x > -25 && x < 2)  // -25 < x < 2
            {
                y = Math.Pow(1 + 1 / Math.Pow(x, 2), x);
            }
            else if (x < -25)
            {
                y = 11 * x - (1 / x);  // x + 10x - 1/x = 11x - 1/x
            }
            else
            {
                // مقادیر مرزی: x=1, x=2, x=-25
                throw new ArgumentException($"Значение x={x} не попадает ни в один диапазон вычислений");
            }

            return Math.Round(y, 3);
        }
    }
}