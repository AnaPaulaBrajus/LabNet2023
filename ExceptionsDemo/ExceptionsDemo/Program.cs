using ExceptionsDemo.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Exceptions");

            //try
            //{
            //    EjemploExceptions.ThrowException();

            //}
            //catch
            //{
            //    Console.WriteLine("Rompio");
            //}

            //EjemploExceptions.PruebaReturnConFinally();

            //EjemploExceptions.RealizarOperacion(null,2,false);


            try
            {
                EjemploExceptions.ThrowCustomException();

            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Se capturo la exception custom: '{ex.Message}'");
            }
            finally
            {
                Console.WriteLine("Siempre que tengas un finally va a pasar bajo cualquier circunstancia");
            }

            Console.WriteLine("Termino");
            Console.ReadKey();

        }
    }
}
