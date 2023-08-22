using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public class Logic
    {
        public void ThrowException()
        {
            throw new Exception("¡Se ha disparado una excepcion desde la clase Logic!");
        }

        public void ThrowCustomException()
        {
            throw new CustomLogicException("¡Se ha disparado una excepcion personalizada desde la clase Logic!");
        }
    }
}
