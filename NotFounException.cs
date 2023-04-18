using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekTask
{
    internal class NotFounException:Exception
    {
        public NotFounException(string message):base(message)
        {

        }
    }
}
