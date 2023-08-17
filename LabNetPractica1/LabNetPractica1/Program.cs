using System;
using System.Collections.Generic;
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
            Console.WriteLine("¿Que tipo de trasporte es: O:Omnibus, T:Taxi?");
            string tipo = Console.ReadLine();
            if (tipo.ToUpper() == "O")
            {
                TransportePublico transporte = new Omnibus(100, "Soy un omnibus");
                transportes.Add(transporte);
            }
            else if(tipo.ToUpper()=="T")
            {
                TransportePublico transporte2 = new Taxi(2, "Soy un taxi");
                transportes.Add(transporte2);

            }
            else
            {
                Console.WriteLine("Respuesta no valida, por favor ingresar O ó T");
                Console.ReadKey();
            }

            foreach(var item in transportes)
            {
                Console.WriteLine(item.Avanzar());
                Console.WriteLine(item.Dialogar());
            }

        }
    }
}
