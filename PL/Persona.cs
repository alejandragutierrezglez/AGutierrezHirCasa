using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Peso { get; set; }

        public string CambiaNombre() {

            return Nombre = "Hola_" + Nombre;
        }
        public int Calcula()
        {
            return Edad * Peso;
        
        }
    }
}
