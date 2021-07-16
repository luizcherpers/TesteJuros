using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculo.Application.Interfaces
{
    public interface IObterTaxaJuros
    {
        Task<double> ObterPercentual();
    }
}
