namespace DataStructures;

public class Program
{
    static void Main(string[] args)
    {
        //Colecciones
        Console.WriteLine("Colecciones");
        Console.WriteLine();

        Console.WriteLine("Vectores");

        Colecciones.Vectores();

        Console.WriteLine("--------------");

        Console.WriteLine("Matrices");

        Colecciones.Matrices();

        Console.WriteLine("--------------");

        Console.WriteLine("Hashset");

        Colecciones.HashSet();

        Console.WriteLine("--------------");

        Console.WriteLine("Listas");

        Colecciones.Listas();

        Console.WriteLine("--------------");

        Console.WriteLine("Stacks y Queues");

        Colecciones.StacksYQueues();

        Console.WriteLine("--------------");

        //Diccionarios/Maps/Hashmaps
        Console.WriteLine("Diccionario o Hashmap");

        Diccionarios.CrearDiccionario();

        Console.WriteLine("--------------");

        //LinkedLists
        Console.WriteLine("Lista Enlazada o LinkedList");

        LinkedLists.Double();

        Console.ReadKey();
    }
}