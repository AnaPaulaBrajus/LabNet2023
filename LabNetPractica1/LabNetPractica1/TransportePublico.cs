using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    public abstract class TransportePublico:IDialogar
    {
        public TransportePublico(int cantPasajeros, string mensaje)
        {
            getPasajeros = cantPasajeros;
            this.mensaje = mensaje;
        }

        public int getPasajeros { get; }

        public string mensaje { get; }

        public abstract string Avanzar();

        public string Dialogar()
        {
            return mensaje;
        }



    }
}
