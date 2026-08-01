//Declaração de variáveis
int x, y;

do
{
    Console.WriteLine("Digite dois números inteiros: ");
    x = int.Parse(Console.ReadLine());
    y = int.Parse(Console.ReadLine());
    if (x == y)
    {
        Console.WriteLine("Números iguais, digite novamente!");
    }
    else if (x < y)
    {
        Console.WriteLine("Crescente!");
    }
    else
    {
        Console.WriteLine("Decrescente!");
    } 

} while (x != y);