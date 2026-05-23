using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> alumnos;

    public CasoList()
    {
        alumnos = new List<Alumno>();
    }
    public void agregarAlumnos(Alumno nuevoAlumno)
    {
        alumnos.Add(nuevoAlumno);
    }
    public List<Alumno> ListarAlumnos => alumnos;
    public Alumno? buscarAlumno(string nombreAlumno)
    {
        return alumnos.Find(alumno => alumno.Nombre == nombreAlumno);
    }
    public void eliminarAlumno(Alumno alumnoEliminar)
    {
        alumnos.Remove(alumnoEliminar);
    }
    public void eliminarAlumnoPosicion(int index)
    {
        alumnos.RemoveAt(index);
    }
}
