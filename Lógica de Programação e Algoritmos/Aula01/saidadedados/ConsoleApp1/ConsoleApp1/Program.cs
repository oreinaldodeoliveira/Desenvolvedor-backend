//Declaração de variáveis
double largura;
double comprimento;
double area;;
double valor;
double preco;

//Entrada de dados
Console.Write("Digite a largura do terreno: ");
largura = int.Parse(Console.ReadLine());    
Console.Write("Digite o comprimento do terreno:");
comprimento = double.Parse(Console.ReadLine()); 
Console.Write("digite o valor do metro quadrado do terreno: ");
valor = double.Parse(Console.ReadLine());

//Processamento de dados 
area = largura * comprimento;
preco = area * valor;

//Saída de dados
Console.WriteLine($"Área do terreno: {area}\nPreço do terreno: R$ {preco:n}");
