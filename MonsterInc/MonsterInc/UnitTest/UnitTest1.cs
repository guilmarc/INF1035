using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Core;
using System.Linq;
using Core.Model;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {


        //private Player playeur = null;
        public UnitTest1()
        {
            Engine.Player = new Core.Model.Player();
            Engine.Player.Name = "test";
            Engine.Player.Trainer = new Core.Model.Trainer();

            //populate items
            Engine.Player.ActiveTrainer.Inventory = Core.Data.ItemData.Items;
            Engine.Player.ActiveTrainer.ActiveInventory = Engine.Player.ActiveTrainer.Inventory;

            //populate monsters
            Engine.Player.ActiveTrainer.ActiveMonsters = Core.Universe.InitMonsters;
            Engine.Player.ActiveTrainer.ActiveMonster = Engine.Player.ActiveTrainer.ActiveMonsters[1];
        }

        [TestMethod]
        public void TestLifePotion()
        {

        
            //Get and use potion
            var lifePotionList = Engine.Player.ActiveTrainer.Inventory.OfType<Core.Model.LifePotion>().Where(x=>x.Name == "Medium Life Potion");
            Core.Model.Usable usable = lifePotionList.First();


            var actualCarac = Engine.Player.ActiveTrainer.ActiveMonster.Caracteristics.First(x => x.Type == Core.Model.MonsterTemplateCaracteristicType.LifePoints);//0.6
            actualCarac.Actual = 1;//ex de calcul:   a.base = 10 donc 10*0.6 -> 6 -> 1+6 = 7


            Engine.ConsumeUsable(
                Engine.Player,
                new Core.Model.Player(),
                usable
                );
            


            Assert.AreEqual(actualCarac.Actual, 8 );

        }
        [TestMethod]
        public void TestRevivePotion()
        {

            //Get and use potion
            Usable usable = Engine.Player.ActiveTrainer.Inventory.OfType<Core.Model.Revival>().First();
           // Core.Model.Usable usable = lifePotionList;


            var actualCarac = Engine.Player.ActiveTrainer.ActiveMonster.Caracteristics.First(x => x.Type == Core.Model.MonsterTemplateCaracteristicType.LifePoints);//0.6
            actualCarac.Actual = 0;//ex de calcul:   a.base = 10 donc 10*0.6 -> 6 -> 1+6 = 7


            Engine.ConsumeUsable(
                Engine.Player,
                new Core.Model.Player(),
                usable
                );



            Assert.AreEqual(actualCarac.Actual, 8);

        }
    }

}
