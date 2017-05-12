using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ape_rutas
{
    class Base
    {
        public string nombre { get; set; }
        public int minutos { get; set; }
        public Base anterior { get; set; }
        public Base siguiente { get; set; }

        public Base(string nombre, int minutos)
        {
            this.nombre = nombre;
            this.minutos = minutos;
            anterior = null;
            siguiente = null;
        }

        public override string ToString()
        {
            string vBase = "Nombre: " + nombre.ToString() +
                          Environment.NewLine + "Minutos desde la base anterior: " + minutos.ToString() + Environment.NewLine;

            return vBase;
        }
    }
}
