using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryReflection
{
    public class Dog : Ianimal //Sends the Dog class to the interface if called with message below
    {
        private string _message;

        public string Message
        {
            get
            {
                return _message;
            }
        }

    

        public Dog()
        {
            this._message = "Bark, Bark, Bark";
        }

    }
}
