using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Semana01_Sesion01
{
    internal class Estudiante
    {

        public int codigo { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public int edad { get; set; }
        public int nota1 { get; set; }
        public int nota2 { get; set; }

        public Estudiante()
        {
            this.codigo = 100;
            this.nombre = "Juan";
            this.apellido = "Perez Castro";
            this.edad = 24;
            this.nota1 = 18;
            this.nota2 = 17;
        }
    }
}
