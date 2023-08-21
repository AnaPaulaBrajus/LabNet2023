using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese un valor");
                int divisor=int.Parse(Console.ReadLine());

                if (divisor==0)
                {
                    throw new DivisonByZeroException("Division por cero no permitida");
                }
            }
            catch (DivisonByZeroException ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: "+ ex.Message);
            }
            finally
            {
                Console.WriteLine("Operacion completada");
                Console.ReadKey();
            }
        }
    }
}
