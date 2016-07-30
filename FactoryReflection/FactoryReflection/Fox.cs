using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryReflection
{
    public class Fox : Ianimal  //Sends the Fox class to the interface if called with message below
    {
        private string _message;

        public string Message
        {
            get
            {
                return _message;
            }
        }
 
        public Fox()
        {
            this._message = "What does the fox say?";
        }

    }
}
