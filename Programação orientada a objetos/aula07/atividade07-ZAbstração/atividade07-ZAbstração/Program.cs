using System;
using System.Collections.Generic;
using SistemaImposto.Entities;
using SistemaImposto.Enums;
using SistemaImposto.Services;

namespace SistemaImposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            List<Contribuinte> contribuintes = new List<Contribuinte>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"CONTRIBUINTE #{i}");

                Console.Write("Pessoa Física ou Jurídica? (F/J): ");
                string tipo = Console.ReadLine().ToUpper();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());

                if (tipo == "F")
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine());

                    contribuintes.Add(
                        new PessoaFisica(
                            nome,
                            rendaAnual,
                            gastosSaude
                        )
                    );
                }
                else if (tipo == "J")
                {
                    Console.Write("Número de funcionários: ");
                    int numeroFuncionarios = int.Parse(Console.ReadLine());

                    contribuintes.Add(
                        new PessoaJuridica(
                            nome,
                            rendaAnual,
                            numeroFuncionarios
                        )
                    );
                }
                else
                {
                    Console.WriteLine("Tipo inválido!");
                    i--;
                }
            }

            ImpostoService impostoService = new ImpostoService();

            double totalImposto = 0.0;

            Console.WriteLine();
            Console.WriteLine("IMPOSTOS PAGOS:");

            foreach (Contribuinte contribuinte in contribuintes)
            {
                double imposto = impostoService.CalcularImposto(contribuinte);

                Console.WriteLine(
                    $"{contribuinte.Nome}: R$ {imposto:F2}"
                );

                totalImposto += imposto;
            }

            Console.WriteLine();
            Console.WriteLine(
                $"TOTAL DE IMPOSTO ARRECADADO: R$ {totalImposto:F2}"
            );

            Console.ReadLine();
        }
    }
}