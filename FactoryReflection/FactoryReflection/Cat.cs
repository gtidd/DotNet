using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryReflection
{
    public class Cat : Ianimal //Sends the Cat class to the interface if called with message below
    {
        private string _message;

        public string Message
        {
            get
            {
                return _message;
            }
        }

        public Cat()
        {
            this._message = "Meow, Meow, Meow";
        }
    }
}

