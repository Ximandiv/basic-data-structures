using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Ejemplos.Linked_Lists
{
    public class Tema
    {
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Descripcion { get; set; }
        public string Url { get; set; }
        public Tema(string name, string autor, string description, string url)
        {
            Nombre = name;
            Autor = autor;
            Descripcion = description;
            Url = url;
        }
    }
}
