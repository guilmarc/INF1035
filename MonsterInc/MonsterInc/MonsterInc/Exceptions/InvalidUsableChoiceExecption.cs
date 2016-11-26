using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterInc.Exceptions
{
    class InvalidUsableChoiceExecption :Exception
    {

        public InvalidUsableChoiceExecption(Usable usable, string message) : base(message)
        {
            //Typed Exception
        }
        
    }
}
