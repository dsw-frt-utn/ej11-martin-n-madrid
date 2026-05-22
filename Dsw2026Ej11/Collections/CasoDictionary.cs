using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    public Dictionary<int, Alumno> Alumnos { get; }

    public CasoDictionary()
    {
        Alumnos = new Dictionary<int, Alumno>();
    }

    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        try
        {
            Alumnos.Add(legajo, alumno);
        }
        catch (ArgumentException aEx)
        {
            Console.WriteLine("El legajo ya existe en el diccionario." + aEx.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error inesperado." + ex.Message);
        }
    }

    public Alumno? buscarAlumno(int legajo)
    {
        try
        {
            return Alumnos[legajo];
        }
        catch (KeyNotFoundException knfEx)
        {
            Console.WriteLine($"No se encontró alumno con legajo {legajo}. Error: {knfEx.Message}");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error inesperado." + ex.Message);
            return null;
        }
    }

    public void eliminarAlumno(int legajo)
    {
        if (Alumnos.ContainsKey(legajo))
        {
            Alumnos.Remove(legajo);
            Console.WriteLine("Alumno eliminado");
        }
        else
        {
            Console.WriteLine("No se encontró al alumno con legajo: " + legajo);
        }
    }
}
