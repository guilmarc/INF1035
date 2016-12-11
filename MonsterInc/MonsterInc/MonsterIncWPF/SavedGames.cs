using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;

namespace MonsterIncWPF
{
    public static class SavedGames
    {
        public const string XMLName = "SavedGames";

        public static List<Core.Model.Player> Games { get; set; } = new List<Core.Model.Player>();

        public static Core.Model.Player LoadedPlayer { get; set; } = new Player();

        
    }
}
