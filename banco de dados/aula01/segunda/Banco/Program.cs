using Microsoft.EntityFrameworkCore;
using Banco.Classes.Contextos;

ContaContextos contextos = new ContaContext();

contextos.Database.EnsureCreated();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("--Menu principal--"
        "\n 1. Cadastrar conta"
        "\n 2. Listar contas"
        "\n 3. Sair");
}