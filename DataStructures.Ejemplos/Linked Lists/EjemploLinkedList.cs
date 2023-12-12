using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Ejemplos.Linked_Lists
{
    public static class EjemploLinkedList
    {
        public static void SimularEscenario()
        {
            Tema fnaf = new Tema("Five Nights at Freddy's", "The Living Tombstone",
                                 "Tema Gold famoso del videojuego fnaf", "youtube.com/fnaf");
            Tema fnafTwo = new Tema("It's Been So Long", "The Living Tombstone",
                                   "Tema famoso de la secuela del videojuego fnaf", "youtube.com/fnafTwo");
            Tema fnafThree = new Tema("Die In A Fire", "The Living Tombstone",
                                   "Tema famoso del tercer juego fnaf", "youtube.com/fnafThree");
            Tema fnafFour = new Tema("I Got No Time", "The Living Tombstone",
                                   "Tema famoso del cuarto juego fnaf", "youtube.com/fnafFour");

            ListaDeReproduccion listaReproduccion = new ListaDeReproduccion(fnaf);
            Console.WriteLine("Se crea lista de reproducción con un tema inicial.");
            Console.WriteLine();

            //Presenta los temas actuales
            EjemploLinkedList.PresentarTemas(listaReproduccion);

            Console.WriteLine("Se agrega nuevo tema a la lista al final.");
            listaReproduccion.AgregarTema(fnafTwo);
            Console.WriteLine();

            EjemploLinkedList.PresentarTemas(listaReproduccion);

            Console.WriteLine($"Se agrega nuevo tema a la lista después de {fnafTwo.Nombre}");
            listaReproduccion.AgregarDespues(fnafTwo, fnafFour);
            Console.WriteLine();

            EjemploLinkedList.PresentarTemas(listaReproduccion);

            Console.WriteLine($"Se agrega nuevo tema a la lista antes de {fnafFour.Nombre}");
            listaReproduccion.AgregarAntes(fnafFour, fnafThree);
            Console.WriteLine();

            EjemploLinkedList.PresentarTemas(listaReproduccion);

            Console.WriteLine($"Se elimina tema {fnaf.Nombre} de la lista, finalizó tema");
            listaReproduccion.EliminarTema(fnaf);
            Console.WriteLine();

            EjemploLinkedList.PresentarTemas(listaReproduccion);

            Console.WriteLine("Se trata de eliminar tema inexistente");
            listaReproduccion.EliminarTema(fnaf);
            Console.WriteLine();
        }

        public static void PresentarTemas(ListaDeReproduccion lista)
        {
            Console.WriteLine("A continuación.");
            lista.EnlistarTemas();
            Console.WriteLine();
        }
    }
}
