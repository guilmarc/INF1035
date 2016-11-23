using Core.Data;
using Core.Model;

namespace Core
{
    public static class TrainerFactory
    {
        public static Trainer GenerateTrainer(Trainer trainer, Difficulty difficulty)
        {
            var newTrainer = new Trainer();

            //TODO: Générer une liste d'achat aléatoire avec l'or disponible
            //newTrainer.Inventory

            newTrainer.Name = TrainerData.GetRandomTrainerName();
            newTrainer.Monsters = MonsterFactory.GenerateMonsters(trainer, difficulty);

            return newTrainer;
        }
    }
}