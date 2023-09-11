﻿using Application.Interface;
using Moq;
using WebAPI.Controllers;
using xUnitTest.Mocks;

namespace xUnitTest.Controllers
{
    public class CarroControllerTest
    {
        [Fact]

        public async Task BuscaTodosCarros()
        {
            CarroMock carrosMock = new CarroMock();

            var servicoMock = new Mock<ICarroAppService>();

            servicoMock.Setup(m => m.SelecionarCarros().Result).Returns(carrosMock.ListaCarrosMock());

            var controllerMock = new CarroController(servicoMock.Object);

            var resultado = await controllerMock.BuscarTodosCarros();

            Assert.NotNull(resultado);

        }

    }
}

