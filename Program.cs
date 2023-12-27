
using System.Collections.Generic;

namespace GestorTareasCSharp
{
    class Program
    {
        static List<string> tareas = new List<string>();

        static void Main(string[] args)
        {
            MostrarMenu();
        }

        static void MostrarMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Gestor de Tareas ---");
                Console.WriteLine("1. Agregar Tarea");
                Console.WriteLine("2. Listar Tareas");
                Console.WriteLine("3. Marcar Tarea como Completada");
                Console.WriteLine("4. Salir");

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarTarea();
                        break;
                    case "2":
                        ListarTareas();
                        break;
                    case "3":
                        MarcarComoCompletada();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void AgregarTarea()
        {
            Console.Write("Ingrese la nueva tarea: ");
            string nuevaTarea = Console.ReadLine();
            tareas.Add(nuevaTarea);
            Console.WriteLine("Tarea agregada exitosamente.");
        }

        static void ListarTareas()
        {
            Console.WriteLine("\n--- Lista de Tareas ---");
            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }

        static void MarcarComoCompletada()
        {
            ListarTareas();
            Console.Write("\nIngrese el número de la tarea completada: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 1 && indice <= tareas.Count)
            {
                tareas.RemoveAt(indice - 1);
                Console.WriteLine("Tarea marcada como completada.");
            }
            else
            {
                Console.WriteLine("Número de tarea no válido. Intente de nuevo.");
            }
        }
    }
}
