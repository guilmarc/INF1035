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
        /// <summary>
        /// Constructeur statique
        /// </summary>
        static Engine(){}
       
        /// <summary>
        /// Exécution d'une simulation de partie
        /// Sera complété après la remise (défi personnel)
        /// </summary>
        public static void RunDummyGame()
        {
            Console.WriteLine("Test d'écriture à la console");
            System.Diagnostics.Trace.WriteLine("Test d'écriture dans Trace");
            System.Diagnostics.Debug.WriteLine("Test d'écriture dans Debug"); 

            new Game(Universe.DummyPlayer).Run();
        }

        /// <summary>
        /// Création d'une nouvelle partie à partir d'un joueur
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static Game NewGame(Player player)
        {
            return new Game(player);
        }

        /// <summary>
        /// Chargement d'une partie à partir d'un fichier
        /// </summary>
        /// <param name="gameName"></param>
        /// <returns></returns>
        public static Game LoadGameFromFile(string gameName)
        {
            var filePath = Constants.SavedGamePath + gameName + Constants.SavedGameFileExtension;
            return Utils.Serializer.Binary.ReadFromBinaryFile<Game>(filePath);
        }
    }
}

