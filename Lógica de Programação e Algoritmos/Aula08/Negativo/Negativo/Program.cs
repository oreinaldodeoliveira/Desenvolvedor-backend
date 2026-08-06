//Declaração de variáveis
List<int> numeros = new List<int>();
int n, valor;

try
{
    //Entrada de dados
    Console.WriteLine("Quantos numeros você vai digitar? ");
    n = int.Parse(Console.ReadLine());

    //Loop Determinado
    for (int i = 0; i < n; i++)
    {
        Console.Write("Digite um numero: ");
        valor = int.Parse(Console.ReadLine());
        numeros.Add(valor);
    }

    Console.WriteLine("Numeros negativos: ");
    foreach (int item in numeros)
    {
        if (item < 0)
        {
            Console.WriteLine(item);
        }
    }
}


catch (Exception e)
{
    Console.WriteLine("Valor invalido, erro: " + e);
}
