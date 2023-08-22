using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public class ChuckNorrisDivideByZeroException: Exception
    {
        public ChuckNorrisDivideByZeroException() : base("¡Solo Chuck Norris divide por cero!")
        {

        }

        public ChuckNorrisDivideByZeroException(string message) : base($"¡Solo Chuck Norris divide por cero! {message}")
        {

        }
    }

}
