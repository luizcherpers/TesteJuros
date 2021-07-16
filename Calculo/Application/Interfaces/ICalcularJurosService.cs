using Calculo.Application.Queries;
using System.Threading.Tasks;

namespace Calculo.Application.Interfaces
{
    public interface ICalcularJurosService
    {
        Task<CalcularResult> Calcular(double valorInicial, int tempo);
    }
}

