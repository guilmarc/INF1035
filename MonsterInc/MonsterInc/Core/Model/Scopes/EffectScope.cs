using System;
using System.Xml.Serialization;

namespace Core.Model
{
    /// <summary>
    /// Scope basé sur un un effet à valeur relative
    /// </summary>
    [Serializable]
    public class EffectScope : Scope
	{
		public double Magnitude { get; set; } = 1.0;
	}
}
