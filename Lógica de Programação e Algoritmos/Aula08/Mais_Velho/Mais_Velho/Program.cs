Dictionar<y<string, int> pessoas = new Dictionary<string , int>();
int idade, n;

try
{
    //Entrada de dados
    Console.WriteLine("Quantas pessoas você vai digitar: ");
    n = int.Parse(Console.ReadLine());

    for(int i = 0; i < n; i++)
    {
        Console.WriteLine($"Dados da {i+1}° pessoa: ");
        
        Console.WriteLine("");
        
    }
}
catch (Exception e)
{
    Console.WriteLine("Valor invalido, erro: " + e);
	throw;
}
