
using Tyuiu.Rahim.Sprint2.Task2.V20.Lib;

namespace Tyuiu.Rahim.Sprint2.Task2.V20.Test
{
  
    public class DataServiceTest
    {
       
        public void CheckDotInShadedArea_Valid()
        {
            DataService ds = new DataService();

            // نقاط داخل ناحیه
            Assert.IsTrue(ds.CheckDotInShadedArea(3, 3));
            Assert.IsTrue(ds.CheckDotInShadedArea(10, 4));
            Assert.IsTrue(ds.CheckDotInShadedArea(4, 10));
            Assert.IsTrue(ds.CheckDotInShadedArea(12, 12));

            // نقاط خارج ناحیه
            Assert.IsFalse(ds.CheckDotInShadedArea(0, 0));
            Assert.IsFalse(ds.CheckDotInShadedArea(2, 2));
            Assert.IsFalse(ds.CheckDotInShadedArea(15, 15));
        }
    }
}