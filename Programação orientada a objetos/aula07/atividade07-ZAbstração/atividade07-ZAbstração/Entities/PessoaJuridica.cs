namespace SistemaImposto.Entities
{
    public class PessoaJuridica : Contribuinte
    {
        private int numeroFuncionarios;

        public int NumeroFuncionarios
        {
            get { return numeroFuncionarios; }
            protected set { numeroFuncionarios = value; }
        }

        public PessoaJuridica(
            string nome,
            double rendaAnual,
            int numeroFuncionarios)
            : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double CalcularImposto()
        {
            if (NumeroFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}