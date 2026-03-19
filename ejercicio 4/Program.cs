List<Libro> libros = new List<Libro>();

Console.Write("Cuantos Libros desea ingresar: ");
int n= int.Parse(Console.ReadLine());
Console.Clear();

for (int i=0; i<n; i++) 
{
    Libro l = new Libro();
    Console.WriteLine($"ingrese datos del libro {i+1}: ");
    Console.WriteLine();
    Console.Write("titulo: "); l.titulo = Console.ReadLine();
    Console.Write("autor: "); l.autor = Console.ReadLine();
    Console.Write("Categoria: "); l.categoria = Console.ReadLine();
    Console.Write("numero de paginas: "); l.NumPaginas=int.Parse(Console.ReadLine());
    libros.Add(l);
    Console.Clear();
}

Libro mayor = libros[0];

foreach(Libro l in libros)
{
    if (l.NumPaginas > mayor.NumPaginas) mayor = l;

    l.MostrarInfo();
}
Console.WriteLine();
Console.WriteLine("el libro con mas paginas es: ");
mayor.MostrarInfo();

class Libro
{
    public string titulo;
    public string autor;
    public string categoria;
    public int NumPaginas;

    public string ClasificacionLibro()
    {
        if (NumPaginas > 500) return "extenso";
        else if (NumPaginas > 100 && NumPaginas < 499) return "mediano";
        else return "corto";
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Titulo: {titulo}  |  Autor: {autor}  |  " +
            $"Categoria: {categoria}  |  Numero de paginas: {NumPaginas}  |  "+
            $"Clasificacion del libro: {ClasificacionLibro()}");
        Console.WriteLine();
    }
}