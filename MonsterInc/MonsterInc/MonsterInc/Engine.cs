using System;
using System.Collections.Generic;
using Core.Model;
using Core.Data;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Core
{
    /// <summary>
    /// Classe représentant l'IA de l'application
    /// </summary>
    public static class Engine
    {
        static Engine()
        {
            Difficulty = Universe.Difficulties[0];
        }

        public static Difficulty Difficulty { get; set; }

        private static Player CurrentPlayer { get; set; }

        private static Player CurrentOpponent { get; set; }

        public static List<Player> Players { get; set; } = new List<Player>();

        public static int Tour { get; set; } = 1;
       
        public static void RunDummyGame()
        {
            Difficulty = Universe.Difficulties[0];
           
            Players.Add( Universe.DummyPlayer );
            Players.Add( Universe.GenerateOpponent( Universe.DummyPlayer, Difficulty ) );

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

        public static int OpponentLifePoints
        {
            get { return Players.Where(x => x != CurrentPlayer).Sum(y => y.ActiveTrainer.LifePoints); }
        }

        public static Player PickRandomOpponent()
        {
            var availableOpponents = Players.Where(x => x != CurrentPlayer).ToList();
            return availableOpponents[Utils.Random(availableOpponents.Count)];
        }

        public static void ConsumeUsable(Player player, Player opponent, Usable usable)
        {
            usable.Consume(player, opponent);
        }

    }
       
}

