using Calculo.Application.Interfaces;
using Calculo.Application.Queries;
using System;
using System.Threading.Tasks;

namespace Calculo.Application.Services
{
    public class CalcularJurosService : ICalcularJurosService
    {
        private readonly IObterTaxaJuros _obterTaxaJuros;

        public CalcularJurosService(IObterTaxaJuros obterTaxaJuros)
        {
            _obterTaxaJuros = obterTaxaJuros;
        }

        public async Task<CalcularResult> Calcular(double valorInicial, int tempo)
        {
            var taxa = await _obterTaxaJuros.ObterPercentual();

            var resultado = valorInicial * ( Math.Pow((1 + taxa), tempo));

            resultado = Math.Round(resultado, 2);

            return new CalcularResult(resultado);
        }
    }
}
