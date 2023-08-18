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

            string respuesta;

            do
            {
                Console.Write("¿Desea ingresar un Taxi (T) o un Ómnibus (O)? ");
                string tipoTransporte = Console.ReadLine();

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
                            Console.WriteLine("Cantidad de pasajeros inválida. Intente de nuevo.");
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
                            Console.WriteLine("Cantidad de pasajeros inválida. Intente de nuevo.");
                        }
                    }
                    transportes.Add(new Omnibus(pasajerosOmnibus));
                }
                else
                {
                    Console.WriteLine("Tipo de transporte no válido. Intente de nuevo.");
                }

                Console.Write("¿Desea ingresar otro transporte? (S/N): ");
                respuesta = Console.ReadLine();
            }
            while (respuesta.Equals("S", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine();
            Console.WriteLine("Listas de transportes:");
            Console.WriteLine();

            int numeroTaxi = 1;
            int numeroOmnibus = 1;

            Console.WriteLine("Listas de taxis:");
            foreach (var transporte in transportes)
            {
                if (transporte is Taxi)
                {
                    Console.WriteLine($"Taxi {numeroTaxi}: {transporte.GetPasajeros()} pasajeros");
                    numeroTaxi++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Listas de omnibus:");
            foreach (var transporte in transportes)
            {
                if (transporte is Omnibus)
                {
                    Console.WriteLine($"Ómnibus {numeroOmnibus}: {transporte.GetPasajeros()} pasajeros");
                    numeroOmnibus++;
                }
            }
            Console.ReadKey();
        }
    }
}
