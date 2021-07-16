
namespace Calculo.Application.Queries
{
    public class CalcularResult
    {
        public double ValorFinal { get;  }

        public CalcularResult(double valorFinal)
        {
            ValorFinal = valorFinal;
        }
    }
}