using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Semana01_Sesion01
{
    internal class Persona
    {

        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public double estatura { get; set; }
        public double peso { get; set;}


        public String estadoPesona()
        {
            if (edad < 18)
                return "Menor de edad";
            else
                return "Mayor de edad";
        }

        public double indiceMasaCorporal()
        {
            return (peso / (estatura * estatura));
        }
    }
}
