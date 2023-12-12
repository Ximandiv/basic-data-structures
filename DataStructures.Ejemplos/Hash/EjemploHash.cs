using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Ejemplos.Hash
{
    public static class EjemploHash
    {
        public static void SimularEscenario()
        {
            DiccionarioTerminos diccionario = new DiccionarioTerminos("Expresiones");

            Console.WriteLine("Se agrega nuevo término a diccionario");
            Console.WriteLine();
            diccionario.AgregarTermino("Saludar", "Dirigir a alguien palabras, gestos o cualquier otro acto");
            diccionario.MostrarDiccionario();

            Console.WriteLine("Se agrega otro nuevo término a diccionario");
            Console.WriteLine();
            diccionario.AgregarTermino("Despedir", "Decir adiós o dirigir una palabra, expresión o gesto de cortesía");
            diccionario.MostrarDiccionario();

            Console.WriteLine("Se elimina término del diccionario");
            Console.WriteLine();
            diccionario.EliminarTermino("Despedir");
            diccionario.MostrarDiccionario();
        }
    }
}
