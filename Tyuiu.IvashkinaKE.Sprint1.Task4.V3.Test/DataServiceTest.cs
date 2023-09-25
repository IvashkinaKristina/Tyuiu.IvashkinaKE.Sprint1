﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IvashkinaKE.Sprint1.Task4.V3.Lib;

namespace Tyuiu.IvashkinaKE.Sprint1.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 2;
            double wait = 0.866;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
