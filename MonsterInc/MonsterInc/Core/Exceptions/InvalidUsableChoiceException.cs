using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    /// <summary>
    /// Nous avons finalement décidé que le joueur perdra son tour s'il choisi un Usable invalide
    /// </summary>
    class InvalidUsableChoiceException : Exception
    {
        public InvalidUsableChoiceException(Usable usable, string message) : base(message)
        {
        }
        
    }
}
