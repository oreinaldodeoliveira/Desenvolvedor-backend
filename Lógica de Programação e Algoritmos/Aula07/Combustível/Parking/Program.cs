using System;




{
    //Declaração de variáveis
    string movimento;
    int turistas;
    int veiculos = 0;
    int totalTuristas = 0;

    while (true)
    {
        try
        {
            //Entrada de dados 

            Console.Write("Digite o movimento (entrando, voltando ou sair): ");
            movimento = Console.ReadLine();

            if (movimento == "sair")
            {
                break;
            }

            Console.Write("Quantidade de turistas: ");
            turistas = int.Parse(Console.ReadLine());

            if (turistas < 0 || turistas > 4)
            {
                Console.WriteLine("Quantidade de turistas inválida!");
                continue;
            }

            if (movimento == "entrando")
            {
                veiculos++;
                totalTuristas += turistas;
            }
            else if (movimento == "voltando")
            {
                veiculos--;
                totalTuristas -= turistas;
            }
            else
            {
                Console.WriteLine("Movimento inválido!");
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Erro: {erro.Message}");
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Turistas no parque: {totalTuristas}");
    Console.WriteLine($"Veículos no parque: {veiculos}");
}
