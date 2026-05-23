using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Numerics;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    private static Alumno alumno1 = new Alumno(11, "Juan", 8.5);
    private static Alumno alumno2 = new Alumno(12, "Maria", 7.3);
    private static Alumno alumno3 = new Alumno(13, "Celeste", 7.9);

    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var listado = new CasoList();

        listado.agregarAlumnos(alumno1);
        listado.agregarAlumnos(alumno2);
        listado.agregarAlumnos(alumno3);

        buscarAlumnosListado(listado.ListarAlumnos);

        var alumnoABuscar1 = listado.buscarAlumno("Celeste");
        mostrarAlumnoEncontrado(alumnoABuscar1);
        var alumnoABuscar2 = listado.buscarAlumno("Martin");
        mostrarAlumnoEncontrado(alumnoABuscar2);
        
        listado.eliminarAlumno(alumno2);

        buscarAlumnosListado(listado.ListarAlumnos);

        listado.eliminarAlumnoPosicion(0);
        buscarAlumnosListado(listado.ListarAlumnos);
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var diccionario = new CasoDictionary();
        diccionario.AgregarAlumno(1000, alumno1);
        diccionario.AgregarAlumno(2000, alumno2);
        diccionario.AgregarAlumno(2500, alumno3);

        buscarAlumnosDiccionario(diccionario.Alumnos);

        Console.WriteLine(diccionario.buscarAlumno(1000));
        Console.WriteLine(diccionario.buscarAlumno(3000));

        diccionario.eliminarAlumno(2500);

        buscarAlumnosDiccionario(diccionario.Alumnos);
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostrar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq listadoLibros = new CasoLinq();

        Libro primerLibro = listadoLibros.GetPrimero();
        Console.WriteLine($"Primer libro: {primerLibro.Titulo}");

        Libro ultimoLibro = listadoLibros.GetUltimo();
        Console.WriteLine($"Último libro: {ultimoLibro.Titulo}");
        Console.WriteLine($"Total de precios: {listadoLibros.GetTotalPrecios():C}");
        Console.WriteLine($"4. Promedio de los precios: {listadoLibros.GetPromedioPrecios():C}");


        Console.WriteLine("Libros con Id mayor a 15:");
        foreach (Libro libro in listadoLibros.GetListById())
        {
            Console.WriteLine($"   - [ID: {libro.Id}] {libro.Titulo}");
        }

        Console.WriteLine("Lista:");
        foreach (string cadena in listadoLibros.GetLibros())
        {
            Console.WriteLine($"   - {cadena}");
        }

        Libro mayorPrecio = listadoLibros.GetMayorPrecio();
        Console.WriteLine($"Libro más caro: {mayorPrecio.Titulo} ({mayorPrecio.Precio:C})");

        Libro menorPrecio = listadoLibros.GetMenorPrecio();
        Console.WriteLine($"Libro más barato: {menorPrecio.Titulo} ({menorPrecio.Precio:C})");

        Console.WriteLine("Libros con precio mayor al promedio:");
        foreach (Libro libro in listadoLibros.GetMayorPromedio())
        {
            Console.WriteLine($"   - {libro.Titulo} ({libro.Precio:C})");
        }

        Console.WriteLine("Libros ordenados:");
        foreach (Libro libro in listadoLibros.GetLibrosOrdenados())
        {
            Console.WriteLine($"   - {libro.Titulo}");
        }
    }

    public static void buscarAlumnosListado(List<Alumno> alumnos)
    {
        foreach (var alumno in alumnos)
        {
            Console.WriteLine($"Nombre: {alumno.Nombre}, Promedio: {alumno.Promedio}");
        }
    }
    public static void mostrarAlumnoEncontrado(Alumno alumnoEncontrado)
    {
        if (alumnoEncontrado != null)
        {
            Console.WriteLine(alumnoEncontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }
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
