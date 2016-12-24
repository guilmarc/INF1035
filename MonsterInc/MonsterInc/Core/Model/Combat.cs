using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Model
{
    /// <summary>
    /// Classe responsable d'un combat
    /// </summary>
    public class Combat
    {
        /// <summary>
        /// Partie en lien avec ce combat
        /// </summary>
        Game _game;

        /// <summary>
        /// Récompense liée à ce combat
        /// </summary>
        public Reward Reward { get; set; }

        /// <summary>
        /// Niveau de difficulté choisi pour ce combat
        /// </summary>
        public Difficulty Difficulty { get; set; }

        /// <summary>
        /// Représente le joueur qui a actuellement la main
        /// </summary>
        public Player CurrentPlayer { get; set; }

        /// <summary>
        /// Représente l'adversaire choisi par le joueur qui à la main
        /// </summary>
        public Player CurrentOpponent { get; set; }

        /// <summary>
        /// Liste des joueurs dans ce combat.  Le code du Core prévoir être en mesure d'injecter
        /// autant de joueur humain ou robot que voulu
        /// Cela sera complété après la remise de ce travail pratique
        /// </summary>
        public List<Player> Players { get; set; } = new List<Player>();

        /// <summary>
        /// Numéro du tour en cours (round)
        /// </summary>
        public int Tour { get; set; } = 1;

        /// <summary>
        /// Constructeur par défaut nécessaire à la sérialisation
        /// </summary>
        public Combat() { }

        /// <summary>
        /// Constructeur obligatoire pour un combat
        /// </summary>
        /// <param name="game"></param>
        /// <param name="difficulty"></param>
        /// <param name="opponentsCount"></param>
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
	    private void GenerateOpponents(Player humanPlayer, Difficulty difficulty, int opponentsCount)
        {
            for (var i = 0; i < opponentsCount; i++)
            {
                var newOpponent = Universe.GenerateOpponent(humanPlayer, difficulty);
                this.Players.Add(newOpponent);
            }
        }

        /// <summary>
        /// Méthode principale d'exécution d'un combat.  Ce code va plus loin que les exigences de ce travail pratique
        /// Il sera complété après la remise (défi personnel)
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

                //Regénération de l'énergie des Monstres
                this.Players.ForEach(x => x.ActiveTrainer.ActiveMonsters.Alive().Energize());

                Tour++;

            } while (OpponentLifePoints != 0 && Tour <= 1000); //1000 = SafetyPipe pour les tests

            //Le combat est terminé car tous les Opponents sont morts
            //Le gagnant c'est CurrentPlayer
            Player winner = CurrentPlayer;

            Console.WriteLine(winner.Name + " Wins");
            captureOpponentsItems(winner);
        }


        /// <summary>
        /// Cette méthode permet au joueur gagnant de capturer les items de l'adversaire mort
        /// </summary>
        /// <param name="player"></param>
        public void captureOpponentsItems(Player player)
        {
            //TODO: Sera finalement géré par l'interface utilisateur pour l'instant
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
            return Players.Where(x => x != CurrentPlayer).ToList().Random();
        }

        /// <summary>
        /// Besoin d'initialiser 1er monstre adverse au player adverse    inutile pour l instant
        /// </summary>
        public void AssignFistOpponent()
        {
            CurrentOpponent = PickRandomOpponent();
        }

        /// <summary>
        /// Niveau moyen d'expérience de monstres du joueur humain
        /// </summary>
        /// <returns></returns>
        public int AverageLevel()
        {
            return _game.HumanPlayer.ActiveTrainer.ActiveMonsters.AverageExperienceLevel();
        }
    }
}
