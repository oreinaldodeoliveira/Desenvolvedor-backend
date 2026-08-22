

namespace Banco.Classes.Entidades
{
    internal class ContaPessoalFisica
    {
        //Campos
        private int numero;
        private string titular;
        private double saldo;

        //Propiedades
        public string TitularDaConta
        {
            get { return titular; }
            set { titular = value; }
        }
        public int NumeroConta
        {
            get { return numero; }
            set { numero = value; }
        }
        public double SaldoDaConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //Construtor
        public ContaPessoalFisica(String titularDaConta, int numeroDaConta)
        {
            titularDaConta = titularDaConta;
           numeroDaConta = numeroDaConta;
            SaldoDaConta = 0;
        }

        public ContaPessoalFisica(String titularDaConta, int numeroDaConta, double saldoDaConta)
        {
            this.titular = titularDaConta;
            this.numero = numeroDaConta;
            this.saldo = saldoDaConta;
        }

        //Metodos

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }

    }
}
