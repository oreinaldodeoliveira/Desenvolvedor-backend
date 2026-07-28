// Declaração de variáveis
double a, b, c;
double area, perimetro;

try
{
    // Entrada de dados
    Console.Write("Digite o valor do lado A: ");
    a = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor do lado B: ");
    b = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor do lado C: ");
    c = double.Parse(Console.ReadLine());

    // Processamento de dados 
    if (a + b > c && a + c > b && b + c > a)
    {
        perimetro = Perimetro(a, b, c);
        Console.WriteLine($"Perímetro = {perimetro:F1}");
    }
    else
    {
        area = Area(a, b, c);
        Console.WriteLine($"Área = {area:F1}");
    }
}
catch
{
    Console.WriteLine("Valor inválido.");
}

// Função para calcular o perímetro
double Perimetro(double a, double b, double c)
{
    return a + b + c;
}

// Função para calcular a área do trapézio
double Area(double a, double b, double c)
{
    return ((a + b) * c) / 2.0;
}