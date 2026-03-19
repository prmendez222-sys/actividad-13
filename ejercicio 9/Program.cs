List<Curso> cursos = new List<Curso>();

Console.Write("Ingrese la cantidad de cursos: ");
int n = int.Parse(Console.ReadLine());

Console.Clear();

for (int i = 0; i < n; i++)
{
    Curso c = new Curso();

    Console.WriteLine("Curso #" + (i + 1));

    Console.Write("Nombre del curso: ");
    c.Nombre = Console.ReadLine();

    Console.Write("Créditos: ");
    c.Creditos = int.Parse(Console.ReadLine());

    Console.Write("Nota promedio: ");
    c.NotaPromedio = double.Parse(Console.ReadLine());

    cursos.Add(c);

    Console.Clear();
}

Console.WriteLine("registro de cursos: ");
Console.WriteLine();
Curso mejor = cursos[0];
foreach (Curso c in cursos)
{
    if (c.NotaPromedio > mejor.NotaPromedio)
    {
        mejor = c;
    }
    c.Mostrar();
}
Console.WriteLine();
Console.WriteLine("Mejor curso: ");
mejor.Mostrar();
class Curso
{
    public string Nombre;
    public int Creditos;
    public double NotaPromedio;

    public string Rendimiento()
    {
        if (NotaPromedio >= 85)
            return "Excelente";
        else if (NotaPromedio >= 70)
            return "Aceptable";
        else
            return "Bajo";
    }

    public void Mostrar()
    {
        Console.WriteLine($"Curso: {Nombre} | Créditos: {Creditos} | Promedio: {NotaPromedio} | Rendimiento: {Rendimiento()}");
        Console.WriteLine();
    }
}