using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RogozinaMA.Sprint1.Task0.V2.Lib;

namespace Tyuiu.RogozinaMA.Sprint1.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(1.0, res);
        }
    }
}
