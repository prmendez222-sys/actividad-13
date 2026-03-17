void Presionar()
{
    Console.WriteLine();
    Console.WriteLine("Presione Enter Para continuar");
    Console.ReadLine();
}

List<Estrudiante> estudiantes = new List<Estrudiante>();
string opcion;
do
{
    Console.WriteLine("1. ingresar estudiantes");
    Console.WriteLine("2. mostrar estudiantes registrados");
    Console.WriteLine("3. mostrar al mejor estudiante");
    Console.WriteLine("4. salir");
    Console.WriteLine();
    Console.Write("ingrese una opcion: ");
    opcion= Console.ReadLine();
    Console.Clear();

    switch (opcion)
    {
        case "1":
            Console.Write("Cuantos estudiantes desea ingresar: ");
            int n=int.Parse(Console.ReadLine());

            Console.Clear();

            for(int i=0; i<n; i++)
            {
                Estrudiante e = new Estrudiante();
                Console.WriteLine($"ingrese datos del estudiante {i+1}: ");
                Console.WriteLine();
                Console.Write("Nombre: "); e.nombre = Console.ReadLine();
                Console.Write("nota1: "); e.nota1 = double.Parse(Console.ReadLine());
                Console.Write("nota2: "); e.nota2 = double.Parse(Console.ReadLine());
                Console.Write("nota3: "); e.nota3 = double.Parse(Console.ReadLine());
                estudiantes.Add(e);
                Console.Clear();
            }

            Console.WriteLine("Estudiantes Guardados con exito");
            Presionar();
            break;
        case "2":
            if(estudiantes.Count == 0)
            {
                Console.WriteLine("no hay estudiantes registrados");
            }
            else
            {
                foreach (Estrudiante e in estudiantes)
                {
                    e.MostrarInfo();
                }
            }
            Presionar();
            break;
        case "3":
            if (estudiantes.Count == 0)
            {
                Console.WriteLine("no hay estudiantes registrado");
            }
            else
            {
                Console.WriteLine("El mejor estudiante es: ");
                Console.WriteLine();
                Estrudiante mejor = estudiantes[0];

                foreach (Estrudiante e in estudiantes)
                {
                    if (e.calcularPromedio() > mejor.calcularPromedio())
                    {
                        mejor = e;
                    }
                }
                mejor.MostrarInfo();

            }
            Presionar();
            break;
        case "4":
            break;
        default:
            Console.WriteLine("opcion no valida");
            Presionar();
            break;

    }

    Console.Clear();
} while (opcion != "4");

class Estrudiante
{
    public string nombre;
    public double nota1;
    public double nota2;
    public double nota3;

    public double calcularPromedio()
    {
        return (nota1 + nota2 + nota3) / 3;
    }

    public string ObtenerEstado()
    {
        if (calcularPromedio() >= 60) return "aprobado";
        else return "reprobado";
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {nombre}    |   nota 1: {nota1}  |   nota 2: {nota2}  " +
            $"|   nota 3: {nota3}   |   Promedio: {calcularPromedio():F2}   |  estado del estudiante: {ObtenerEstado()}");
        Console.WriteLine();
    }
}