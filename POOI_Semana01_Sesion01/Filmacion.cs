using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Semana01_Sesion01
{
    internal class Filmacion
    {

        public int codigo { get; set; }
        public string titulo { get; set; }
        public int duMinutos { get; set; }
        public double precioSoles { get; set; }

        public double precioDolares()
        {
            return precioSoles * 3.59;
        }


    }
}
