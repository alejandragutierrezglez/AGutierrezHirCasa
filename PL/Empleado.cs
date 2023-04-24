using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string PuestoTrabajo { get; set; }
        public decimal SueldoBase { get; set; }
        public PL.Superior SuperiorDirecto { get; set; }
        public PL.Grupo Grupo { get; set; }
        public List<object> Empleados { get; set; }
    }
}
