using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint1.Task6.V9.Lib;

namespace Tyuiu.RogozinaMA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMoveLetterToStartSingleWord()
        {
            DataService ds = new DataService();
            string text = "hello";
            string wait = "ohell";
            string res = ds.MoveLetterToStart(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidMoveLetterToStartMultipleWords()
        {
            DataService ds = new DataService();
            string text = "hello world";
            string wait = "ohell dworl";
            string res = ds.MoveLetterToStart(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidMoveLetterToStartWithPunctuation()
        {
            DataService ds = new DataService();
            string text = "hello, world!";
            string wait = "ohell dworl";
            string res = ds.MoveLetterToStart(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidMoveLetterToStartSingleLetterWords()
        {
            DataService ds = new DataService();
            string text = "a b c";
            string wait = "a b c";
            string res = ds.MoveLetterToStart(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidMoveLetterToStartEmptyString()
        {
            DataService ds = new DataService();
            string text = "";
            string wait = "";
            string res = ds.MoveLetterToStart(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidMoveLetterToStartMixedCase()
        {
            DataService ds = new DataService();
            string text = "Hello World";
            string wait = "oHell dWorl";
            string res = ds.MoveLetterToStart(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidMoveLetterToStartWithNumbers()
        {
            DataService ds = new DataService();
            string text = "test123 word456";
            string wait = "3test12 6word45";
            string res = ds.MoveLetterToStart(text);
            Assert.AreEqual(wait, res);
        }
    }
}