
﻿using System;
using System.Collections.Generic;

namespace Core.Data.Static
{
    /// <summary>
    /// Classe de données hardcodées temporaires (non utilisée en mode runtime)
    /// </summary>
    public static class TrainerData
    {
        public static List<string> TrainerNames
        {
            get
            {
                return new List<string>() //TODO: Donner de vrai noms d'entraîneurs
                {
                    "Trainer1",
                    "Trainer2",
                    "Trainer3",
                    "Trainer4",
                    "Trainer5",
                    "Trainer6",
                    "Trainer7",
                    "Trainer8",
                    "Trainer9"
                };
            }
        }
    }
}