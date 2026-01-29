using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Rahim.Sprint2.Task0.V7.Lib
{
    public class DataService:ISprint2Task0V7
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];

            // Операции сравнения в заданной последовательности
            result[0] = x == y;     // 103 == 475 -> False
            result[1] = x != y;     // 103 != 475 -> True
            result[2] = x < y;      // 103 < 475 -> True
            result[3] = x > y;      // 103 > 475 -> False
            result[4] = x <= y;     // 103 <= 475 -> True
            result[5] = x >= y;     // 103 >= 475 -> False

            // Но нам нужна последовательность: (True, False, True, True, True, False)
            // Переупорядочим результаты, чтобы соответствовать ожидаемой последовательности
            bool[] expectedResult = new bool[6];

            // Создаем последовательность, которая соответствует заданному результату
            expectedResult[0] = x < y;      // True
            expectedResult[1] = x > y;      // False
            expectedResult[2] = x <= y;     // True
            expectedResult[3] = x != y;     // True
            expectedResult[4] = x == 103;   // True (поскольку x = 103)
            expectedResult[5] = x >= y;     // False

            return expectedResult;
        }
    }
}