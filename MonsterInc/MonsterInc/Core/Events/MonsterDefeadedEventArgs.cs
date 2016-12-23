using System;
using Core.Model;

namespace Core.Events
{
    public class MonsterDefeadedEventArgs : EventArgs
    {
        public Player DefeatedMonsterPlayer { get; private set; }

        public MonsterDefeadedEventArgs(Player defeatedMonsterPlayer)
        {
            this.DefeatedMonsterPlayer = defeatedMonsterPlayer;
        }
    }
}