
using Tyuiu.Rahim.Sprint2.Task5.V15.Lib;

namespace Tyuiu.Rahim.Sprint2.Task5.V15.Test
{
    
    public class DataServiceTest
    {
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            // Проверка первого дня
            Assert.AreEqual("Понедельник", ds.FindDayName(1));

            // Проверка всех дней недели
            Assert.AreEqual("Вторник", ds.FindDayName(2));
            Assert.AreEqual("Среда", ds.FindDayName(3));
            Assert.AreEqual("Четверг", ds.FindDayName(4));
            Assert.AreEqual("Пятница", ds.FindDayName(5));
            Assert.AreEqual("Суббота", ds.FindDayName(6));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7));

            // Проверка цикличности
            Assert.AreEqual("Понедельник", ds.FindDayName(8));
            Assert.AreEqual("Вторник", ds.FindDayName(9));
            Assert.AreEqual("Среда", ds.FindDayName(10));

            // Проверка последнего дня года
            Assert.AreEqual("Понедельник", ds.FindDayName(365));
        }

        [Test]
        public void InvalidFindDayName()
        {
            DataService ds = new DataService();

            // Проверка неверных значений
            object value = Assert.ThrowsException<ArgumentException>(() => ds.FindDayName(0));
            Assert.ThrowsException<ArgumentException>(() => ds.FindDayName(366));
            Assert.ThrowsException<ArgumentException>(() => ds.FindDayName(-5));
        }

        public void EdgeCases()
        {
            DataService ds = new DataService();

            // Граничные значения
            Assert.AreEqual("Понедельник", ds.FindDayName(1));
            Assert.AreEqual("Понедельник", ds.FindDayName(365));

            // Случайные значения для проверки
            Assert.AreEqual("Среда", ds.FindDayName(100));    // 100-й день
            Assert.AreEqual("Пятница", ds.FindDayName(200));   // 200-й день
            Assert.AreEqual("Воскресенье", ds.FindDayName(300)); // 300-й день
        }
    }
}