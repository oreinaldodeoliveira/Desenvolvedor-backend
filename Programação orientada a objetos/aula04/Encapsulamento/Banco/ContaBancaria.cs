

namespace Banco
{
    internal class ContaBancaria
    {
        //1° - Campos
        private string titular;
        private int numero;
        private double saldo;


        //2° - Propriedades

        protected string TitularDaConta
        {
            get { return titular; }
            set
            {
                if (value != null | value != "")
                {

                    titular = value;

                }
                else
                {
                    Console.WriteLine("valor de campo inválido");
                }
            }
        }

        protected int NumeroDaConta
        {
            get { return numero; }
            private set { numero = value; }
        }

        protected double SaldoDaConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //3° - Construtor
        public ContaBancaria(string titularDaConta, int numeroDaConta, double saldoDaConta)
        {
            TitularDaConta = titularDaConta;
            NumeroDaConta = numeroDaConta;
            SaldoDaConta = saldoDaConta;
        }

        //4° - Métodos
        protected void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }

        protected void Saque(double quantia)
        {
            if (quantia < 0)
            {
                Console.WriteLine("Valor invalido, inseria valor positivos ou diferentes de zero");
            }
            else
            {
                SaldoDaConta -= quantia + 5.00;
            }
        }

        public string ExibirDados()
        {
            return $"Dados da Conta:\n" +
                $"\tTitular: {TitularDaConta}\n" +
                $"\tNúmero da Conta: {NumeroDaConta}\n" +
                $"\tSaldo: {SaldoDaConta:C}";
        }
    }
}