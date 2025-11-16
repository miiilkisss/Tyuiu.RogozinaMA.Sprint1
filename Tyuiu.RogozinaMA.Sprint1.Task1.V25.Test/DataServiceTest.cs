using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint1.Task1.V25.Lib;

namespace Tyuiu.RogozinaMA.Sprint1.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double result = ds.Calculate(x, y);
            double wait = 2.00; // (2*3)/(1+2) = 6/3 = 2
            Assert.AreEqual(wait, Math.Round(result, 2));
        }

        [TestMethod]
        public void ValidExpressionWithFractionalNumbers()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 2.5;
            double result = ds.Calculate(x, y);
            double wait = 1.50; // (1.5*2.5)/(1+1.5) = 3.75/2.5 = 1.5
            Assert.AreEqual(wait, Math.Round(result, 2));
        }

        [TestMethod]
        public void ValidExpressionWithZeroY()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 0;
            double result = ds.Calculate(x, y);
            double wait = 0.00; // (5*0)/(1+5) = 0/6 = 0
            Assert.AreEqual(wait, Math.Round(result, 2));
        }

        [TestMethod]
        public void ValidExpressionWithNegativeNumbers()
        {
            DataService ds = new DataService();
            double x = -2;
            double y = 4;
            double result = ds.Calculate(x, y);
            double wait = 8.00; // (-2*4)/(1-2) = -8/-1 = 8
            Assert.AreEqual(wait, Math.Round(result, 2));
        }

        [TestMethod]
        public void ValidExpressionWithDecimalNumbers()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 3;
            double result = ds.Calculate(x, y);
            double wait = 1.00; // (0.5*3)/(1+0.5) = 1.5/1.5 = 1
            Assert.AreEqual(wait, Math.Round(result, 2));
        }

        [TestMethod]
        public void ValidExpressionWithOne()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double result = ds.Calculate(x, y);
            double wait = 2.00; // (1*4)/(1+1) = 4/2 = 2
            Assert.AreEqual(wait, Math.Round(result, 2));
        }

        [TestMethod]
        public void ValidExpressionWithPeriodicResult()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double result = ds.Calculate(x, y);
            double wait = 1.33; // (2*2)/(1+2) = 4/3 = 1.333... → 1.33
            Assert.AreEqual(wait, Math.Round(result, 2));
        }
    }
}