using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace MonsterInc
{
	public abstract class Item : IAction
	{
	    public string Name { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// Rareté de l'item. 100 = commun, 1=rare
        /// </summary>
        public int Rarity { get; set; }

        /// <summary>
        /// Coût de l'item en écu d'or
        /// </summary>
        public int Cost { get; set; }				

        public List<Scope> Scopes { get; set; }

		public void Consume();
	}
}
