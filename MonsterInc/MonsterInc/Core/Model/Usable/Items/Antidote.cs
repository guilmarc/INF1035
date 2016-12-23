using System;

namespace Core.Model
{

    /// <summary>
    /// Permet de se "guerir" d'un état désagréable
    /// </summary>
    [Serializable]
    public class Antidote : Item
    {

        public override void Consume(Player player, Player opponent)
        {
            //player.ActiveTrainer.


            //throw new NotImplementedException();
        }
    }
}