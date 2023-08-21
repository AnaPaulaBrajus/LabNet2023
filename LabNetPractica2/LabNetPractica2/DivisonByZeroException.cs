using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public class DivisonByZeroException:Exception
    {
        public DivisonByZeroException(string message) : base("Exception: " + message)
        {

        }
    }
}
