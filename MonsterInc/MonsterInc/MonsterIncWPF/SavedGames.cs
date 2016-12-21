using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core;

namespace MonsterIncWPF
{
    public static class SavedGames
    {
        public static MainWindow mainWindow = ((MainWindow) System.Windows.Application.Current.MainWindow);
        public static int trainerHomeForm = 0;

        public const string XMLName = "SavedGames";

        public static List<Player> Games { get; set; } = new List<Core.Model.Player>();

        public static Player LoadedPlayer { get; set; } = new Player();

        //public static Core.Model.Player LoadedOpponent { get; set; } = new Player();

        public static Game LoadedGame { get; set; } = new Game();

        public static Combat LoadedCombat { get; set; } = new Combat();

        //public static Player initCombatPlayer
        //{
           // get { return SavedGames.LoadedCombat.Players.Where(x => x.Type == PlayerType.Human).First(); }
         //
            //string CombatTrainerName = .Trainer.Name;
           // string CombatOpponentName = SavedGames.LoadedCombat.Players.Where(x => x.Type == PlayerType.Robot).First().Trainer.Name;
       // }

        //public static Player CombatPlayer { get; set; } = LoadedCombat.Players.Where(x => x.Type == PlayerType.Human).First();
        //public static Player CombatOpponent { get; set; } = LoadedCombat.Players.Where(x => x.Type == PlayerType.Robot).First();
    }
}
