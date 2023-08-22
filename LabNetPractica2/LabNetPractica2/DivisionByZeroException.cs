using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public class DivisionByZeroException:Exception
    {
        public DivisionByZeroException(string message) : base("Exception: " + message)
        {

        }
    }
}
