using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;

namespace MonsterIncConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Core.Engine.RunDummyGame();

            //Core.Data.XmlGenerator.GenerateAllXml();

            var game = Core.Engine.NewGame(Core.Universe.DummyPlayer);
            game.Save();

            //var newPlayer = new Core.Model.Player();
            //newPlayer.PlayerType = PlayerType.Human;
            Core.Universe.SavedGameFiles.ForEach(x => Console.WriteLine(x));


            var firstSavedGame = Core.Universe.SavedGameFiles[0];
            var loadedgame = Core.Engine.LoadGameFromFile(firstSavedGame);

            Console.Write(loadedgame);


            //while (true)
            //{
            //   Console.WriteLine(Core.Utils.HumanizeRatio()); 
            //}

            Console.ReadLine();
        }
    }
}
