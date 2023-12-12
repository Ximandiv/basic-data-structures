using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Ejemplos.Hash
{
    public class DiccionarioTerminos
    {
        public Dictionary<string, string> Hash { get; set; }
        public string NombreDiccionario { get; set; }

        public DiccionarioTerminos(string nombreDiccionario)
        {
            Hash = new Dictionary<string, string>();
            NombreDiccionario = nombreDiccionario;
        }

        public void AgregarTermino(string termino, string valor)
        {
            if (!this.ValidarTerminoExistente(termino))
            {
                Hash.Add(termino, valor);

                return;
            }

            Console.WriteLine("No se pueden agregar términos existentes.");
        }

        public void EliminarTermino(string termino)
        {
            if (this.ValidarTerminoExistente(termino))
            {
                Hash.Remove(termino);

                return;
            }

            Console.WriteLine("No se pueden eliminar términos inexistentes.");
        }

        public void MostrarDiccionario()
        {
            Console.WriteLine("----------------");

            Console.WriteLine($"Diccionario {this.NombreDiccionario}");

            Console.WriteLine();

            HashSet<string> conceptoUnico = new HashSet<string>();

            foreach(var termino in Hash)
            {
                if (conceptoUnico.Add(termino.Key))
                {
                    Console.WriteLine($"{termino.Key} = {termino.Value}");
                }
            }

            Console.WriteLine("----------------");
            Console.WriteLine();
        }

        private bool ValidarTerminoExistente(string termino)
        {
            if(Hash.ContainsKey(termino))
            {
                return true;
            }

            return false;
        }
    }
}
