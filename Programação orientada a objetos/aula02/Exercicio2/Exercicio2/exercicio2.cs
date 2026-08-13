using System;

namespace Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o salário bruto do funcionário: ");
            double salarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor total de imposto a ser pago pelo funcionário: ");
            double imposto = double.Parse(Console.ReadLine());

            // Criação do funcionário
            Funcionario funcionario = new Funcionario(nome, salarioBruto, imposto);

            // Saída de dados
            Console.WriteLine();
            Console.WriteLine("Dados do funcionário:");
            Console.WriteLine("Nome do funcionário: " + funcionario.Nome);
            Console.WriteLine("Salário líquido: R$ " + funcionario.SalarioLiquido().ToString("F2"));

            // Aumento
            Console.WriteLine();
            Console.Write("Digite a porcentagem de aumento do salário do funcionário: ");
            double porcentagem = double.Parse(Console.ReadLine());

            funcionario.AumentarSalario(porcentagem);

            // Saída atualizada
            Console.WriteLine();
            Console.WriteLine("Salário do funcionário aumentado em " + porcentagem.ToString("F2") + " %");
            Console.WriteLine();
            Console.WriteLine("Dados do funcionário atualizados:");
            Console.WriteLine("Nome do funcionário: " + funcionario.Nome);
            Console.WriteLine("Salário líquido: R$ " + funcionario.SalarioLiquido().ToString("F2"));
        }
    }

    internal class Funcionario
    {
        // Campos
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        // Construtor
        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        // Método para calcular o salário líquido
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        // Método para aumentar o salário
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
        }
    }
}