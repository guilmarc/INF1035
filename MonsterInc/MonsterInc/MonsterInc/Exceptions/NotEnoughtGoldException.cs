using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterInc
{
    class NotEnoughtGoldException : Exception
    {
        public NotEnoughtGoldException(string message) : base(message)
        {
            //Typed Exception
        }
    }
}
