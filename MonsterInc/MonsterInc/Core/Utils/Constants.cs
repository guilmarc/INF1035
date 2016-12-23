﻿using System.IO;
using Core.Exceptions;
using System;

namespace Core
{
    public static class Constants
    {
        public const int ActiveInventoryCount = 5;
        public const int InitGoldCount = 1000;
        public const int MaxActiveMonstersCount = 5;
        public const float HumanizeFactor = 0.2f;
        public const string SavedGameFileExtension = ".game";
        private const string SavedGameFolderName = "Data\\Games\\";
        private const string UniverseDataFolderName = "Data\\Universe\\";

        /// <summary>
        /// Retournera le path relatif à l'exécution du Core
        /// </summary>
        private static string _universeDataPath = null;
        public static string UniverseDataPath
        {
            get
            {
                var requestedPath = AppDomain.CurrentDomain.BaseDirectory + UniverseDataFolderName;
                CreatePathIfNotExist(requestedPath);
                _universeDataPath = requestedPath;
                return _universeDataPath;
            }
        }

        /// <summary>
        /// Retournera le path relatif à l'exécutuon de l'Interface Visuelle
        /// </summary>
        private static string _savedGamePath = null;
        public static string SavedGamePath
        {
            get
            {
                if (_savedGamePath == null)
                {
                    var requestedPath = AppDomain.CurrentDomain.BaseDirectory + SavedGameFolderName;
                    CreatePathIfNotExist(requestedPath);
                    _savedGamePath = requestedPath;
                }

                return _savedGamePath;
            }
        }

        /// <summary>
        /// Création d'un répertoire au besoin, retourne une exception si erreur lors de la création
        /// </summary>
        /// <param name="requestedPath"></param>
        private static void CreatePathIfNotExist(string requestedPath)
        {
            if (!Directory.Exists(requestedPath))
            {
                Directory.CreateDirectory(requestedPath);
            }
        }

    }
}