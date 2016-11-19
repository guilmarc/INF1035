using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MonsterInc;
using MonsterInc.Shared;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<MonsterInc.Item>  a = MonsterInc.ItemData.Items ;
            a.XmlSerialize<List<MonsterInc.Item>>("", true);
            
        }
    }
}
