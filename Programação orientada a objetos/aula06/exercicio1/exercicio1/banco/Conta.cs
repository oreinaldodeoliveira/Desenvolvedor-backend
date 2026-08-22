using System;

namespace Conta
{
    public class Conta
    {
        // Campos
        protected int numero;
        protected string titular;
        protected double saldo;

        // Construtor
        public Conta(int numero, string titular, double saldo = 0)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        // Propriedades
        public int Numero
        {
            get { return numero; }
        }

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public double Saldo
        {
            get { return saldo; }
        }

        // Métodos
        public virtual void Saque(double quantia)
        {
            saldo -= quantia + 5.00;
        }

        public void Deposito(double quantia)
        {
            saldo += quantia;
        }
    }
}