using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Rahim.Sprint2.Task2.V20.Lib
{
    public class DataService:ISprint2Task2V20
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // ناحیه سایه‌دار: مستطیل‌های ترکیبی (به عنوان مثال)
            // فرض: ناحیه شامل:
            // 1. مستطیل افقی بالا: x از 3 تا 10 و y از 3 تا 4
            // 2. مستطیل عمودی: x از 3 تا 4 و y از 5 تا 10
            // 3. مستطیل پایین: x از 5 تا 12 و y از 11 تا 12
            // (این مقادیر باید با شکل واقعی تطبیق داده شوند)

            bool condition1 = (x >= 3) && (x <= 6) && (y >= 3) && (y <= 5);
            bool condition2 = (x >= 6) && (x <= 8) && (y >= 5) && (y <= 10);
            bool condition3 = (x >= 8) && (x <= 12) && (y >= 8) && (y <= 12);
            bool condition4 = (x >= 2) && (x <= 5) && (y >= 10);

            return condition1 || condition2 || condition3;
        }
    }
}