using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint1.Task2.V24.Lib;

namespace Tyuiu.RogozinaMA.Sprint1.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateDiffSquare()
        {
            DataService ds = new DataService();
            int number1 = 5;
            int number2 = 3;
            int wait = 4; // (5-3)² = 2² = 4
            int res = ds.CalculateDiffSquare(number1, number2);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateDiffSquareNegative()
        {
            DataService ds = new DataService();
            int number1 = 3;
            int number2 = 5;
            int wait = 4; // (3-5)² = (-2)² = 4
            int res = ds.CalculateDiffSquare(number1, number2);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateDiffSquareZero()
        {
            DataService ds = new DataService();
            int number1 = 7;
            int number2 = 7;
            int wait = 0; // (7-7)² = 0² = 0
            int res = ds.CalculateDiffSquare(number1, number2);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateDiffSquareLargeNumbers()
        {
            DataService ds = new DataService();
            int number1 = 10;
            int number2 = 4;
            int wait = 36; // (10-4)² = 6² = 36
            int res = ds.CalculateDiffSquare(number1, number2);
            Assert.AreEqual(wait, res);
        }
    }
}