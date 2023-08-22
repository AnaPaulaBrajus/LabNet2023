using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public class CustomLogicException: Exception
    {
        public CustomLogicException(string message) : base(message)
        {

        }
    }
}
