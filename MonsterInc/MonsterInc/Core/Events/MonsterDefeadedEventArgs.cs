using System;
using Core.Model;

namespace Core.Events
{
    public class MonsterDefeadedEventArgs : EventArgs
    {
        public Monster DefeatedMonster { get; private set; }

        public MonsterDefeadedEventArgs(Monster defeatedMonster)
        {
            this.DefeatedMonster = defeatedMonster;
        }
    }
}