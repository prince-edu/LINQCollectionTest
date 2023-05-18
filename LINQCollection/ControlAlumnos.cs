using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQCollection
{
    internal class ControlAlumnos
    {
        List<Carrera> carreras = new List<Carrera>();
        List<Alumno> alumnos = new List<Alumno>();

        public ControlAlumnos() {
            carreras.Add(new Carrera { IdCarrera = 1, Nombre = "Ingenieria de Software" });
            carreras.Add(new Carrera { IdCarrera = 2, Nombre = "Redes" });

            alumnos.Add(new Alumno { IdAlumno = 1, Nombre = "Juan", Matricula = "s20023848", Promedio = 8.5, IdCarrera = 1 });
            alumnos.Add(new Alumno { IdAlumno = 2, Nombre = "Maria", Matricula = "s2002456", Promedio = 9.5, IdCarrera = 2 });
            alumnos.Add(new Alumno { IdAlumno = 1, Nombre = "Raudel", Matricula = "s2035675", Promedio = 8.7, IdCarrera = 1 });
        }

        public void obtenerAlumnos(int idCarrera)
        {
            IEnumerable<Alumno> resultado = from alumno in alumnos where alumno.IdCarrera == idCarrera select alumno;//que diga el no,bre de la carrera en lugar del id, con un join.


            foreach (Alumno alumno in resultado)
            {
                alumno.getDatosAlumno();
            }
        }

    }
}
