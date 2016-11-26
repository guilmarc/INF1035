
﻿using System.Linq;
 using Core.Data;
using Core.Model;

namespace Core
{
    public static class TrainerFactory
    {

        public static Trainer GenerateDummyTrainer()
        {
            var element = Utils.GetRandomElement();

            var newTrainer = new Trainer("DummyTrainer", element);

            newTrainer.Monsters = MonsterFactory.GenerateDummyMonsters();
            InventoryFactory.GenerateInventoryForTrainer(newTrainer);

            InitActiveInventory(newTrainer);

            return newTrainer;
        }


        public static Trainer GenerateTrainer(Trainer trainer, Difficulty difficulty)
        {
            var name = TrainerData.GetRandomTrainerName();
            var element = Utils.GetRandomElement();

            var newTrainer = new Trainer(name, element);

            newTrainer.Monsters = MonsterFactory.GenerateMonsters(trainer, difficulty);
            InventoryFactory.GenerateInventoryForTrainer(newTrainer);

            InitActiveInventory(newTrainer);

            return newTrainer;
        }

        private static void InitActiveInventory(Trainer trainer)
        {
            var itemCount = trainer.Inventory.Count >= Utils.Constants.ActiveInventoryCount ? Utils.Constants.ActiveInventoryCount : trainer.Inventory.Count;

            for (var i = 0; i < itemCount; i++)
            {
                var item = trainer.Inventory.Where(x => !trainer.ActiveInventory.Contains(x)).ToList().Random();
                trainer.ActiveInventory.Add(item);
            }

        }

    }
}