using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    public abstract class TransportePublico
    {

        protected int pasajeros;

        public TransportePublico(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public abstract void Avanzar();
        public abstract void Detenerse();

        public int GetPasajeros()
        {
            return pasajeros;
        }


    }
}
