using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace MonsterInc
{
	public abstract class Item : IActionable
    {
	    public string Name { get; set; }
        public string Description { get; set; }
        
		/// <summary>
		/// Coût de l'item en écu d'or
		/// </summary>
		public int Cost { get; set; }				

        public List<Scope> Scopes { get; set; }

        public abstract void Consume();
    }
}
