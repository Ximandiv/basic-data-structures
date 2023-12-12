using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Ejemplos.Array
{
    public class Sala1A
    {
        public Profesor ProfesorAsignado { get; set; }
        public Alumno[] AlumnosEnSala { get; set; }

        public Sala1A(Profesor profesor, Alumno[] alumnos)
        {
            ProfesorAsignado = profesor;
            AlumnosEnSala = alumnos;
        }

        //Asigna al profesor los alumnos que tenga el dia de hoy.
        public void AsignarAlumnos(Alumno[] alumnos, Profesor profesorAsignar)
        {
            profesorAsignar.AlumnosAsignados = alumnos;
        }

        //Asigna a los alumnos el profe que tienen el dia de hoy.
        public void AsignarProfe(Profesor profesorAsignado)
        {
            foreach(Alumno alumno in this.AlumnosEnSala)
            {
                alumno.ProfesorAsignado = profesorAsignado;
            }
        }

        //Muestra quien hay en la sala.
        public void MostrarQuienHay()
        {
            Console.WriteLine($"Profesor en sala: {this.ProfesorAsignado.Nombre}");
            Console.WriteLine("Alumnos en sala:");

            foreach (Alumno alumno in this.AlumnosEnSala)
            {
                Console.WriteLine(alumno.Nombre);
            }
        }
    }
}
