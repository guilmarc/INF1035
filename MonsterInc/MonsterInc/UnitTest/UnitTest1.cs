using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Core;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestLifePotion()
        {

            //List<Core.Model.Item>  a = Core.Data.ItemData.Items ;
            //a.XmlSerialize<List<Core.Model.Item>>(@"item", true);

            //Create new player/trainer

            /*
            Engine.Player = new Core.Model.Player();
            Engine.Player.Name = "test";
            Engine.Player.Trainer = new Core.Model.Trainer();

            //populate items
            Engine.Player.Trainer.Inventory = Core.Data.ItemData.Items;

            //populate monsters
            Engine.Player.Trainer.ActiveMonsters = Core.Universe.InitMonsters;
            Engine.Player.Trainer.ActiveMonster = Engine.Player.Trainer.ActiveMonsters[1];

            //Get and use potion
            var lifePotionList = Engine.Player.Trainer.Inventory.OfType<Core.Model.LifePotion>();
            Engine.ConsumeItem(
                new Core.Model.Monster(),
                new Core.Model.Monster(), 
                lifePotionList.First()
                );


            var actual = Engine.Player.Trainer.ActiveMonster;
            var expected = Engine.Player.Trainer.ActiveMonsters[1];
            */
        }
    }

}
