using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint1.Task3.V16.Lib;

namespace Tyuiu.RogozinaMA.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCoeffOfQuadraticEquation()
        {
            DataService ds = new DataService();
            double x1 = 2;
            double x2 = 3;
            double wait = -5.000; // -(2 + 3) = -5
            double res = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCoeffOfQuadraticEquationWithNegativeRoots()
        {
            DataService ds = new DataService();
            double x1 = -1;
            double x2 = -4;
            double wait = 5.000; // -(-1 + -4) = -(-5) = 5
            double res = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCoeffOfQuadraticEquationWithFractionalRoots()
        {
            DataService ds = new DataService();
            double x1 = 1.5;
            double x2 = 2.5;
            double wait = -4.000; // -(1.5 + 2.5) = -4
            double res = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCoeffOfQuadraticEquationWithZero()
        {
            DataService ds = new DataService();
            double x1 = 0;
            double x2 = 5;
            double wait = -5.000; // -(0 + 5) = -5
            double res = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCoeffOfQuadraticEquationWithDecimalRounding()
        {
            DataService ds = new DataService();
            double x1 = 1.234;
            double x2 = 2.345;
            double wait = -3.579; // -(1.234 + 2.345) = -3.579
            double res = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(wait, res);
        }
    }
}