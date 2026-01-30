
using Tyuiu.Rahim.Sprint2.Task4.V12.Lib;

namespace Tyuiu.Rahim.Sprint2.Task4.V12.Test
{
   
    public class DataServiceTest
    {
        
        public void ValidCalculateConditionTrue()
        {
            // شرایط: sqrt(x) > y && x >= 2
            DataService ds = new DataService();
            double x = 4;  // sqrt(4)=2
            double y = 1;  // 2 > 1
            double wait = Math.Pow(7 + (2 / Math.Pow(1, 2)), 4); // (7+2)^4 = 9^4 = 6561
            wait = Math.Round(wait, 3);
            Assert.AreEqual(wait, ds.Calculate(x, y));
        }

        
        public void ValidCalculateConditionFalse()
        {
            // شرایط: sqrt(x) <= y یا x < 2
            DataService ds = new DataService();
            double x = 1;  // x < 2
            double y = 5;
            double numerator = 3 * Math.Pow(1, 2) - Math.Pow(Math.Cos(5), 2) + 10;
            double denominator = Math.Pow(5, 2) - Math.Pow(Math.Sin(1), 2) + 12;
            double wait = numerator / denominator;
            wait = Math.Round(wait, 3);
            Assert.AreEqual(wait, ds.Calculate(x, y));
        }

        
        public void ValidCalculateConditionFalse2()
        {
            // sqrt(x) <= y
            DataService ds = new DataService();
            double x = 9;  // sqrt(9)=3
            double y = 5;  // 3 <= 5
            double numerator = 3 * Math.Pow(9, 2) - Math.Pow(Math.Cos(5), 2) + 10;
            double denominator = Math.Pow(5, 2) - Math.Pow(Math.Sin(9), 2) + 12;
            double wait = numerator / denominator;
            wait = Math.Round(wait, 3);
            Assert.AreEqual(wait, ds.Calculate(x, y));
        }

        
        public void ValidCalculateEdgeCase()
        {
            // x = 2, sqrt(2)≈1.414
            DataService ds = new DataService();
            double x = 2;
            double y = 1;  // 1.414 > 1
            double wait = Math.Pow(7 + (2 / Math.Pow(1, 2)), 2); // 9^2 = 81
            wait = Math.Round(wait, 3);
            Assert.AreEqual(wait, ds.Calculate(x, y));
        }
    }
}