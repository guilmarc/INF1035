using System;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace Core.Model
{
    /// <summary>
    /// Scope basé sur un un effet à valeur fixe
    /// </summary>
    [Serializable]
    public class DamageScope : Scope 
	{
		public int Magnitude { get; set; }
	}
}
