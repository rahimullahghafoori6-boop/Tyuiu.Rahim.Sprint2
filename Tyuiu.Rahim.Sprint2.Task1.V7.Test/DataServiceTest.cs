using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Rahim.Sprint2.Task1.V7.Lib;

namespace Tyuiu.Rahim.Sprint2.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 119;
            int b = 196;
            int c = 134;
            int d = 327;

            bool[] wait = new bool[6] { true, false, true, false, true, false };

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestFirstElement()
        {
            DataService ds = new DataService();
            int a = 119;
            int b = 196;
            int c = 134;
            int d = 327;

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            Assert.AreEqual(true, res[0]);
        }

        [TestMethod]
        public void TestSecondElement()
        {
            DataService ds = new DataService();
            int a = 119;
            int b = 196;
            int c = 134;
            int d = 327;

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            Assert.AreEqual(false, res[1]);
        }

        [TestMethod]
        public void TestAllElements()
        {
            DataService ds = new DataService();
            int a = 119;
            int b = 196;
            int c = 134;
            int d = 327;

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Assert.AreEqual(true, res[0]);  // First
            Assert.AreEqual(false, res[1]); // Second
            Assert.AreEqual(true, res[2]);  // Third
            Assert.AreEqual(false, res[3]); // Fourth
            Assert.AreEqual(true, res[4]);  // Fifth
            Assert.AreEqual(false, res[5]); // Sixth
        }
    }
}