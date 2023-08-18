using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    public class Omnibus: TransportePublico
    {
        public Omnibus(int pasajeros) : base(pasajeros)
        {
        }

        public override void Avanzar()
        {
            Console.WriteLine("Ómnibus avanzando...");
        }

        public override void Detenerse()
        {
            Console.WriteLine("Ómnibus deteniéndose...");
        }

    }
}
