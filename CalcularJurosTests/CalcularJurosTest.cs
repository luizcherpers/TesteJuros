using Calculo.Application.Interfaces;
using Calculo.Application.Services;
using Moq;
using Xunit;

namespace CalcularJurosTests
{
    public class CalcularJurosTest
    {
        [Theory(DisplayName = "Calcular Juros")]
        [InlineData(100, 5, 105.10)]
        [InlineData(200, 5, 210.20)]
        [InlineData(300, 5, 315.30)]
        [InlineData(400, 5, 420.40)]
        public async void Calcular_Juros_Test(double valorInicial, int tempo, double experado)
        {
            //Arrange
            var juros = 0.01;
            var mockITaxaJuros = new Mock<IObterTaxaJuros>();
            mockITaxaJuros.Setup(s => s.ObterPercentual()).ReturnsAsync(juros);
            var mockCalcularJurosService = new CalcularJurosService(mockITaxaJuros.Object);

            //Act
            var result = await mockCalcularJurosService.Calcular(valorInicial, tempo);

            //Assert
            Assert.Equal(experado, result.ValorFinal);
        }

        [Theory(DisplayName = "Taxa Juros")]
        [InlineData(0.01)]
        public async void Obter_Taxa_Juros_Test(double taxa)
        {
            //Arrange
            var juros = 0.01;
            var mockITaxaJuros = new Mock<IObterTaxaJuros>();
            mockITaxaJuros.Setup(s => s.ObterPercentual()).ReturnsAsync(juros);

            //Act
            var result = await mockITaxaJuros.Object.ObterPercentual();

            //Assert
            Assert.Equal(taxa, result);
        }
    }
}


