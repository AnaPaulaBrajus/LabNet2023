using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo.Exceptions
{
    public class EjemploExceptions
    {
        public static void ThrowException()
        {
            try
            {
                DateTime? fechaConValorNull = null;
                Console.WriteLine("Esto va a romper!!");

                string fechaFormateada = fechaConValorNull.Value.ToString("MM/yy");
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Console.WriteLine("Finally paso");
            }
        }

        public static int PruebaReturnConFinally()
        {
            try
            {
                return 1234; //Igualmente pasa por el finally
            }
            finally
            {
                Console.WriteLine("Igualmente se pasa por finally");
            }
        }

        public static void RealizarOperacion(int? i, int j, bool dividir)
        {
            try
            {
                int multiplicacion = i.Value * j;
                Console.WriteLine("El resultado es: "+multiplicacion);

                if (dividir)
                {
                    int division = i.Value / j;
                    Console.WriteLine("El resultado es: "+division);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("No se puede dividir por cero.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Devolvio invalidoperation exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje de la Exception");
                Console.WriteLine(ex.Message);

                Console.WriteLine("StackTrace de la Exception");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("El codigo siempre pasa por el finally");
            }
        }

        public static void ThrowCustomException()
        {
            throw new CustomException();
        }
    }
}
