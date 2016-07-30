using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indweek4ExceptionHandling
{
    class ExceptionTest : Exception
    {
        public override string Message
        {
            get
            {
                return "Silly Rabbit you can't divide by 0 and tricks are for kids.";
            }
        }
    }
}
