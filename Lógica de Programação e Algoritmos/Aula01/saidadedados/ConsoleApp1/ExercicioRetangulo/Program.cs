//Criação das variáveis
double bAse;
double altura;
double area;
double perimetro;
double diagonal;

//Entrada de dados
Console.Write("Digite a bAse do retangulo: ");
bAse = double.Parse(Console.ReadLine());
Console.Write("Digite a altura do retangulo: ");
altura = double.Parse(Console.ReadLine());

//Processamento de dados
area = bAse * altura;
perimetro = bAse + altura + bAse + altura;
diagonal = Math.Sqrt(Math.Pow(bAse, 2 ) +Math.Pow(altura, 22));

//Saída de dados
Console.WriteLine($"--Dados do retângulo--\n" +
$"Área: {area:f2}\n" +
$"Perímetro: {perimetro:f2}\n" +
$"Diagonal: {diagonal:n}\n");


