using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Taxajuro.Application.Classe;

namespace Taxajuro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController: ControllerBase
    {
        [HttpGet]
        public async Task<Juro> Get()
        {
            return await Task.Run(() => new Juro());
        }
    }
}
