//Declaração de variaveis
using System;
using System.Formats.Asn1;
double AreaRetangulo;
double perimetroretangulo;
double diagonalretangulo;

//Entrada de dados
Console.WriteLine("Digite a largura do retângulo:");
double largura = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura do retângulo:");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine($"Valores digitados foram: Largura = {largura}, Altura = {altura}");

//Processamento de dados
AreaRetangulo = largura * altura;
perimetroretangulo = 2 * (largura + altura);
diagonalretangulo = Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));

Console.WriteLine($"Área do retângulo: {AreaRetangulo:f2}");
Console.WriteLine($"Perímetro do retângulo: {perimetroretangulo:f2}");
Console.WriteLine($"Diagonal do retângulo: {diagonalretangulo:f2}");