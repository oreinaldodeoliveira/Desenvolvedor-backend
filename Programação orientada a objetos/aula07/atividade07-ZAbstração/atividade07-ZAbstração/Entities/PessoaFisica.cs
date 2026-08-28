namespace SistemaImposto.Entities
{
    public class PessoaFisica : Contribuinte
    {
        private double gastosSaude;

        public double GastosSaude
        {
            get { return gastosSaude; }
            protected set { gastosSaude = value; }
        }

        public PessoaFisica(
            string nome,
            double rendaAnual,
            double gastosSaude)
            : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double CalcularImposto()
        {
            double imposto;

            if (RendaAnual < 20000.00)
            {
                imposto = RendaAnual * 0.15;
            }
            else
            {
                imposto = RendaAnual * 0.25;
            }

            imposto -= GastosSaude * 0.50;

            return imposto;
        }
    }
}