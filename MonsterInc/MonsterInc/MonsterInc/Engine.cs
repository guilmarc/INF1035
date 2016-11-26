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
            
        }
       
        public static void RunDummyGame()
        {
            new Game(Universe.DummyPlayer).Run();
        }


        public static void ConsumeUsable(Player player, Player opponent, Usable usable)
        {
            usable.Consume(player, opponent);
        }

    }
       
}

