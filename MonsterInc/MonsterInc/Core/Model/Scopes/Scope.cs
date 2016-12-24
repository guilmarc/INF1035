using System;
using System.Xml.Serialization;

namespace Core.Model
{

    /// <summary>
    /// Un item et un skill peut avoir plusieurs scopes
    /// </summary>
    [Serializable]
    [XmlInclude(typeof(EffectScope))]
    [XmlInclude(typeof(DamageScope))]
    public abstract class Scope
	{
        /// <summary>
        /// Liste des cibles potentielles
        /// </summary>
		public enum ScopeTarget
		{
			Self = 0,
			Opponent
		}

        /// <summary>
        /// Cible du scope
        /// </summary>
		public ScopeTarget Target { get; set; } = ScopeTarget.Opponent;

        /// <summary>
        /// Durée de validation de ce scope en tours de combat
        /// </summary>
		public int Duration { get; set; } = 1;
	}
}
