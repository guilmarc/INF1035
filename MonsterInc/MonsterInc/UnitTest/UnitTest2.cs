﻿using System;
using System.Collections.Generic;
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
            var init = Core.Universe.InitMonsters;
        
            Assert.AreEqual(Core.Universe.InitMonsters.Count, 4);
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

        [TestMethod]
        public void TestOpponentMonstersGeneration()
        {
            
        }

        [TestMethod]
        public void TestDifficultyListGeneration()
        {

            Console.WriteLine(Universe.Difficulties.Count);
            Console.WriteLine(Universe.Difficulties.Count);

        }

        [TestMethod]
        public void TestRunDummyGame()
        {
            Core.Engine.RunDummyGame();

            var monsters = Core.Engine.Opponent.Trainer.Monsters.Count;

            Console.WriteLine();

        }

    }
}
