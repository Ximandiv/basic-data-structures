using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public static class Colecciones
    {
        public static void Vectores()
        {
            /* Los arreglos son colecciones de datos de un mismo tipo
               con un contenido limitado, es decir, limite. */

            /* Los vectores son arreglos unidimensionales de manera que
               es linealmente secuencial. */

            int[] vector = new int[5];

            vector[0] = 1;
            int valor = vector[0];

            Console.WriteLine($"Valor - {valor}");

            //Los arreglos se pueden recorrer con un foreach o for loop.

            foreach (int i in vector)
            {
                Console.WriteLine($"Elemento Vector - {i}");
            }

            Console.WriteLine();
        }

        public static void Matrices()
        {
            /* Las matrices por otro lado, son arreglos bidimensionales
               por ende, se organiza en filas y columnas como una cuadricula. */

            int[,] matriz = new int[,]{
                {1, 2, 3},
                {4, 5, 6}
            };

            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    int elemento = matriz[i, j];
                    Console.WriteLine($"Fila {i} Columna {j} - {elemento}");
                }
            }

            Console.WriteLine();
        }

        public static void HashSet()
        {
            /* Los hashset son una coleccion que almacena solo elementos unicos,
               es decir, no permite duplicados y son unidimensional. */

            HashSet<int> numeros = new HashSet<int>();

            numeros.Add(1);
            Console.WriteLine($"El hashset tiene un 1? {(numeros.Contains(1) ? true : false)}");
            numeros.Add(2);
            Console.WriteLine($"El hashset tiene un 2? {(numeros.Contains(2) ? true : false)}");

            Console.WriteLine($"Puedo agregar otro 1? {numeros.Add(1)}");

            // No se permiten duplicados, esta operación no tiene efecto y lanza falso.

            Console.WriteLine();
        }

        public static void Listas()
        {
            /* Las listas son una coleccion de elementos similares a un arreglo
               pero difieren por que su limite es flexible de acuerdo a lo que se agregue
               o elimine. Se recorren igual que un arreglo y pueden ser bidimensionales al
               tener otra lista dentro del generic type < >*/

            List<int> numeros = new List<int>();

            numeros.Add(1);
            Console.WriteLine($"Largo de lista: {numeros.Count} - Valor index 0: {numeros[0]}");
            numeros.Add(2);
            Console.WriteLine($"Largo de lista: {numeros.Count} - Valor index 1: {numeros[1]}");
            numeros.Remove(1);
            Console.WriteLine($"Largo de lista: {numeros.Count} - Valor index 0: {numeros[0]}");

            Console.WriteLine();
        }

        public static void StacksYQueues()
        {
            /* Las pilas y filas son colecciones que siguen dos principios: LIFO y FIFO
               respectivamente.
            
               LIFO es un principio que consta de Last-In-First-Out; es decir,
               que el ultimo elemento es el que sale, y al agregar uno siempre es el ultimo.

               FIFO es un principio que consta de First-In-First-Out; es decir,
               que el primer elemento es el que sale, y al agregar uno siempre es el primero.
             */ 

            Stack<int> pila = new Stack<int>();

            pila.Push(1); // Agregar 1 a la pila
            Console.WriteLine($"La pila tiene un 1? {(pila.Contains(1) ? true : false)}");
            pila.Push(2); // Agregar 2 a la pila
            Console.WriteLine($"La pila tiene un 2? {(pila.Contains(1) ? true : false)}");

            int elementoStack = pila.Pop(); // Eliminar y obtener el elemento superior de la pila (2 en este caso)
            Console.WriteLine($"Se elimina y extrae el primer elemento de la pila: {elementoStack}");

            Console.WriteLine();

            Queue<string> cola = new Queue<string>();

            cola.Enqueue("A"); // Agregar "A" a la cola
            Console.WriteLine($"La fila tiene una 'A'? {(cola.Contains("A") ? true : false)}");
            cola.Enqueue("B"); // Agregar "B" a la cola
            Console.WriteLine($"La fila tiene una 'B'? {(cola.Contains("B") ? true : false)}");
            cola.Enqueue("C"); // Agregar "C" a la cola
            Console.WriteLine($"La fila tiene una 'C'? {(cola.Contains("C") ? true : false)}");

            string elementoQueue = cola.Dequeue(); // Eliminar y obtener el elemento frontal de la cola ("A" en este caso)
            Console.WriteLine($"Se elimina y obtiene el primer elemento de la fila: {elementoQueue}");

            Console.WriteLine();
        }
    }
}
