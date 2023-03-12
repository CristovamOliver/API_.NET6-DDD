using Entities.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface ICarroRepository
    {
        Task<bool> CadastrarCarro(Carro carro);
        Task<bool> AtualizarCarro(Carro carro);
        Task<bool> ExcluirCarro(int carroId);
        Task<List<Carro>> SelecionarCarros();
        Task<Carro> CarroEspecifico(int carroId);
    }
}
