using Calculo.Application.Interfaces;
using Calculo.Application.Services;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Calculo.Application.Queries
{
    public class CalcularHandler : IRequestHandler<CalcularRequest, CalcularResult>
    {
        private readonly ICalcularJurosService _calcularJurosService;

        public CalcularHandler(ICalcularJurosService calcularJurosService)
{
            _calcularJurosService = calcularJurosService;
        }

        public async Task<CalcularResult> Handle(CalcularRequest request, CancellationToken cancellationToken)
        {
            return await _calcularJurosService.Calcular(request.Valorinicial, request.Tempo);
        }
    }
}
