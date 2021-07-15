using MediatR;

namespace Calculo.Application.Queries
{
    public class CalcularRequest: IRequest<CalcularResult>
    {
        public decimal Valorinicial { get; set; }
        public int Tempo { get; set; }

        public CalcularRequest(decimal valorinicial, int tempo)
        {
            Valorinicial = valorinicial;
            Tempo = tempo;
        }
    }
}
