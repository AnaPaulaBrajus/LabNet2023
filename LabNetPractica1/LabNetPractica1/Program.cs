using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TransportePublico> transportes = new List<TransportePublico>();

            Console.WriteLine("**************************************");
            Console.WriteLine("*  Bienvenido a la App de Transporte  *");
            Console.WriteLine("**************************************");
            Console.WriteLine();

            string respuesta;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("¿Desea ingresar un Taxi (T) o un Ómnibus (O)? ");
                string tipoTransporte = Console.ReadLine();
                Console.ResetColor();

                if (tipoTransporte.Equals("T", StringComparison.OrdinalIgnoreCase))
                {
                    int pasajerosTaxi;
                    while (true)
                    {
                        Console.Write("Ingrese la cantidad de pasajeros para el Taxi: ");
                        if (int.TryParse(Console.ReadLine(), out pasajerosTaxi) && pasajerosTaxi >= 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cantidad de pasajeros inválida. Intente de nuevo.");
                            Console.ResetColor();
                        }
                    }
                    transportes.Add(new Taxi(pasajerosTaxi));
                }
                else if (tipoTransporte.Equals("O", StringComparison.OrdinalIgnoreCase))
                {
                    int pasajerosOmnibus;
                    while (true)
                    {
                        Console.Write("Ingrese la cantidad de pasajeros para el Ómnibus: ");
                        if (int.TryParse(Console.ReadLine(), out pasajerosOmnibus) && pasajerosOmnibus >= 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cantidad de pasajeros inválida. Intente de nuevo.");
                            Console.ResetColor();
                        }
                    }
                    transportes.Add(new Omnibus(pasajerosOmnibus));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tipo de transporte no válido. Intente de nuevo.");
                    Console.ResetColor();
                }

                while (true)
                {
                    Console.Write("¿Desea ingresar otro transporte? (S/N): ");
                    respuesta = Console.ReadLine();
                    if (respuesta.Equals("S", StringComparison.OrdinalIgnoreCase) || respuesta.Equals("N", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Respuesta inválida. Intente de nuevo.");
                        Console.ResetColor();
                    }
                }
            }
            while (respuesta.Equals("S", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**************************************");
            Console.WriteLine("*        Listas de Transportes        *");
            Console.WriteLine("**************************************");
            Console.ResetColor();
            Console.WriteLine();

            int numeroTaxi = 1;
            int numeroOmnibus = 1;

            bool hayTaxis = false;
            bool hayOmnibus = false;

            foreach (var transporte in transportes)
            {
                if (transporte is Taxi)
                {
                    if (!hayTaxis)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("**************************************");
                        Console.WriteLine("*            Listas de Taxis          *");
                        Console.WriteLine("**************************************");
                        Console.ResetColor();
                        hayTaxis = true;
                    }

                    Console.WriteLine($"Taxi {numeroTaxi}: {transporte.GetPasajeros()} pasajeros");
                    numeroTaxi++;
                }
                else if (transporte is Omnibus)
                {
                    if (!hayOmnibus)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("**************************************");
                        Console.WriteLine("*         Listas de Ómnibus           *");
                        Console.WriteLine("**************************************");
                        Console.ResetColor();
                        hayOmnibus = true;
                    }

                    Console.WriteLine($"Ómnibus {numeroOmnibus}: {transporte.GetPasajeros()} pasajeros");
                    numeroOmnibus++;
                }
            }

            if (!hayTaxis)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("**************************************");
                Console.WriteLine("*            Listas de Taxis          *");
                Console.WriteLine("**************************************");
                Console.ResetColor();
                Console.WriteLine("No se han ingresado taxis todavía.");
            }

            if (!hayOmnibus)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("**************************************");
                Console.WriteLine("*         Listas de Ómnibus           *");
                Console.WriteLine("**************************************");
                Console.ResetColor();
                Console.WriteLine("No se han ingresado ómnibus todavía.");
            }

            Console.WriteLine();
            Console.WriteLine("¡Gracias por usar nuestra App de Transporte!");
            Console.ReadKey();
        }
    }
}



