
﻿using System;
using System.Collections.Generic;

namespace Core.Data
{
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

        public static string GetRandomTrainerName()
        {
            return TrainerNames[Utils.Random(TrainerNames.Count - 1)];
        }
    }
}