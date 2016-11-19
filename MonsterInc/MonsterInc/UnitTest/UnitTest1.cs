using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Core;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            List<Core.Model.Item>  a = Core.Data.ItemData.Items ;
            //a.XmlSerialize<List<Core.Model.Item>>(@"item", true);
            
        }
    }
}
