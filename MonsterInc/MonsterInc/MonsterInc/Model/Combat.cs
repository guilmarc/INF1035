using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Model
{

	/// <summary>
	/// 
	/// </summary>
	public class Combat
	{
		Game _game;
		public Reward Reward { get; set; }

		public List<Turn> Turns { get; set; }

        public  Difficulty Difficulty { get; set; }

        private  Player CurrentPlayer { get; set; }

        private  Player CurrentOpponent { get; set; }

        public List<Player> Players { get; set; } = new List<Player>();

        public static int Tour { get; set; } = 1;

        public Combat(Game game, Difficulty difficulty, int opponentsCount = 1)
		{
			this._game = game;
		    this.Difficulty = difficulty;
            this.Players.Add(game.HumanPlayer);
            this.GenerateOpponents(_game.HumanPlayer, difficulty, opponentsCount);
		}

	    private void GenerateOpponents(Player HumanPlayer, Difficulty difficulty,  int opponentsCount)
	    {
	        for (var i =0; i < opponentsCount; i++)
	        {
                var newOpponent = Universe.GenerateOpponent(HumanPlayer, difficulty);
                this.Players.Add(newOpponent);
            }
	    }

	    public void Run()
	    {
            do
            {
                foreach (var player in Players)
                {
                    CurrentPlayer = player;
                    CurrentOpponent = PickRandomOpponent();
                    var usable = CurrentPlayer.PickUsable(CurrentOpponent);
                    //usable.Consume(CurrentPlayer, CurrentOpponent);
                }

                Tour++;

            } while (OpponentLifePoints == 0);

            //Le combat est terminé car tous les Opponents sont morts
            //Le gagnant c'est CurrentPlayer
            Console.WriteLine(CurrentPlayer + " Wins");
        }

        public int OpponentLifePoints
        {
            get { return Players.Where(x => x != CurrentPlayer).Sum(y => y.ActiveTrainer.LifePoints); }
        }

        public Player PickRandomOpponent()
        {
            var availableOpponents = Players.Where(x => x != CurrentPlayer).ToList();
            return availableOpponents[Utils.Random(availableOpponents.Count)];
        }
    } 
}
