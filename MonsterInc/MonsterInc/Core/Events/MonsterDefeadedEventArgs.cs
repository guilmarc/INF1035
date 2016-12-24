using System;
using Core.Model;

namespace Core.Events
{
    /// <summary>
    /// Arguments de l'événement déclanchée lors de la mort d'un monstre
    /// </summary>
    public class MonsterDefeadedEventArgs : EventArgs
    {
        public Player DefeatedMonsterPlayer { get; private set; }

        public MonsterDefeadedEventArgs(Player defeatedMonsterPlayer)
        {
            this.DefeatedMonsterPlayer = defeatedMonsterPlayer;
        }
    }
}