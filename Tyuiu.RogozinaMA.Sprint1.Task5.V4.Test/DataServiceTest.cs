using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.RogozinaMA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSecondsToHoursExampleFromCondition()
        {
            DataService ds = new DataService();
            int time = 13257;
            int wait = 3; // 13257 / 3600 = 3.6825 → 3 полных часа
            int res = ds.SecondsToHours(time);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidSecondsToHoursFirstHour()
        {
            DataService ds = new DataService();
            int time = 3599;
            int wait = 0; // 3599 / 3600 = 0.9997 → 0 полных часов
            int res = ds.SecondsToHours(time);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidSecondsToHoursExactlyOneHour()
        {
            DataService ds = new DataService();
            int time = 3600;
            int wait = 1; // 3600 / 3600 = 1 → 1 полный час
            int res = ds.SecondsToHours(time);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidSecondsToHoursMultipleHours()
        {
            DataService ds = new DataService();
            int time = 7200;
            int wait = 2; // 7200 / 3600 = 2 → 2 полных часа
            int res = ds.SecondsToHours(time);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidSecondsToHoursEndOfDay()
        {
            DataService ds = new DataService();
            int time = 86399;
            int wait = 23; // 86399 / 3600 = 23.9997 → 23 полных часа
            int res = ds.SecondsToHours(time);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidSecondsToHoursStartOfDay()
        {
            DataService ds = new DataService();
            int time = 0;
            int wait = 0; // 0 / 3600 = 0 → 0 полных часов
            int res = ds.SecondsToHours(time);
            Assert.AreEqual(wait, res);
        }
    }
}