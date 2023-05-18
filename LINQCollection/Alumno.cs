using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQCollection
{
    internal class Alumno
    {
        public int IdAlumno { get; set; }
        public string? Nombre { get; set; }
        public string? Matricula { get; set; }
        public double Promedio { get; set; }
        public int IdCarrera { get; set; }

        public void getDatosAlumno()
        {
            //Inserta los parametros ubicados en el lado derecho en su respectivo indice dentro de la cadena.
            //Los parametros los toma como si fuera un Array de elementos (objetos) aunque sean de distinto tipo, ya que los transforma a string.
            Console.WriteLine("Alumno {0} con matricula {1} y promedio {2} en la carrera con ID {3}", Nombre, Matricula, Promedio, IdCarrera);
        }
    }
}