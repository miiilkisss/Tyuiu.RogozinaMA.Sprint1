using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint1.Task4.V4.Lib;

namespace Tyuiu.RogozinaMA.Sprint1.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 0.667; // (1 + 1*1) / |1 + 2| = 2/3 = 0.666... → 0.667
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateWithPositiveNumbers()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 1.750; // (1 + 2*3) / |2 + 2| = 7/4 = 1.75
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateWithNegativeX()
        {
            DataService ds = new DataService();
            double x = -3;
            double y = 2;
            double wait = -5.000; // (1 + (-3)*2) / |-3 + 2| = (1 - 6)/1 = -5/1 = -5
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateWithNegativeY()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = -1;
            double wait = -0.500; // (1 + 4*(-1)) / |4 + 2| = (1 - 4)/6 = -3/6 = -0.5
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateWithFractionalNumbers()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 2;
            double wait = 0.800; // (1 + 0.5*2) / |0.5 + 2| = (1 + 1)/2.5 = 2/2.5 = 0.8
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateWithZero()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 5;
            double wait = 0.500; // (1 + 0*5) / |0 + 2| = 1/2 = 0.5
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateWithXMinusTwo()
        {
            DataService ds = new DataService();
            double x = -2;
            double y = 1;
            // (1 + (-2)*1) / |-2 + 2| = (1 - 2)/0 = -1/0 = деление на ноль
            // Тест проверяет обработку деления на ноль
            double res = ds.Calculate(x, y);
            // Ожидаем Infinity или исключение
            Assert.IsTrue(double.IsInfinity(res) || double.IsNaN(res));
        }
    }
}