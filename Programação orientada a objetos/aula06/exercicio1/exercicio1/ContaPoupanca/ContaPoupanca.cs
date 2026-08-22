using System;
using Conta;

namespace ContaPoupanca
{
    public class ContaPoupanca : Conta
    {
        // Campo
        private double taxaDeJuros;

        // Propriedade
        protected double TaxaDeJuros
        {
            get { return taxaDeJuros; }
            set { taxaDeJuros = value; }
        }

        // Construtores
        public ContaPoupanca(int numero, string titular)
            : base(numero, titular)
        {
        }

        public ContaPoupanca(int numero, string titular, double saldo)
            : base(numero, titular, saldo)
        {
        }

        // Atualização do saldo
        public void AtualizacaoDeSaldo()
        {
            saldo += saldo * taxaDeJuros;
        }

        // Saque sem taxa
        public override void Saque(double quantia)
        {
            saldo -= quantia;
        }
    }
}