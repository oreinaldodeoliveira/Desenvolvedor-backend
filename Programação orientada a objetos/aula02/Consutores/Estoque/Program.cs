using Estoque;

//Declaração de variáveis
string nome;
int quantidade;
double preco;

//Entrada de dados
Console.Write("Digite o nome do produto: ");
nome = Console.ReadLine();
Console.Write("Digite a quantidade do produto: ");
quantidade = int.Parse(Console.ReadLine());
Console.Write("Digite o preço do produto: ");
preco = double.Parse(Console.ReadLine());

Produto objeto = new Produto(nome, quantidade, preco);

Console.WriteLine();
Console.ReadKey();