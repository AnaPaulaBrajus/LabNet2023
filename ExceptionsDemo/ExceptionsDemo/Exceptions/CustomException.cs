﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo.Exceptions
{
    public class CustomException: Exception
    {
        public CustomException() : base("Mensaje de error de nuestra Custom Exception")
        {

        }

    }
}
