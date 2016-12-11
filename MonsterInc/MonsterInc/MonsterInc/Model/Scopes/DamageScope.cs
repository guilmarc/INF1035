using System;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace Core.Model
{

    /// <summary>
    /// Damage scope.
    /// </summary>
    //[Serializable]
    [XmlInclude(typeof(Scope))]
    [XmlRoot(Namespace = "Core.Model")]
    public class DamageScope : Scope 
	{
		public new int Magnitude { get; set; }
	}
}
