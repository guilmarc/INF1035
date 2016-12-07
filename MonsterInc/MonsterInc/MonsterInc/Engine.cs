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
            Console.WriteLine("Test d'écriture à la console");
            System.Diagnostics.Trace.WriteLine("Test d'écriture dans Trace");
            System.Diagnostics.Debug.WriteLine("Test d'écriture dans Debug"); 

            new Game(Universe.DummyPlayer).Run();
        }

        public static Game NewGame(Player player)
        {
            return new Game(player);
        }

        public static void ConsumeUsable(Player player, Player opponent, Usable usable)
        {
            usable.Consume(player, opponent);
        }

    }
       
}

