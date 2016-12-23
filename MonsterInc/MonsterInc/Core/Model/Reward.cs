using System;
using System.Linq;
namespace Core.Model
{
    public class Reward
    {
        private Combat combat { get; set; }
        private int averageLevel { get; set; }
        public Reward(Combat combat)
        {
            this.combat = combat;
            averageLevel = combat.AverageLevel();

        }
        public string AssignReward()
        {
            Player currentPlayer = combat.Players.Where(x => x.Type == PlayerType.Human).First();
            Player currentOpponent = combat.Players.Where(x => x.Type == PlayerType.Robot).First();
            string result = "";

            //ajout d'items
            int count = 0;
            if (currentOpponent.ActiveTrainer.ActiveInventory.Count > 0)
                foreach (Item item in currentOpponent.ActiveTrainer.ActiveInventory)
                {
                    if (count < 5 && item != null)
                    {

                        Item newItem = item;
                        currentPlayer.Trainer.Inventory.Add(newItem);
                        result += "Acquired : " + newItem.Name + "\n";// +
                        count++;
                    }

                }
            //ajout de golds
            int goldAquired = averageLevel * combat.Difficulty.DifficultyNumber + 5;
            currentPlayer.Trainer.Gold += goldAquired;
            result += "Acquired : " + goldAquired + " golds\n";
            //result += "nombre d active items enemy" + currentOpponent.ActiveTrainer.ActiveInventory.Count + "\n";
            return result;
        }
    }
}
