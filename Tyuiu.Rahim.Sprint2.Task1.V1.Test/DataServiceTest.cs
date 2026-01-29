using System;
using Tyuiu.Rahim.Sprint2.Task1.V1.Lib;

namespace Tyuiu.Rahim.Sprint2.Task1.V1.Test
{

    public class DataServiceTest
    {
        
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 119, b = 196, c = 134, d = 327;
            bool[] wait = new bool[] { true, false, true, false, true, false };
            bool[] result = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, result);
        }
    }
}