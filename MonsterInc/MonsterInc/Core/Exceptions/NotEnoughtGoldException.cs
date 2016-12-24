using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    /// <summary>
    /// Lancée lorsqu'un entrraîneur tente d'acheter un item trop cher pour lui
    /// </summary>
    public class NotEnoughtGoldException : Exception
    {
        public NotEnoughtGoldException()
        {
        }

        public NotEnoughtGoldException(Core.Model.Trainer player, Core.Model.Item item) : base(
            $@"Impossible d'acheté l'item {item.Description}! {Environment.NewLine}
               Parce que vous avez {player.Gold} gold et l'item vaut {item.Gold}.")
        {
        }


        public NotEnoughtGoldException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotEnoughtGoldException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
