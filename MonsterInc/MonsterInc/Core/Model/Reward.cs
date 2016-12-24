using System;
using System.Linq;
namespace Core.Model
{
    /// <summary>
    /// Récompenses associée à une victoire
    /// </summary>
    public class Reward
    {
        /// <summary>
        /// Lien vers le combat efffectué
        /// </summary>
        private Combat _combat;

        /// <summary>
        /// Sauvegarde de la moyenne du niveau d'expérience
        /// </summary>
        private int _averageLevel;

        /// <summary>
        /// Constructeur obligatoire demandant le combat en référence
        /// </summary>
        /// <param name="combat"></param>
        public Reward(Combat combat)
        {
            this._combat = combat;
            _averageLevel = combat.AverageLevel();
        }

        /// <summary>
        /// Assignation de la récompense
        /// </summary>
        /// <returns></returns>
        public string AssignReward()
        {
            Player currentPlayer = _combat.Players.Where(x => x.Type == PlayerType.Human).First();
            Player currentOpponent = _combat.Players.Where(x => x.Type == PlayerType.Robot).First();
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
            int goldAquired = _averageLevel * _combat.Difficulty.DifficultyNumber + 5;
            currentPlayer.Trainer.Gold += goldAquired;
            result += "Acquired : " + goldAquired + " golds\n";
            //result += "nombre d active items enemy" + currentOpponent.ActiveTrainer.ActiveInventory.Count + "\n";
            return result;
        }
    }
}
