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
        Console.WriteLine($"Nombre: {nombre}    |   nota 1: {nota1}|   nota 2: {nota2}" +
            $"|   nota 3: {nota3}   |   Promedio: {calcularPromedio():F2}   |  estado del estudiante: {ObtenerEstado()}");
        Console.WriteLine();
    }
}