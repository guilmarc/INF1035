using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;

namespace UnitTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
           // Console.WriteLine(Engine.GetAvailableItems().Count);
        }

        [TestMethod]
        public void TestThereShouldBe4InitMonsters()
        {
            Assert.AreEqual(Core.Engine.GenerateInitMonsters().Count, 4);
        }
    }
}
