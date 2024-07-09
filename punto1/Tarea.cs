// See https://aka.ms/new-console-template for more information

namespace Tareas
{
    public class Tarea
    {
        int id;
        string descripcion;
        int duracion;

        public Tarea()
        {
        }

        public Tarea(int id, string descripcion, int duracion)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.duracion = duracion;
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public static void MostrarListaTareas(List<Tarea> tareas)
        {
            
            int i= 1;
            foreach (Tarea tarea in tareas)
            {
                Console.WriteLine($"---Tarea numero {i}---");
                Console.WriteLine($"Id: {tarea.Id}");
                Console.WriteLine($"Descripcion: {tarea.Descripcion}");
                Console.WriteLine($"Duracion: {tarea.Duracion}");
                i++;
            }
        }


    }


}