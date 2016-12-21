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

        public  Player CurrentPlayer { get; set; }

        public  Player CurrentOpponent { get; set; }

        public List<Player> Players { get; set; } = new List<Player>();

        public static int Tour { get; set; } = 1;

        public Combat() { }

        public Combat(Game game, Difficulty difficulty, int opponentsCount = 1)
		{
			this._game = game;
		    this.Difficulty = difficulty;
            this.Players.Add(game.HumanPlayer);
            this.GenerateOpponents(_game.HumanPlayer, difficulty, opponentsCount);
		}

        /// <summary>
        /// Méthode utile lorsqu'un joueur humain désire se battre contre plusieurs opposants
        /// </summary>
        /// <param name="humanPlayer">Le joueur représenté par un humain</param>
        /// <param name="difficulty">Le niveau de difficulté demandé par le joueur humain</param>
        /// <param name="opponentsCount">Le nombre d'opposants demandés par le joueur humain</param>
	    private void GenerateOpponents(Player humanPlayer, Difficulty difficulty,  int opponentsCount)
	    {
	        for (var i =0; i < opponentsCount; i++)
	        {
                var newOpponent = Universe.GenerateOpponent(humanPlayer, difficulty);
                this.Players.Add(newOpponent);
            }
	    }

        /// <summary>
        /// Méthode principale d'exécution d'un combat
        /// </summary>
	    public void Run()
	    {
            do
            {
                foreach (var player in Players)
                {
                    CurrentPlayer = player;
                    CurrentOpponent = PickRandomOpponent();

                    Usable usable = null;

                    if (CurrentPlayer.Type == PlayerType.Human)
                    {
                        //Lancer un delegate sync
                        usable = CurrentPlayer.PickUsable(CurrentOpponent);
                    }
                    else
                    {
                        usable = CurrentPlayer.PickUsable(CurrentOpponent);
                    }

                    if (usable != null)
                    {
                        usable.Consume(CurrentPlayer, CurrentOpponent);

                        foreach (var scope in usable.Scopes)
                        {
                            Console.WriteLine(Tour + ":: " + CurrentPlayer + " utilise " + usable + " sur " +
                                              ((scope.Target == Scope.ScopeTarget.Self)
                                                  ? CurrentPlayer
                                                  : CurrentOpponent));
                        }
                    }
                    else
                    {
                        //Plus aucun utilisable de disponible !!!
                        Console.WriteLine("Aucun utilisable de disponible pour " + CurrentPlayer);
                    }
                }

                Tour++;

            } while (OpponentLifePoints != 0 && Tour <= 1000); //1000 = SafetyPipe pour les tests

            //Le combat est terminé car tous les Opponents sont morts
            //Le gagnant c'est CurrentPlayer
            Console.WriteLine(CurrentPlayer.Name + " Wins");
        }


        /// <summary>
        /// Retourne le total des points de vie des monstres de tous les opposants
        /// </summary>
        public int OpponentLifePoints
        {
            get { return Players.Where(x => x != CurrentPlayer).Sum(y => y.ActiveTrainer.LifePoints); }
        }


        /// <summary>
        /// Sélectionne un opposant au hasard parmis la liste.
        /// S'il y a qu'un seul opposant, retournera toujours le même 
        /// </summary>
        /// <returns></returns>
        public Player PickRandomOpponent()
        {
            var availableOpponents = Players.Where(x => x != CurrentPlayer).ToList();
            return availableOpponents[Utils.Random(availableOpponents.Count)];
        }
    } 
}
