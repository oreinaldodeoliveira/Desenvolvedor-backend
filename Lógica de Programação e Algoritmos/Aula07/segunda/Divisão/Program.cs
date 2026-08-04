//Declaração de variáveis
using System.Linq.Expressions;

int n, x, y;
double

try
{
    //Entrada de dados
    Console.WriteLine("Quantos casos você vai digitar? ");
    n = int.Parse(Console.ReadLine());
    for (int i = 0; i< n; i++)
    {
        Console.WriteLine("Entre com numerador: ");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Entre com denominador: ");
        y = double.Parse(Console.ReadLine());
        if (y != 0)

        {
            Console.WriteLine($"Divisão ={(x / y):f2}");
        }
        else
        {
            Console.WriteLine("Divisão impossível");
        }
    catch (Exception erro)
    {
        Console.WriteLine($"Erro: {erro.Message}");
    }

}