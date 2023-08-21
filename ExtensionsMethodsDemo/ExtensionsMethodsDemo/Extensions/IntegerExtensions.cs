using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethodsDemo.Extensions
{
    public static class IntegerExtensions
    {
        public static int Sumar(this int numero)
        {
            return numero +10;
        }

        public static int Sumar(this int numero, int otroNumero)
        {
            return numero + otroNumero;
        }

        public static bool EsMayorQueCien(this int numero)
        {
            return numero > 100;
        }

        public static bool EsMayorQue(this int numero, int otroNumero)
        {
            return numero > otroNumero;
        }

    }
}
