using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Numerics;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var diccionario = new CasoDictionary();
        diccionario.AgregarAlumno(1000, new Alumno(11, "Juan", 8.5));
        diccionario.AgregarAlumno(2000, new Alumno(12, "Maria", 7.3));
        diccionario.AgregarAlumno(2500, new Alumno(13, "Celeste", 7.9));

        buscarAlumnosDiccionario(diccionario.Alumnos);

        Console.WriteLine(diccionario.buscarAlumno(1000));
        Console.WriteLine(diccionario.buscarAlumno(3000));

        diccionario.eliminarAlumno(2500);

        buscarAlumnosDiccionario(diccionario.Alumnos);
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }

    public static void buscarAlumnosDiccionario(Dictionary<int, Alumno> alumnos)
    {
        foreach (KeyValuePair<int, Alumno> elemento in alumnos)
        {
            int legajo = elemento.Key;
            Alumno alumnoActual = elemento.Value;

            Console.WriteLine($"Legajo: {legajo}, Nombre: {alumnoActual.Nombre}, Promedio: {alumnoActual.Promedio}");
        }
    }
}
