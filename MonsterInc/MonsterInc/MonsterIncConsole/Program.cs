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


            foreach (var monsterTemplate in Core.Universe.MonsterTemplates)
            {
                Console.WriteLine(monsterTemplate.Name);
            }

            //var newPlayer = new Core.Model.Player();
            //newPlayer.PlayerType = PlayerType.Human;

            //while (true)
            //{
            //   Console.WriteLine(Core.Utils.HumanizeRatio()); 
            //}

            Console.ReadLine();
        }
    }
}
