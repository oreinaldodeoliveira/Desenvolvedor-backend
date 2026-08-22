using System;
using ContaPoupanca;
using ContaParaEmpresa;

namespace ContaPoupaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== BANCO =====");
            Console.WriteLine("1 - Conta Poupança");
            Console.WriteLine("2 - Conta Para Empresa");
            Console.Write("Escolha o tipo de conta: ");

            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular: ");
            string titular = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Digite a taxa de juros: ");
                double taxa = double.Parse(Console.ReadLine());

                ContaPoupanca conta = new ContaPoupanca ( numero,titular,saldo);

                Console.WriteLine();
                Console.WriteLine("=== CONTA POUPANÇA ===");
                Console.WriteLine("Titular: " + conta.Titular);
                Console.WriteLine("Número: " + conta.Numero);
                Console.WriteLine("Saldo: R$ " + conta.Saldo.ToString("F2"));

                Console.WriteLine();
                Console.Write("Digite o valor do depósito: ");
                double deposito = double.Parse(Console.ReadLine());

                conta.Deposito(deposito);

                Console.WriteLine("Saldo após depósito: R$ " +
                    conta.Saldo.ToString("F2"));

                Console.WriteLine();
                Console.Write("Digite o valor do saque: ");
                double saque = double.Parse(Console.ReadLine());

                conta.Saque(saque);

                Console.WriteLine("Saldo após saque: R$ " +
                    conta.Saldo.ToString("F2"));

                Console.WriteLine();
                Console.WriteLine("A poupança não possui taxa de saque.");
            }
            else if (opcao == 2)
            {
                Console.Write("Digite o limite de empréstimo: ");
                double limite = double.Parse(Console.ReadLine());

                ContaParaEmpresa conta = new ContaParaEmpresa(
                    numero,
                    titular,
                    saldo
                );

                conta.LimiteDeEmprestimo = limite;

                Console.WriteLine();
                Console.WriteLine("=== CONTA PARA EMPRESA ===");
                Console.WriteLine("Titular: " + conta.Titular);
                Console.WriteLine("Número: " + conta.Numero);
                Console.WriteLine("Saldo: R$ " + conta.Saldo.ToString("F2"));

                Console.WriteLine();
                Console.Write("Digite o valor do depósito: ");
                double deposito = double.Parse(Console.ReadLine());

                conta.Deposito(deposito);

                Console.WriteLine("Saldo após depósito: R$ " +
                    conta.Saldo.ToString("F2"));

                Console.WriteLine();
                Console.Write("Digite o valor do saque: ");
                double saque = double.Parse(Console.ReadLine());

                conta.Saque(saque);

                Console.WriteLine("Saldo após saque (com taxa de R$ 5,00): R$ " +
                    conta.Saldo.ToString("F2"));

                Console.WriteLine();
                Console.Write("Digite o valor do empréstimo: ");
                double emprestimo = double.Parse(Console.ReadLine());

                conta.Emprestimo(emprestimo);

                Console.WriteLine("Saldo após empréstimo: R$ " +
                    conta.Saldo.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
        }
    }
}