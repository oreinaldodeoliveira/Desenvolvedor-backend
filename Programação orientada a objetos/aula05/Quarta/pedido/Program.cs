using pedido.Classes.entidades;
using pedido.Classes.Enumerações;
using System.Collections.Concurrent;

Funcionario dev = new Funcionario("Clodoaldo");
Funcionario gerente = new Funcionario("Elma");

Empresa SENAI = new Empresa("João Baptista Salles");
Empresa Suzano = new Empresa("Suzano Papel e Celulose");

Suzano.AdicionarFuncionario(gerente);
Suzano.AdicionarFuncionario(dev);

Console.WriteLine(Suzano);

Suzano.ListaDeFuncionarios.ForEach(funcionario =>
{
    Console.WriteLine($"Funcionario: {funcionario.Nome}");
});