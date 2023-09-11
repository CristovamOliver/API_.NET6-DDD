using Application.DTO;

namespace xUnitTest.Mocks
{
    public class CarroMock
    {
        public List<CarroDTO> ListaCarrosMock()
        {
            List<CarroDTO> carros = new List<CarroDTO>() { };

            var carros1 = new CarroDTO()
            {
                CarroID = 1,
                Marca = "Honda",
                Modelo = "Civic",
                Ano = 2018,
                Cor = "Azul",
                KM = 70710
            };
            carros.Add(carros1);

            var carros2 = new CarroDTO()
            {
                CarroID = 1,
                Marca = "Honda",
                Modelo = "Civic",
                Ano = 2018,
                Cor = "Azul",
                KM = 70710
            };
            carros.Add(carros2);

            var carros3 = new CarroDTO()
            {
                CarroID = 3,
                Marca = "Toyota",
                Modelo = "Corolla",
                Ano = 2019,
                Cor = "Preto",
                KM = 85910
            };
            carros.Add(carros3);

            return carros;
        }
    }
}
