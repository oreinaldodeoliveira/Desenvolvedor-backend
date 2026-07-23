using System;

namespace operadores
{
    class Program
    {
        static void Main()
        {
            int numero1;
            int numero2;
            int numero3;
            
            
  

            //entrada de dados
            Console.WriteLine("Digite o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número");
            numero3 = int.Parse(Console.ReadLine());

            //processamento de dados
            Console.WriteLine(" O primeiro valor é igual ao terceiro? " + (numero1 == numero3 ? "verdadeirp" : "falso"));
            Console.WriteLine(" O primeiro valor é diferente do segundo valor? " + (numero1 != numero2 ? "verdadeiro" :"falso"));
            Console.WriteLine(" O segundo valor é maior que o primeiro? " + (numero2 > numero1 ? "verdadeiro" : "falso"));
            Console.WriteLine(" O segundo valor é menor ou igual ao terceiro? " + (numero2 <= numero3 ? "verdadeiro" : "falso")); 

            //Saída de dados
            Console.WriteLine($"Se a primeira pergunta   {numero1 == numero3 & numero2 > numero1}");
            Console.WriteLine(numero1 != numero2 );
            Console.WriteLine(numero2 > numero1 );
            Console.WriteLine(numero2 <= numero3 );

            Console.WriteLine($"O 1º valor é igual ao 3º valor? R: {(pergunta1 ? "Verdadeiro" : "Falso")}");
            Console.WriteLine($"O 1º valor é diferente do 2º valor? R: {(pergunta2 ? "Verdadeiro" : "Falso")}");
            Console.WriteLine($"O 2º valor é maior que o 1º valor? R: {(pergunta3 ? "Verdadeiro" : "Falso")}");
            Console.WriteLine($"O 2º valor é menor ou igual ao 3º valor? R: {(pergunta4 ? "Verdadeiro" : "Falso")}");
            Console.WriteLine("--Lógicas--");
            Console.WriteLine($"Se a pergunta 1 e a pergunta 3 são verdadeiras. R: {(logical ? "Verdadeiro" : "Falso")}");
            Console.WriteLine($"Se a pergunta 2 e a pergunta 4, pelo menos uma é verdadeira. R: {(logica2 ? "Verdadeiro" : "Falso")}");
            Console.WriteLine($"Se a negação da primeira pergunta é verdadeira. R: {(logica3 ? "Verdadeiro" : "Falso")}");


















        }

    }
}
