
 using System;
 using System.Linq;
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
            InitActiveMonsters(newTrainer);
            InitActiveMonster(newTrainer);

            InventoryFactory.GenerateInventoryForTrainer(newTrainer);
            InitActiveInventory(newTrainer);

            return newTrainer;
        }


        public static Trainer GenerateRandomTrainer(Trainer trainer, Difficulty difficulty)
        {
            var randomName = TrainerData.TrainerNames.Random();
            var element = Utils.GetRandomElement();

            var newTrainer = new Trainer(randomName, element);

            newTrainer.Monsters = MonsterFactory.GenerateRandomMonsters(trainer, difficulty);
            //newTrainer.Monsters = MonsterFactory.GenerateDummyMonsters();

            InitActiveMonsters(newTrainer);
            InitActiveMonster(newTrainer);

            InventoryFactory.GenerateInventoryForTrainer(newTrainer);
            InitActiveInventory(newTrainer);

            return newTrainer;
        }

        private static void InitActiveInventory(Trainer trainer)
        {
            var itemCount = trainer.Inventory.Count >= Constants.ActiveInventoryCount ? Constants.ActiveInventoryCount : trainer.Inventory.Count;

            for (var i = 0; i < itemCount; i++)
            {
                var item = trainer.Inventory.Where(x => !trainer.ActiveInventory.Contains(x)).ToList().Random();
                trainer.ActiveInventory.Add(item);
            }

        }

        /// <summary>
        /// Sélection des 
        /// </summary>
        /// <param name="trainer"></param>
        private static void InitActiveMonsters(Trainer trainer)
        {
            var activeMonstersCount = Math.Min(trainer.Monsters.Count, Constants.MaxActiveMonstersCount);
            for (var i = 0; i < activeMonstersCount; i++)
            {
                var selectedMonster = trainer.Monsters.Where(x => !trainer.ActiveMonsters.Contains(x)).ToList().Random();
                trainer.ActiveMonsters.Add(selectedMonster);
            }
        }

        private static void InitActiveMonster(Trainer trainer)
        {
            trainer.ActiveMonster = trainer.ActiveMonsters.Random();
        }

    }
}