// See https://aka.ms/new-console-template for more information
using Tareas;

Console.WriteLine("Hello, World!");


List<Tarea> pendientes = new List<Tarea>();

Console.WriteLine("---Agregar tareas a realizar---");

var ramdon = new Random();

int i = 1000;


while (true)
{
    Console.Write($"Ingrese descripcion de tarea {i - 999}: ");
    string descripcion = Console.ReadLine();
    var tarea = new Tarea(i + 1, descripcion, ramdon.Next(10, 101));
    pendientes.Add(tarea);

    Console.WriteLine("Desea seguir agregando tareas? 1.si 2.no: ");
    Console.Write("Respuesta: ");
    if (int.TryParse(Console.ReadLine(), out int opcion))
    {
        if (opcion == 2)
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("ERROR");
        break;
    }
    i++;
}
Console.WriteLine("\n\n---TAREAS PENDIENTES---");
Tarea.MostrarListaTareas(pendientes);

List<Tarea> realizadas = new List<Tarea>();

while (true)
{
    Console.Write("Ingrese el id de la tarea realizada: ");
    if (int.TryParse(Console.ReadLine(), out int id))
    {
        Tarea[] indices = new Tarea[10];
        int a = 0;
        foreach (Tarea tarea in pendientes)
        {
            if (tarea.Id == id)
            {
                realizadas.Add(tarea);
                indices[a] = tarea;
                a++;
            }


        }

        for (int j = 0; j < indices.Length; j++)
        {
            pendientes.Remove(indices[j]);
        }
    }
    Console.Write("seguir? 1.si 2.no: ");
    if (int.TryParse(Console.ReadLine(), out int opcion))
    {
        if (opcion == 2)
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("ERROR");
        break;
    }
}

Console.WriteLine("\n\n---TAREAS REALIZADAS---");
Tarea.MostrarListaTareas(realizadas);
Console.WriteLine("\n\n---TAREAS PENDIENTES---");
Tarea.MostrarListaTareas(pendientes);




Console.WriteLine("---BUSCAR UNA TAREA PENDIENTE (descripcion)---");
Console.Write("Ingrese la descripcion de la tarea: ");
string descrip = Console.ReadLine();

foreach (Tarea tarea in pendientes)
{
    if (tarea.Descripcion == descrip)
    {
        Console.WriteLine("--La tarea si se encontro--");
        Console.WriteLine($"Id: {tarea.Id}");
        Console.WriteLine($"Descripcion: {tarea.Descripcion}");
        Console.WriteLine($"Duracion: {tarea.Duracion}");
        break;
    }
}



