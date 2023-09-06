using Application.DTO;
using Application.Interface;
using Moq;
using WebAPI.Controllers;

namespace xUnitTest.Controllers
{
    public class CarroControllerTest
    {
        [Fact]


        public async Task BuscaTodosCarros()
        {
            #region[Dados Mocados]

            List<CarroDTO> carros = new List<CarroDTO>() { };

            List<CarroDTO> carros2 = new List<CarroDTO>() { };

            List<CarroDTO> carros3 = new List<CarroDTO>() { };


            carros.Add(new CarroDTO()
            {
                CarroID = 1,
                Marca = "Honda",
                Modelo = "Civic",
                Ano = 2018,
                Cor = "Azul",
                KM = 70710
            });

            carros2.Add(new CarroDTO()
            {
                CarroID = 1,
                Marca = "Honda",
                Modelo = "Civic",
                Ano = 2018,
                Cor = "Azul",
                KM = 70710
            });

            carros3.Add(new CarroDTO()
            {
                CarroID = 3,
                Marca = "Toyota",
                Modelo = "Corolla",
                Ano = 2019,
                Cor = "Preto",
                KM = 85910
            });
            #endregion

            var servicoMock = new Mock<ICarroAppService>();

            servicoMock.Setup(m => m.SelecionarCarros().Result).Returns(carros);

            var controllerMock = new CarroController(servicoMock.Object);

            var resultado = await controllerMock.BuscarTodosCarros();

            Assert.NotNull(resultado);
            Assert.NotEqual(carros, carros3);
            Assert.Equal(carros, carros2);

        }

    }
}

