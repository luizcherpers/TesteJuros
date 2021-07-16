using MediatR;

namespace Calculo.Application.Queries
{
    public class CalcularRequest: IRequest<CalcularResult>
    {
        public double Valorinicial { get; set; }
        public int Tempo { get; set; }

        public CalcularRequest(double valorinicial, int tempo)
        {
            Valorinicial = valorinicial;
            Tempo = tempo;
        }
    }
}
