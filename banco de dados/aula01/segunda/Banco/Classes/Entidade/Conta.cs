

namespace Banco.Classes.Entidade
{
    internal class Conta
    {
        //Propiedades
        public int Id { get; set; }  
        public int NumeroDaCota { get; set; }
        public string TitularDaConta { get; set; }
        public decimal SaldoDaConta { get; set; }

        //Construtores
        private Conta() { }

        public Conta(int numeroDaCota, string titularDaConta, decimal saldoDaConta)
        {
            NumeroDaCota = numeroDaCota;
            TitularDaConta = titularDaConta;
            SaldoDaConta = saldoDaConta;
        }

        //Métodos
        public void Depositar(decimal Quantidade)
        {
            SaldoDaConta += Quantidade;
        }

        public void Sacar(decimal Quantidade)
        {
            SaldoDaConta -= Quantidade;
        }

        public void Exibirdados()
        {
            Console.WriteLine("-- Dados da conta--" +
                $"\nNúmero da conta: {NumeroDaCota}" +
                $"\nTitular da conta: {TitularDaConta}" +
                $"\nSaldo da conta: {SaldoDaConta}" +
                $"\n-------------------------------");

        }

    }
}
