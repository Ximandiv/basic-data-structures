using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DataStructures
{
    public static class Diccionarios
    {
        public static void CrearDiccionario()
        {
            /* Los diccionarios son estructuras de datos que asocian clave unica
               con valores. I.E "NumeroUno" = 1, donde "NumeroUno" es la llave y 1 su valor. */

            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            diccionario.Add("uno", 1);
            // Acceso a elementos en el diccionario.

            int valor = diccionario["uno"]; // 1
            Console.WriteLine($"Valor con llave 'uno': {valor}");

            //Acceso a las llaves que tiene el diccionario.
            foreach (var d in diccionario.Keys)
            {
                Console.WriteLine($"Llave: {d}");
            }
            Console.WriteLine($"En llave uno hay un valor de: {diccionario["uno"]}");

            // ----

            diccionario.Add("dos", 2);
            foreach (var d in diccionario.Keys)
            {
                Console.WriteLine($"Llave: {d}");
            }
            Console.WriteLine($"Valor con llave 'dos': {diccionario["dos"]}");

            Console.WriteLine();
        }
    }
}
