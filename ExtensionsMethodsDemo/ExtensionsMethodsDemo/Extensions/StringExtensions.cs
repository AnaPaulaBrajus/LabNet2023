using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethodsDemo.Extensions
{
    public static class StringExtensions
    {
        public static bool ContieneAlgo(this string cadena)
        {
            string cadenaEnMinusculas = cadena.ToLower();
            bool resultado = cadenaEnMinusculas.Contains("algo");

            return resultado;
        }
    }
}
