using Core;
using Core.Model;

namespace MonsterInc.Factories
{
    public static class PlayerFactory
    {

        public static Player GenerateDummyPlayer()
        {
            var newPlayer = new Player("Dummy", PlayerType.Robot);
            newPlayer.Trainer = TrainerFactory.GenerateDummyTrainer();
            return newPlayer;
        }

        public static Player GenerateOpponent(Player player, Difficulty difficulty)
        {
            var newOpponent = new Player("Opponent", PlayerType.Robot); //
            newOpponent.Trainer = TrainerFactory.GenerateRandomTrainer(player.Trainer, difficulty);
            return newOpponent;
        }
    }
}