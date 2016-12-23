using System;
using System.Xml.Serialization;

namespace Core.Model
{
    [Serializable]
    [XmlInclude(typeof(EffectScope))]
    [XmlInclude(typeof(DamageScope))]
    public abstract class Scope
	{
		public enum ScopeTarget
		{
			Self = 0,
			Opponent
		}

		public ScopeTarget Target { get; set; } = ScopeTarget.Opponent;
		//public Effect Effect { get; set; }

        //[XmlIgnore]
		public virtual double Magnitude { get; set; }

		public int Duration { get; set; } = 1;
	}
}
