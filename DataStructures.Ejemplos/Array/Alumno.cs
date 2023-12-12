using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Ejemplos.Array
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public double[] Notas { get; set; }
        public double? NotaPromedio { get; set; }
        public Profesor ProfesorAsignado { get; set; }

        public Alumno(string nombre, double[] notas, Profesor profeAsignado)
        {
            Nombre = nombre;
            Notas = notas;
            ProfesorAsignado = profeAsignado;
        }

        // Cada estudiante puede decir sus notas y si tiene nota promedio sacada
        // por el profesor, se va a ver reflejada, sino, no.
        public void MostrarNotas()
        {
            Console.WriteLine($"Soy {this.Nombre} y mis notas son:");

            if(this.NotaPromedio == null)
            {
                foreach (double nota in this.Notas)
                {
                    Console.WriteLine(nota);
                }
                return;
            }

            foreach (double nota in this.Notas)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine($"Tengo una nota promedio de: {this.NotaPromedio}");
        }
    }
}
