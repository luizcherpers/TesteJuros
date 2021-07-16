using Calculo.Application.Interfaces;
using Calculo.Application.Model;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Calculo.Application.Services
{
    public class ObterTaxaJuros : IObterTaxaJuros
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ObterTaxaJuros(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public async Task<double> ObterPercentual()
        {
            var baseUrl = _configuration["ApiTaxaJuros:Url"].ToString();

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(baseUrl);

            client.DefaultRequestHeaders.Clear();

            client.Timeout = TimeSpan.FromSeconds(10);

            using (var res = await client.GetAsync("/TaxaJuros"))
            {
                using (var content = res.Content)
                {
                    var retorno = await content.ReadAsStringAsync();

                    var retornoDeserealizado = JsonConvert.DeserializeObject<Juro>(retorno);

                    return retornoDeserealizado.Percentual;
                }
            }

        }
     }
}
