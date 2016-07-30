using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryReflection
{
    public interface Ianimal //used to create one factory one method for many classes.
    {
        string Message
        {
            get;
        }
    }
}
