using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;
using Entities.Entities;

namespace Domain.Services
{
    public class CarroService : ICarroService
    {
        private readonly ICarroRepository _carroRepository;

        public CarroService(ICarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }
        public Task<bool> AtualizarCarro(Carro carro)
        {
            var atualizaCarro = _carroRepository.AtualizarCarro(carro);
            return atualizaCarro;
        }

        public Task<bool> CadastrarCarro(Carro carro)
        {
            var cadastrarCarro = _carroRepository.CadastrarCarro(carro);
            return cadastrarCarro;
        }

        public Task<List<Carro>> CarroEspecifico(int carroId)
        {
            var carro = _carroRepository.CarroEspecifico(carroId);
            return carro;
        }

        public Task<bool> ExcluirCarro(int carroId)
        {
            var excluirCarro = _carroRepository.ExcluirCarro(carroId);
            return excluirCarro;
        }

        public Task<List<Carro>> SelecionarCarros()
        {
            var todosCarros = _carroRepository.SelecionarCarros();
            return todosCarros;
        }
    }
}
