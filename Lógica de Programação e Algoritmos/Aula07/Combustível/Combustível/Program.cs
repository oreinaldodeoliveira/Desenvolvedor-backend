//Declaração de variáveis
int codigo, alcool, gasolina, diesel;

codigo = 0;
alcool = 0;
gasolina = 0;
diesel = 0;
while (true)
    try
    {
        while (codigo != 4)
        {
            Console.WriteLine("informe um codigo (1, 2, 3) ou 4 para parar: ");
            codigo = int.Parse(Console.ReadLine());
            if (codigo == 1)
            {
                alcool++;
            }
            else if (codigo == 2)
            {
                gasolina++;
            }
            else if (codigo == 3)
            {
                diesel++;
            }
        }
        Console.WriteLine("muitoobrigado\n" + $"alcool: {alcool}\n" + $"{gasolina}\n" + $"{diesel}");
        break;
    }
    catch (Exception erro)
    {

        Console.WriteLine($"valor invalido, erro: {erro}");
    }