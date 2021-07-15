using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Taxajuro.Application.Classe;

namespace Taxajuro.Controllers
{
    [Route("api/taxa-juro")]
    public class RetornaJuroController : ControllerBase
    {
        [HttpGet("juro")]
        public async Task<Juro> GetJuro()
        {
            return await Task.Run(() => new Juro { Percentual = (1M/100M) });
        }
    }
}
