using Application.DTO;

namespace Application.Interface
{
    public interface ICarroAppService
    {
        Task<bool> CadastrarCarro(CarroDTO carro);
        Task<bool> AtualizarCarro(CarroDTO carro);
        Task<List<CarroDTO>> SelecionarCarros();
        Task<CarroDTO> CarroEspecifico(int carroId);
        Task<bool> ExcluirCarro(int carroId);
    }
}
