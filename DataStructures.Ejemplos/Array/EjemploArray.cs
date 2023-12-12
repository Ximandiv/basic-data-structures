using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Ejemplos.Array
{
    public static class EjemploArray
    {
        // Se simula escenario con un caso hipotetico.
        public static void SimularEscenario()
        {
            Profesor profeMates = new Profesor("Julián", "Matemáticas", 5);

            // Generador automático de número aleatorio entre 0.0 y 5.0.
            double[] notasAlumnoUno = RandomNum.Generate(profeMates.CtdNotasPeriodo);

            Alumno alumnoUno = new Alumno("Isabela", notasAlumnoUno, profeMates);


            double[] notasAlumnoDos = RandomNum.Generate(profeMates.CtdNotasPeriodo);
            Alumno alumnoDos = new Alumno("Daniel", notasAlumnoDos, profeMates);


            Alumno[] alumnosEnSalaHoy = { alumnoUno, alumnoDos };

            Sala1A salaMatematicas = new Sala1A(profeMates, alumnosEnSalaHoy);

            //Asigna alumnos a la sala, al profesor y viceversa.
            salaMatematicas.AsignarAlumnos(alumnosEnSalaHoy, profeMates);
            salaMatematicas.AsignarProfe(profeMates);

            salaMatematicas.MostrarQuienHay();

            Console.WriteLine();
            Console.WriteLine("Profesor pregunta nombres y notas.");

            Console.WriteLine();
            alumnoUno.MostrarNotas();
            Console.WriteLine();
            alumnoDos.MostrarNotas();

            Console.WriteLine();
            Console.WriteLine("Profesor va a calcular promedio de notas.");

            Console.WriteLine();
            profeMates.SacarPromedioDeNotas(salaMatematicas.AlumnosEnSala);
            Console.WriteLine("Profesor pide que validen notas finales.");

            Console.WriteLine();
            alumnoUno.MostrarNotas();
            Console.WriteLine();
            alumnoDos.MostrarNotas();
        }
    }
}
