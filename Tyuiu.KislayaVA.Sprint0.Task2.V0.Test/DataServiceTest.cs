using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KislayaVA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KislayaVA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Вера";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Вера", res);
        }
    }
}
