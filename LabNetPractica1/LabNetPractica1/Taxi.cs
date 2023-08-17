using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    public class Taxi:TransportePublico
    {
        public Taxi(int cantPasajeros, string mensaje) : base(cantPasajeros, mensaje)
        {

        }

        public override string Avanzar()
        {
            return $"Soy un taxi y llevo {getPasajeros} pasajeros";
        }
    }
}
