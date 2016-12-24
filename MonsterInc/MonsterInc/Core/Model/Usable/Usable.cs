using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Core.Model
{
    /// <summary>
    /// Classe parente à tout ce qui peut être utilisé par le joueur
    /// </summary>
    [Serializable]
    public abstract class Usable
    {
        /// <summary>
        /// Nom de l'utilisabilité
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description de l'utilisabilité
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Liste des scopes d'effets de cet utilisabilité
        /// </summary>
        public List<Scope> Scopes { get; set; }

        /// <summary>
        /// Contrat de consommation de l'utilisabilité
        /// </summary>
        /// <param name="player"></param>
        /// <param name="opponent"></param>
        public abstract void Consume(Player player, Player opponent);

        /// <summary>
        /// Affichage
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
