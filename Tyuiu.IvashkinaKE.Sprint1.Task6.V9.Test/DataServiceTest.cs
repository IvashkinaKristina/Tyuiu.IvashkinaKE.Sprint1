using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IvashkinaKE.Sprint1.Task6.V9.Lib;

namespace Tyuiu.IvashkinaKE.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "кошка собака мышь";
            DataService ds = new DataService();
            string res = ds.MoveLetterToStart(strTest);
            string wait = "акошк асобак ьмыш";
            Assert.AreEqual(wait, res);
        }
    }
}
