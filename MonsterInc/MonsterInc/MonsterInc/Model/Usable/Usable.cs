using System;
using System.Collections.Generic;

namespace Core.Model
{
    public abstract class Usable
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Scope> Scopes { get; set; }

        public abstract void Consume(Player player, Player opponent);

        public override string ToString()
        {
            return this.Name;
        }
    }
}
