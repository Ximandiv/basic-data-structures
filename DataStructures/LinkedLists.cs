using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public static class LinkedLists
    {
        public static void Double()
        {
            /* Las listas enlazadas son un tipo de listas que en vez de
               funcionar por index, es orientado a nodos, es decir, crea
               un nodo que trae un puntero hacia el siguiente. Existen
               varios tipos: 
            
               Tipo unico donde solo hay un puntero hacia el
               siguiente nodo. 
            
               listaenlaza.Nodo1 = 1 | null

               -------

               listaenlaza.Nodo1 = 1 | Nodo2
               listaenlaza.Nodo2 = 2 | null

               -------

               listaenlaza.Nodo1 = Nodo3 | 1 | Nodo2
               listaenlaza.Nodo2 = Nodo1| 2 | Nodo3
               listaenlaza.Nodo3 = Nodo2 | 4 | Nodo1

               ------

               listaenlaza.Nodo1 = 1 | Nodo2
               listaenlaza.Nodo2 = 2 | Nodo3
               listaenlaza.Nodo3 = 3 | Nodo4
               listaenlaza.Nodo4 = 4 | Nodo1

               {5, 0} 5 es el valor. , => 0 es el valor
            
               Tipo doble donde hay dos punteros, uno antes
               del nodo y otro despues del mismo. 
            
               Tipo circular que los nodos se comportan como unicos,
               pero el puntero del ultimo nodo apunta al primero. 
            
               Tipo doble circular que los nodos se comportan como dobles,
               el puntero anterior del primer nodo apunta al ultimo y el ultimo
               nodo en su puntero siguiente apunta al primer nodo.
            */

            // A continuacion, lista enlazada de tipo doble.

            LinkedList<int> listaEnlazada = new LinkedList<int>();
            Console.WriteLine("Se declara lista enlazada");

            // Agregar elementos al principio y al final
            LinkedListNode<int> nodo1 = listaEnlazada.AddFirst(1);
            Console.WriteLine("Se declara e instancia un nodo de la lista" +
                              " con valor de 1 y se posiciona al inicio");

            LinkedListNode<int> nodo2 = listaEnlazada.AddLast(2);
            Console.WriteLine("Se declara e instancia un nodo de la lista" +
                              " con valor de 2 y se posiciona al final.");

            // Agregar un elemento después de otro
            LinkedListNode<int> nodo3 = listaEnlazada.AddAfter(nodo2, 4);
            Console.WriteLine("Se declara e instancia un nodo de la lista" +
                              " con valor de 4 y se posiciona despues del segundo nodo.");

            //Agregar un elemento antes de otro
            LinkedListNode<int> nodo4 = listaEnlazada.AddBefore(nodo3, 3);
            Console.WriteLine("Se declara e instancia un nodo de la lista" +
                              " con valor de 3 y se posiciona antes del tercer nodo.");

            Console.WriteLine();

            // Recorrer la lista enlazada
            Console.WriteLine("Recorrer Lista foreach");

            foreach (int valor in listaEnlazada)
            {
                Console.WriteLine($"Valor en nodo foreach: {valor}");
            }

            Console.WriteLine("Recorrer Lista for");

            for (LinkedListNode<int> nodo = listaEnlazada.First; nodo != null; nodo = nodo.Next)
            {
                int valor = nodo.Value;
                Console.WriteLine($"Valor en nodo for: {valor}");
            }
        }
    }
}
