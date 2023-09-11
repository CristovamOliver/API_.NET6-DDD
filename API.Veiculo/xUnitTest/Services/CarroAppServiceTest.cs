using Application.Interface;
using Moq;
using System.Linq;
using xUnitTest.Mocks;

namespace xUnitTest.Services
{
    public class CarroAppServiceTest
    {
        [Fact]

        public async Task BuscaTodosCarros()
        {
            CarroMock carrosMock = new CarroMock();
            carrosMock.ListaCarrosMock();

            var servicoMock = new Mock<ICarroAppService>();

            servicoMock.Setup(m => m.SelecionarCarros().Result).Returns(carrosMock.ListaCarrosMock());
            var primeiroItem = carrosMock.ListaCarrosMock().First();
            var ultimoItem = carrosMock.ListaCarrosMock().Last();
            Assert.NotEqual(primeiroItem, ultimoItem);
            Assert.Equal(primeiroItem, primeiroItem);
        }
    }
}