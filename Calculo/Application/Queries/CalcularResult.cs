
namespace Calculo.Application.Queries
{
    public class CalcularResult
    {
        public decimal ValorFinal { get;  }

        public CalcularResult(decimal valorFinal)
        {
            ValorFinal = valorFinal;
        }
    }
}
