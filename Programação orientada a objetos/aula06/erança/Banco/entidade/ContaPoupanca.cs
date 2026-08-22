
namespace Banco.entidade
{
    internal class ContaPoupanca : Conta
    {
        //Campos

        private double taxa;

        //Propriedades
        protected double TaxaDeJuros
        {
            get { return taxa; }
            set { taxa = value; }
        }

        //Construtores
        public ContaPoupanca(int numeroDaConta, string titularDaConta) : base(numeroDaConta, titularDaConta)
        {
            TaxaDeJuros = Taxa; 
        }

        public ContaPoupanca(int numeroDaConta, string titularDaConta, double saldoDaConta) : base(numeroDaConta, titularDaConta, saldoDaConta)
        {
            TaxaDeJuros = Taxa; 
        }

        //Métodos

        public override void Saque(double quantia)
        {
            base.Saque(quantia);
            SaldoDaConta -= quantia + (quantia * TaxaDeJuros);
        }
    }
}
