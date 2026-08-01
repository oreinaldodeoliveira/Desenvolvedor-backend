
Console.Title = "Montanha-Russa";

int numeroVisitantes;
double alturaMinima, alturaMaxima, alturaVisitante;
int pessoasPermitidas = 0;
bool valido = true;

try
{
    // Entrada de dados
    Console.Write("Digite o número de visitantes: ");
    Console.ForegroundColor = ConsoleColor.Red;
    numeroVisitantes = int.Parse(Console.ReadLine());
    Console.ResetColor();
    while (valido)
    {
        try
        {
            Console.Write("Digite a altura mínima permitida (em cm): ");
            Console.ForegroundColor = ConsoleColor.Red;
            alturaMinima = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Write("Digite a altura máxima permitida (em cm): ");
            Console.ForegroundColor = ConsoleColor.Red;
            alturaMaxima = int.Parse(Console.ReadLine());
            Console.ResetColor();

            // Leitura das alturas
            for (int i = 1; i <= numeroVisitantes; i++)
            {

                Console.Write($"Digite a altura do visitante {i}: ");
                alturaVisitante = double.Parse(Console.ReadLine());

                if (alturaVisitante >= alturaMinima | alturaVisitante <= alturaMaxima)
                {
                    pessoasPermitidas++;
                }
            }

            // Saída
            Console.WriteLine();
            Console.WriteLine($"Quantidade de pessoas que podem andar na montanha-russa: {pessoasPermitidas}");
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
            valido = false;
        }
        catch
        {
            Console.WriteLine("Valor invalido. Digite um número inteiro!");
        }
    }
}
catch
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Valor invalido, tente novamente!");
    Console.ResetColor();
}


