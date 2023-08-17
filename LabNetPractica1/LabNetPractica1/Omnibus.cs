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
        public Omnibus(int cantPasajeros, string mensaje) : base(cantPasajeros, mensaje)
        {

        }

        public override string Avanzar()
        {
            return string.Format("Soy un omnibus y llevo {0} pasajeros",getPasajeros);
        }

    }
}
