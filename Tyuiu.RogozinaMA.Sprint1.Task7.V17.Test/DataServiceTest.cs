using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint1.Task7.V17.Lib;

namespace Tyuiu.RogozinaMA.Sprint1.Task7.V17.Test
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
            double res = ds.Calculate(x, y);
            // (1 + sin√(1 + 1)) / cos(12 - 4) = (1 + sin√2) / cos(8)
            double expected = Math.Round((1 + Math.Sin(Math.Sqrt(2))) / Math.Cos(8), 3);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void ValidCalculateWithZero()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double res = ds.Calculate(x, y);
            // (1 + sin√(0 + 1)) / cos(0 - 4) = (1 + sin1) / cos(-4)
            double expected = Math.Round((1 + Math.Sin(1)) / Math.Cos(-4), 3);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void ValidCalculateWithNegativeNumbers()
        {
            DataService ds = new DataService();
            double x = -2;
            double y = -1;
            double res = ds.Calculate(x, y);
            // (1 + sin√(4 + 1)) / cos(-12 - 4) = (1 + sin√5) / cos(-16)
            double expected = Math.Round((1 + Math.Sin(Math.Sqrt(5))) / Math.Cos(-16), 3);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void ValidCalculateWithFractionalNumbers()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.25;
            double res = ds.Calculate(x, y);
            // (1 + sin√(0.25 + 1)) / cos(3 - 4) = (1 + sin√1.25) / cos(-1)
            double expected = Math.Round((1 + Math.Sin(Math.Sqrt(1.25))) / Math.Cos(-1), 3);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void ValidCalculateWithLargeNumbers()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double res = ds.Calculate(x, y);
            // (1 + sin√(25 + 1)) / cos(24 - 4) = (1 + sin√26) / cos(20)
            double expected = Math.Round((1 + Math.Sin(Math.Sqrt(26))) / Math.Cos(20), 3);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void ValidCalculateRounding()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0.1;
            double res = ds.Calculate(x, y);
            // Проверяем округление до 3 знаков
            double calculated = (1 + Math.Sin(Math.Sqrt(2))) / Math.Cos(1.2 - 4);
            double rounded = Math.Round(calculated, 3);
            Assert.AreEqual(rounded, res);
        }
    }
}