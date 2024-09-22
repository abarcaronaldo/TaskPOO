using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Semana01_Sesion01
{
    internal class Docente
    {

        public int codigo { get; set; }
        public string nombre { get; set; }
        public int horasTrabajadas { get; set;}
        public double tarifaHoraria { get; set; }

        public double sueldoBruto() {
            return horasTrabajadas * tarifaHoraria;
        }

        public double descuento()
        {  
            if (sueldoBruto() < 4500)
            {
                return sueldoBruto() * 0.12;
            }
            else if (sueldoBruto()>=4500 && sueldoBruto() < 4600)
            {
                return sueldoBruto() * 0.14;
            }
            else
            {
                return sueldoBruto() * 0.16;
            }
        }

        public double sueldoNeto()
        {
            return sueldoBruto() - descuento();
        }

    }
}
