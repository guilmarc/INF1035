using System;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace Core.Model
{
    [Serializable]
    public class DamageScope : Scope 
	{
		public int Magnitude { get; set; }
	}
}
