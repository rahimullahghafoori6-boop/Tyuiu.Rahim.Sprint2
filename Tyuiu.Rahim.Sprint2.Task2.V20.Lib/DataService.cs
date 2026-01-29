using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Rahim.Sprint2.Task2.V20.Lib
{
    public class DataService:ISprint2Task2V20
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            int yCorrect = 16 - y; // اصلاح محور Y

            bool part1 = (x >= 3 && x <= 6 && yCorrect >= 3 && yCorrect <= 5);
            bool part2 = (x >= 6 && x <= 8 && yCorrect >= 5 && yCorrect <= 10);
            bool part3 = (x >= 8 && x <= 12 && yCorrect >= 8 && yCorrect <= 12);
            bool part4 = (x >= 2 && x <= 5 && yCorrect == 10);

            return part1 | part2 || part3 || part4;
        }
    }
}