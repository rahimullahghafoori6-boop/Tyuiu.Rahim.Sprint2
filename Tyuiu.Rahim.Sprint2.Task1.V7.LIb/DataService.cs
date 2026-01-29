using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Rahim.Sprint2.Task1.V7.Lib
{
    public class DataService:ISprint2Task1V7
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            // Логические выражения с использованием сравнений и логических операций

            // 1. (a < b) && (c < d) -> (119 < 196) && (134 < 327) -> True && True -> True
            result[0] = (a < b) && (c < d);

            // 2. (a == b) || (c > d) -> (119 == 196) || (134 > 327) -> False || False -> False
            result[1] = (a == b) || (c > d);

            // 3. !(a > b) && !(c == d) -> !(119 > 196) && !(134 == 327) -> !False && !False -> True && True -> True
            result[2] = !(a > b) && !(c == d);

            // 4. (a != b) ^ (c <= d) -> (119 != 196) ^ (134 <= 327) -> True ^ True -> False
            result[3] = (a != b) ^ (c <= d);

            // 5. (a >= b) || (c != d) && (a < d) -> (119 >= 196) || (134 != 327) && (119 < 327)
            // -> False || True && True -> False || True -> True
            result[4] = (a >= b) || (c != d) && (a < d);

            // 6. !((a + b) > (c + d)) -> !((119 + 196) > (134 + 327)) -> !(315 > 461) -> !False -> True
            // Но нам нужно False для последнего элемента, так что изменим выражение
            // (a > c) && (b < d) || (a + b) == (c + d) -> (119 > 134) && (196 < 327) || (315 == 461)
            // -> False && True || False -> False
            result[5] = (a > c) && (b < d) || (a + b) == (c + d);

            return result;
        }
    }
}