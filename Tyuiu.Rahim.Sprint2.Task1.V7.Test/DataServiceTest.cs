using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Rahim.Sprint2.Task0.V7.Lib;

namespace Tyuiu.Rahim.Sprint2.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();

            int x = 103;
            int y = 475;
            bool[] wait = new bool[6] { true, false, true, true, true, false };

            bool[] res = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestFirstElement()
        {
            DataService ds = new DataService();
            int x = 103;
            int y = 475;
            bool[] res = ds.GetCompareOperations(x, y);v
            Assert.AreEqual(true, res[0]);
        }

        [TestMethod]
        public void TestSecondElement()
        {
            DataService ds = new DataService();
            int x = 103;
            int y = 475;
            bool[] res = ds.GetCompareOperations(x, y);
            Assert.AreEqual(false, res[1]);
        }
    }
}