using SistemaImposto.Interfaces;

namespace SistemaImposto.Entities
{
    public abstract class Contribuinte : IContribuinte
    {
        private string nome;
        private double rendaAnual;

        public string Nome
        {
            get { return nome; }
            protected set { nome = value; }
        }

        public double RendaAnual
        {
            get { return rendaAnual; }
            protected set { rendaAnual = value; }
        }

        public Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalcularImposto();
    }
}