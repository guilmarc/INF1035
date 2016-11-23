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

            return newTrainer;
        }


        public static Trainer GenerateTrainer(Trainer trainer, Difficulty difficulty)
        {
            var name = TrainerData.GetRandomTrainerName();
            var element = Utils.GetRandomElement();

            var newTrainer = new Trainer(name, element);

            newTrainer.Monsters = MonsterFactory.GenerateMonsters(trainer, difficulty);
            InventoryFactory.GenerateInventoryForTrainer(newTrainer);
           
            return newTrainer;
        }


      
    }
}