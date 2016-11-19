using System;

namespace Core.Model
{

    /// <summary>
    /// Permet de se "guerir" d'un état désagréable
    /// </summary>
    public class Antidote : Item
    {
        public override void Consume()
        {
            throw new NotImplementedException();
        }
    }
}