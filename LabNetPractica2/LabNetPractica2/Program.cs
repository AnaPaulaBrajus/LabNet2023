using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            Console.WriteLine("------------");
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("------------");
            try
            {
                Console.WriteLine("Ingrese un valor:");
                int divisor = int.Parse(Console.ReadLine());

                if (divisor == 0)
                {
                    throw new DivisionByZeroException("Division por cero no permitida");
                }
            }
            catch (DivisionByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Operacion completada");
                Console.ReadKey();
            }

            //Ejercicio 2
            Console.WriteLine("------------");
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("------------");
            try
            {
                Console.WriteLine("Ingrese el dividendo: ");
                double dividendo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el divisor:");
                double divisor = Convert.ToDouble(Console.ReadLine());

                Division division = new Division();
                double resultado = division.Divide(dividendo, divisor);

                Console.WriteLine($"Resultado de la división: {resultado}");
                Console.ReadKey();
            }
            catch (ChuckNorrisDivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("¡Seguro ingreso una letra o no ingresó nada!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.ReadKey();
            }

            //Ejercicio 3
            Console.WriteLine("------------");
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("------------");
            Logic logic = new Logic();
            try
            {
                logic.ThrowException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tipo de excepción: {ex.GetType().FullName}");
                Console.WriteLine($"Mensaje de la excepcion: {ex.Message}");
                Console.ReadKey();
            }

            //Ejercicio 4
            Console.WriteLine("------------");
            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("------------");
            Logic logic4 = new Logic();
            try
            {
                logic4.ThrowCustomException();
            }
            catch (CustomLogicException ex)
            {
                Console.WriteLine($"Tipo de excepción: {ex.GetType().FullName}");
                Console.WriteLine($"Mensaje de la excepcion: {ex.Message}");
                Console.ReadKey();
            }
        }
    }
}
