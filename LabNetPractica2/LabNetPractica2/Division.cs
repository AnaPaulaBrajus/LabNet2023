using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public class Division
    {
        public double Divide(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                throw new ChuckNorrisDivideByZeroException();
            }
            return dividendo / divisor;

        }
    }
}
