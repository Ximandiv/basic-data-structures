using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Ejemplos.Array
{
    public class Profesor
    {
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public int CtdNotasPeriodo { get; set; }
        public Alumno[]? AlumnosAsignados { get; set; }

        public Profesor(string nombre, string materia, int ctdNotasPeriodo)
        {
            Nombre = nombre;
            Materia = materia;
            CtdNotasPeriodo = ctdNotasPeriodo;
        }

        //Saca promedio de notas de cada uno de sus alumnos asignados.
        public void SacarPromedioDeNotas(Alumno[] alumnosACalificar)
        {
            foreach(Alumno alumno in alumnosACalificar)
            {
                double promedioAlumno = CalcularPromedio(alumno);
                alumno.NotaPromedio = promedioAlumno;
            }
        }

        //Muestra los alumnos que se le han sido asignado a la sala el dia de hoy.
        public void MostrarAlumnosDeHoy()
        {
            Console.WriteLine("Mis alumnos de hoy son:");
            foreach (Alumno alumno in this.AlumnosAsignados)
            {
                Console.WriteLine(alumno.Nombre);
            }
        }

        //Calcula el promedio de las notas de sus alumnos.
        public double CalcularPromedio(Alumno alumno)
        {
            double sumaDeNotas = alumno.Notas.Sum();
            double resultado = Math.Round(sumaDeNotas / this.CtdNotasPeriodo, 1);

            return resultado;
        }
    }
}
