using SistemaImposto.Entities;

namespace SistemaImposto.Services
{
    public class ImpostoService
    {
        public double CalcularImposto(Contribuinte contribuinte)
        {
            return contribuinte.CalcularImposto();
        }
    }
}