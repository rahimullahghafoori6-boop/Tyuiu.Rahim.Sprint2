using NUnit.Framework;
using Tyuiu.Rahim.Sprint2.Task5.V15.Lib;

namespace Tyuiu.Rahim.Sprint2.Task5.V15.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            // 1 января - понедельник
            Assert.AreEqual("Понедельник", ds.FindDayName(1));
            Assert.AreEqual("Понедельник", ds.FindDayName(8));
            Assert.AreEqual("Понедельник", ds.FindDayName(15));

            // 2 января - вторник
            Assert.AreEqual("Вторник", ds.FindDayName(2));
            Assert.AreEqual("Вторник", ds.FindDayName(9));

            // 3 января - среда
            Assert.AreEqual("Среда", ds.FindDayName(3));
            Assert.AreEqual("Среда", ds.FindDayName(10));

            // 4 января - четверг
            Assert.AreEqual("Четверг", ds.FindDayName(4));
            Assert.AreEqual("Четверг", ds.FindDayName(11));

            // 5 января - пятница
            Assert.AreEqual("Пятница", ds.FindDayName(5));
            Assert.AreEqual("Пятница", ds.FindDayName(12));

            // 6 января - суббота
            Assert.AreEqual("Суббота", ds.FindDayName(6));
            Assert.AreEqual("Суббота", ds.FindDayName(13));

            // 7 января - воскресенье
            Assert.AreEqual("Воскресенье", ds.FindDayName(7));
            Assert.AreEqual("Воскресенье", ds.FindDayName(14));

            // Крайние значения
            Assert.AreEqual("Понедельник", ds.FindDayName(365)); // 365-й день = 31 декабря
        }

       
        public void InvalidFindDayName()
        {
            DataService ds = new DataService();

            // Проверка на исключение при неверных значениях
            Assert.ThrowsException<ArgumentException>(() => ds.FindDayName(0));
            Assert.ThrowsException<ArgumentException>(() => ds.FindDayName(366));
            Assert.ThrowsException<ArgumentException>(() => ds.FindDayName(-10));
        }
    }
}