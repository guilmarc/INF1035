using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using Core.Model;

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
            var init = Core.Engine.InitMonsters;
        
            Assert.AreEqual(Core.Engine.InitMonsters.Count, 4);
        }

        [TestMethod]
        public void TestGenerateRandomTemplateMonster()
        {
            for (int i = 0; i < 100; i++)
            {
               var monsterTemplate =  MonsterFactory.PickRandomMonsterTemplateForLevel(40);
               Console.WriteLine(monsterTemplate.Name);
            }
            

        }

        public void TestOpponentMonstersGeneration()
        {
            
        }

    }
}
