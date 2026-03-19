Dictionary<string, Estudiante> estudiantes = new Dictionary<string, Estudiante>();

Console.Write("Ingrese la cantidad de estudiantes: ");
int n = int.Parse(Console.ReadLine());

Console.Clear();

for (int i = 0; i < n; i++)
{
    Estudiante e = new Estudiante();

    Console.WriteLine("Estudiante #" + (i + 1));

    Console.Write("Carnet: "); string carnet = Console.ReadLine();

    Console.Write("Nombre: "); e.Nombre = Console.ReadLine();

    Console.Write("Carrera: "); e.Carrera = Console.ReadLine();

    Console.Write("Nota Final: "); e.NotaFinal = double.Parse(Console.ReadLine());
    estudiantes.Add(carnet, e);
    Console.Clear();
}

Console.WriteLine("lista de estudiantes: ");

foreach (var item in estudiantes)
{
    Console.WriteLine("Carnet: " + item.Key);
    item.Value.Mostrar();
}

Console.Write("Ingrese carnet a buscar: ");
string buscar = Console.ReadLine();

if (estudiantes.ContainsKey(buscar))
{
    Console.WriteLine("\nEstudiante encontrado:");
    estudiantes[buscar].Mostrar();
}
else
{
    Console.WriteLine("No se encontró el estudiante.");
}
class Estudiante
{
    public string Nombre;
    public string Carrera;
    public double NotaFinal;

    public string Estado()
    {
        if (NotaFinal >= 61)
            return "Aprobado";
        else
            return "Reprobado";
    }

    public void Mostrar()
    {
        Console.WriteLine($"Nombre: {Nombre}  |  Carrera: {Carrera} |  " +
            $"Nota Final: {NotaFinal}  |  Estado: {Estado()}");
        Console.WriteLine();
    }
}