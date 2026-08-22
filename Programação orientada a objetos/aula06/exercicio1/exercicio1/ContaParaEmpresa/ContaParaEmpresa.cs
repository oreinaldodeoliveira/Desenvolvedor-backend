using System;
using Conta;

namespace ContaParaEmpresa
{
    public class ContaParaEmpresa : Conta
    {
        // Campo
        private double limiteDeEmprestimo;

        // Propriedade
        public double LimiteDeEmprestimo
        {
            get { return limiteDeEmprestimo; }
            set { limiteDeEmprestimo = value; }
        }

        // Construtores
        public ContaParaEmpresa(int numero, string titular)
            : base(numero, titular)
        {
        }

        public ContaParaEmpresa(int numero, string titular, double saldo)
            : base(numero, titular, saldo)
        {
        }

        // Empréstimo
        public void Emprestimo(double quantia)
        {
            if (quantia <= limiteDeEmprestimo)
            {
                saldo += quantia;
            }
            else
            {
                Console.WriteLine("Valor do empréstimo ultrapassa o limite.");
            }
        }
    }
}