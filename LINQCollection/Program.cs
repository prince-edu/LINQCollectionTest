using LINQCollection;
using System.Linq;

//Coleccion numeros
/*    int[] numeros = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
Console.WriteLine("A continuacion mostramos los numeros pares que existen en el arreglo:");

//Seleccion de pares sin LINQ
List<int> lista_numeros_pares = new List<int>();
foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        lista_numeros_pares.Add(numero);
    }
}

//Seleccion de numeros pares con LINQ

//En numero se guarda los elementos de la colleccion numeros
IEnumerable<int> numeros_pares = from numero in numeros where numero % 2 == 0 select numero;

//Impresion numeros pares
foreach(int numero in numeros_pares)
{
    Console.WriteLine(numero);
}

/*
 *Crear dos clases:
 *Carrera: IdCarrera (int), nombre (string).
 *Alumno: IdAlumno (int), nombre (string), matricula (string), promedio (double), IdCarrera (int).
 *Esos datos los quiere como propiedades no como atributos.
 */
/*
//ejemplo control alumno objetos
*/

ControlAlumnos controlAlumnos = new ControlAlumnos();
controlAlumnos.obtenerAlumnos(2);