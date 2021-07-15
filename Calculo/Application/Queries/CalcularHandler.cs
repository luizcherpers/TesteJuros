using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Calculo.Application.Queries
{
    public class CalcularHandler : IRequestHandler<CalcularRequest, CalcularResult>
    {
        public async Task<CalcularResult> Handle(CalcularRequest request, CancellationToken cancellationToken)
        {
            var v1 = 1 + (1M/100M);
            var pow = Math.Pow((double)v1, 5);
            var result = Math.Round((105 * pow), 2);
            return await Task.Run(() =>  new CalcularResult((decimal)result));
        }
    }
}
