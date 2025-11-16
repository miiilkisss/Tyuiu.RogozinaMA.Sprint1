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
            double wait = 2; // (2*3)/(1+2) = 6/3 = 2
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidExpressionWithFractionalNumbers()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 2.5;
            double wait = 1.5; // (1.5*2.5)/(1+1.5) = 3.75/2.5 = 1.5
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidExpressionWithZeroY()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 0;
            double wait = 0; // (5*0)/(1+5) = 0/6 = 0
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidExpressionWithNegativeNumbers()
        {
            DataService ds = new DataService();
            double x = -2;
            double y = 4;
            double wait = 8; // (-2*4)/(1-2) = -8/-1 = 8
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidExpressionWithDecimalNumbers()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 3;
            double wait = 1; // (0.5*3)/(1+0.5) = 1.5/1.5 = 1
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }  
}