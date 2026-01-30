using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Rahim.Sprint2.Task3.V21.Lib
{
    public class DataService:ISprint2Task3V21
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                y = Math.Pow(x + 9, x) / (x - 1);
            }
            else if (x == 0)
            {
                y = (Math.Pow(x, 2) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
                // وقتی x=0 باشد: (0+10)/(0 - sin(0) + 12) = 10/12 = 0.833333...
            }
            else if (x > -25 && x < 2)  // -25 < x < 2
            {
                y = Math.Pow(1 + 1 / Math.Pow(x, 2), x);
            }
            else if (x < -25)
            {
                y = x + 10 * x - (1 / x);  // x + 10x - (1/x) = 11x - 1/x
            }
            else
            {
                // برای x=1 یا x=2 یا x=-25 (مقادیر مرزی)
                // طبق شرط: x>1 جداگانه، x=0 جداگانه، -25<x<2 جداگانه، x<-25 جداگانه
                // پس x=1 و x=2 و x=-25 در هیچ‌کدام نیستند؟ باید بررسی شود
                // طبق منطق: x=1 در هیچ‌کدام نیست، پس خطا می‌دهیم یا مقدار پیش‌فرض
                throw new ArgumentException("Значение x не попадает ни в один диапазон вычислений");
            }

            return Math.Round(y, 3);
        }
    }
}