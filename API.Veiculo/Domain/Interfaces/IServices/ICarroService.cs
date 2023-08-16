using Entities.Entities;

namespace Domain.Interfaces.IServices
{
    public interface ICarroService

    {
        Task<bool> CadastrarCarro(Carro carro);
        Task<bool> AtualizarCarro(Carro carro);
        Task<List<Carro>> SelecionarCarros();
        Task<List<Carro>> CarroEspecifico(int carroId);
        Task<bool> ExcluirCarro(int carroId);
    }
}
