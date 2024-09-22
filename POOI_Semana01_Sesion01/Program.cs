using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Semana01_Sesion01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estudiante es1 = new Estudiante();

            Console.WriteLine("Hola mundo en C#");
            Console.WriteLine("");

            Console.WriteLine("Datos de estudiante:");
            Console.WriteLine("");

            Console.WriteLine("Codigo    : " + es1.codigo);
            Console.WriteLine("Nombre    : " + es1.nombre);
            Console.WriteLine("Apellidos : " + es1.apellido);
            Console.WriteLine("Edad      : " + es1.edad);
            Console.WriteLine("Nota 1    : " + es1.nota1);
            Console.WriteLine("Nota 2    : " + es1.nota2);*/


            /*Docente dc = new Docente();

            dc.codigo = 200;
            dc.nombre = "Ronaldo";
            dc.horasTrabajadas = 50;
            dc.tarifaHoraria = 5.70;

            Console.WriteLine("Codigo           : " + dc.codigo);
            Console.WriteLine("Nombre           : " + dc.nombre);
            Console.WriteLine("Horas trabajadas : " + dc.horasTrabajadas);
            Console.WriteLine("Tarifa por Horas : " + dc.tarifaHoraria);
            Console.WriteLine("Sueldo bruto     : " + dc.sueldoBruto());
            Console.WriteLine("Descuento        : " + dc.descuento());
            Console.WriteLine("Sueldo neto      : " + dc.sueldoNeto());*/


            /*Filmacion film = new Filmacion();

            film.codigo = 101;
            film.titulo = "Pelicula 1";
            film.duMinutos = 120;
            film.precioSoles = 25.50;

            Console.WriteLine("Codigo              : " + film.codigo);
            Console.WriteLine("Titulo              : " + film.titulo);
            Console.WriteLine("Duracion en minutos : " + film.duMinutos);
            Console.WriteLine("Precio en soles     : " + film.precioSoles);
            Console.WriteLine("Precio en dolares   : " + film.precioDolares());*/

            /*Persona juan = new Persona();

            juan.nombre = "Juan";
            juan.apellido = "Perez";
            juan.edad = 25;
            juan.peso = 75;
            juan.estatura = 1.80;

            Console.WriteLine("Nombre  : " + juan.nombre);
            Console.WriteLine("Apellido: " + juan.apellido);
            Console.WriteLine("Edad    : " + juan.edad);
            Console.WriteLine("Estado  : " + juan.estadoPesona());
            Console.WriteLine("Peso    : " + juan.peso);
            Console.WriteLine("Estatura: " + juan.estatura);
            Console.WriteLine("IMC     : " + juan.indiceMasaCorporal());*/

            Coordinador cor = new Coordinador();

            cor.codigo = 101;
            cor.nombre = "Pedro";
            cor.categoria = 1;
            cor.numCelular = 982344222;

            Console.WriteLine("Nombre         : " + cor.nombre);
            Console.WriteLine("Codigo         : " + cor.codigo);
            Console.WriteLine("Categoria      : " + cor.categoria);
            Console.WriteLine("Numero celular : " + cor.numCelular);
            Console.WriteLine("Sueldo         : " + cor.sueldo());




            Console.ReadKey();
        }
    }
}
