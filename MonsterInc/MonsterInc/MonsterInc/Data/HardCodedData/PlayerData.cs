using System.Collections.Generic;

namespace Core.Data
{
    public class PlayerData
    {
        public static List<string> OpponentNames
        {
            get
            {
                return new List<string>() //TODO: Donner de vrai noms d'opponent
                {
                    "Opponent1",
                    "Opponent2",
                    "Opponent3",
                    "Opponent4",
                    "Opponent5",
                    "Opponent6",
                    "Opponent7",
                    "Opponent8",
                    "Opponent9"
                };
            }
        }

        public static string GetRandomOpponentName()
        {
            return OpponentNames[Utils.Random(OpponentNames.Count - 1)];
        }
    }
}