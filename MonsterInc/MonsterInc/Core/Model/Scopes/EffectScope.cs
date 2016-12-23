using System;
using System.Xml.Serialization;

namespace Core.Model
{

    [Serializable]
    public class EffectScope : Scope
	{
        //[XmlIgnore]
		public new double Magnitude { get; set; } = 1.0;
	}
}
