using Calculo.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace Calculo.Controllers
{
    [Route("api/calculajuros")]
    public class CalculoController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CalculoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/calculajuros/{valorinicial}/{tempo}")]
        [ProducesResponseType(typeof(CalcularResult), (int)HttpStatusCode.OK)]
        public async Task<CalcularResult> Calcular([FromRoute] double valorinicial, [FromRoute] int tempo)
        {
            var request = new CalcularRequest(valorinicial, tempo);
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpGet("/showmethecode")]
        public string GetShowMeTheCode()
        {
            return "https://github.com/luizcherpers/TesteJuros";
        }
    }
}
