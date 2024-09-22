using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Semana01_Sesion01
{
    internal class Coordinador
    {

        public int codigo { get; set; }
        public string nombre { get; set; }
        public int categoria { get; set; }
        public int numCelular { get; set; }
        public string direccion { get; set; }

        public int sueldo()
        {
            int sueldo = 0;
            switch (sueldo)
            {
                case 0: sueldo = 8500; break;
                case 1: sueldo = 6850; break;
                case 2: sueldo = 5500; break;

            }
            return sueldo;
        }


    }
}
