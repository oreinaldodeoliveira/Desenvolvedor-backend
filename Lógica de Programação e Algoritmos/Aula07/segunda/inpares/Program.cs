using static System.Linq.Enumerable;
using static System.Console;
using System.Runtime;

//Declaração de variáveis
int x, y, resultado;

try
{
	//Entrada de dados
	Write("Digite dois número: ");
	x = int.Parse(ReadLine());
	y = int.Parse(ReadLine());

	
	if (x < y)

	{
        Controle = x;
        Control = y;
    }
	else
	{
		Controle = y;
		Control = x;
    }
	foreach (int in Range(Controle, control))
	{
		if (args % 0 != 0 & args != Controle & a != y)
		{
			impar += a;
			if (a == control)
			{
				break
			}
		}
	}
	WriteLine($"A soma dos números ímpares: {impar}");
}
catch (Exception erro)
{

	throw;
}