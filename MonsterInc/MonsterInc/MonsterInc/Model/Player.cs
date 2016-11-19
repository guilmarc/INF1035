using System;
using System.Collections.Generic;

namespace Core.Model
{
	public class Player
	{
		public string Name { get; set; }

        /// <summary>
        /// L'entraîneur en cours associé au joueur.  Dans une version future, le joueur pourrait sélectionner parmis une liste de Trainers
        /// </summary>
        public Trainer Trainer { get; set; }
    }
}
