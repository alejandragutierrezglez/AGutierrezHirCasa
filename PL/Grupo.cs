using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Grupo
    {
        public string NombreOficina { get; set; }
        public int CodigoAreaDepartamental { get; set; }
        public PL.Empleado Empleado { get; set; }
    }
}
