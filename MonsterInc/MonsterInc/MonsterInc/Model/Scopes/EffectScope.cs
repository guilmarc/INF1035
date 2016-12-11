using System;
using System.Xml.Serialization;

namespace Core.Model
{

    /// <summary>
    ///
    /// </summary>
    [XmlInclude(typeof(EffectScope))]
    [XmlRoot(Namespace = "Core.Model")]
    public class EffectScope : Scope
	{
		public new double Magnitude { get; set; } = 1.0;
	}
}
