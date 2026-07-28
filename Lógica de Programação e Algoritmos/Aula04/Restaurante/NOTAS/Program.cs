//Declaração de variaveis
    double nota1, nota2, notafinal;
try
{
    //entrada de dados
    Console.Write("Digite a 1° nota:");
    nota1 = double.Parse(Console.ReadLine());
    Console.Write("Digite a 2° nota: ");
    nota2 = double.Parse(Console.ReadLine());

    //Processamento de daodos
    Nota();
    //Saida de dados
    Console.WriteLine($"Nota final = {notafinal:f1}");
    if (notafinal < 60)
    {
        Console.WriteLine("Reprovado");

    }
    else if (notafinal == 80)
    {
        Console.WriteLine("parabens pela nota");
    }

    {
        Console.WriteLine("Aprovado");
    }
}

catch
{
    Console.WriteLine("Digite valores válidos");
}

double Nota()
{
    notafinal = nota2 + nota2;
    return notafinal;
}