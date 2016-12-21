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

            //var newPlayer = new Core.Model.Player();
            //newPlayer.PlayerType = PlayerType.Human;

            while (true)
            {
               Console.WriteLine(Core.Utils.HumanizeRatio()); 
            }

            //Console.ReadLine();
        }
    }
}
