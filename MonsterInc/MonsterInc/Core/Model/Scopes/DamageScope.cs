using System;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace Core.Model
{
    [Serializable]
    public class DamageScope : Scope 
	{
        //[XmlIgnore]
		public new int Magnitude { get; set; }
	}
}
