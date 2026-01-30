
using Tyuiu.Rahim.Sprint2.Task3.V21.Lib;
using System;

namespace Tyuiu.Rahim.Sprint2.Task3.V21.Test
{
    
    public class DataServiceTest
    {
        public DataServiceTest()
        {
        }
        public void ValidCalculateXGreaterThanOne()
        {
            DataService ds = new DataService();
            double x = 5;
            double fraction = (5 + 9) / (5 - 1); // 14/4 = 3.5
            double expected = 5 * Math.Pow(fraction, 5); // 5 * 3.5^5
            expected = Math.Round(expected, 3);
            Assert.AreEqual(expected, ds.Calculate(x));
        }

        
        public void ValidCalculateXEqualsZero()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = Math.Round((0 + 10) / (0 - Math.Sin(0) + 12), 3); // 10/12 = 0.833
            Assert.AreEqual(wait, ds.Calculate(x));
        }

        
        public void ValidCalculateXBetweenMinus25And2()
        {
            DataService ds = new DataService();
            double x = -5;
            double wait = Math.Pow(1 + 1 / Math.Pow(-5, 2), -5); // (1 + 1/25)^(-5) = (1.04)^(-5)
            wait = Math.Round(wait, 3);
            Assert.AreEqual(wait, ds.Calculate(x));
        }

        public void ValidCalculateXLessThanMinus25()
        {
            DataService ds = new DataService();
            double x = -30;
            double wait = Math.Round(11 * (-30) - (1.0 / (-30)), 3); // -330 + 0.03333
            Assert.AreEqual(wait, ds.Calculate(x));
        }

       
        public void InvalidCalculateXEqualsOne()
        {
            DataService ds = new DataService();
            double x = 1;
            Assert.ThrowsException<ArgumentException>(() => ds.Calculate(x));
        }

        
        public void InvalidCalculateXEqualsMinus25()
        {
            DataService ds = new DataService();
            double x = -25;
            Assert.ThrowsException<ArgumentException>(() => ds.Calculate(x));
        }
    }
}