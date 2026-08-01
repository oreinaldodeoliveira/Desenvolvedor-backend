//Entrada de dados 
Console.Write("Deeja a tabuada para qual valor ? ");
int n = int.Parse(Console.ReadLine());

//Estrutura do FOR  
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{n} X {i+1} = {n * (i+1)}");
}