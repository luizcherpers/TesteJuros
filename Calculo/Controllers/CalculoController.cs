using Calculo.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace Calculo.Controllers
{
    [Route("api/Calculo")]
    public class CalculoController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CalculoController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("calcular/{valorinicial}/{tempo}")]
        [ProducesResponseType(typeof(CalcularResult), (int)HttpStatusCode.OK)]
        public async Task<CalcularResult> Calcular([FromRoute] decimal valorinicial, [FromRoute] int tempo)
        {
            var request = new CalcularRequest(valorinicial, tempo);
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
