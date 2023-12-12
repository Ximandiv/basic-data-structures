using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Ejemplos.Linked_Lists
{
    public class ListaDeReproduccion
    {
        public LinkedList<Tema> ListaReproduccion { get; set; }
        public LinkedListNode<Tema> PrimerNodo { get; set; }

        public ListaDeReproduccion(Tema tema)
        {
            ListaReproduccion = new LinkedList<Tema>();
            PrimerNodo = ListaReproduccion.AddFirst(tema);
        }

        public void AgregarTema(Tema tema) => this.ListaReproduccion
                                                    .AddLast(tema);

        public void EliminarTema(Tema tema)
        {
            if (this.ValidarExistencia(tema))
            {
                this.ListaReproduccion
                        .Remove(tema);

                return;
            }

            Console.WriteLine("Acción invalida. Tema inexistente.");
        }

        public void AgregarAntes(Tema temaDespues, Tema temaAgregar) => this.ListaReproduccion
                                                                                .AddBefore
                                                                                (this.
                                                                                Buscar(temaDespues),
                                                                                temaAgregar);

        public void AgregarDespues(Tema temaAntes, Tema temaAgregar) => this.ListaReproduccion
                                                                                .AddAfter
                                                                                (this
                                                                                .Buscar(temaAntes),
                                                                                temaAgregar);

        public void EnlistarTemas()
        {
            foreach(Tema tema in this.ListaReproduccion)
            {
                Console.WriteLine("----------------------------");

                string temaAEnlistar = $"Nombre de Tema: {tema.Nombre}" +
                                   $"\nAutor: {tema.Autor}" +
                                   $"\nDescripcion: {tema.Descripcion}" +
                                   $"\nUrl: {tema.Url}";

                Console.WriteLine(temaAEnlistar);

                Console.WriteLine("----------------------------");
            }
        }

        private LinkedListNode<Tema> Buscar(Tema tema)
        {
            for (LinkedListNode<Tema> nodo = this.ListaReproduccion.First; nodo != null; nodo = nodo.Next)
            {
                string url = nodo.Value.Url;

                if (tema.Url.Equals(url))
                {
                    return nodo;
                }
            }

            return null;
        }

        public bool ValidarExistencia(Tema temaValidar)
        {
            HashSet<Tema> temasUnicos = new HashSet<Tema>();

            foreach(Tema tema in this.ListaReproduccion)
            {
                temasUnicos.Add(tema);
            }

            foreach(Tema temaHash in temasUnicos)
            {
                if (temaHash.Url == temaValidar.Url)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
