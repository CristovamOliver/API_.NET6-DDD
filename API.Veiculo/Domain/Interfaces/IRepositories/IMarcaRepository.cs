using Entities.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface IMarcaRepository
    {
        Task<bool> CadastrarMarca(Marca marca);
        Task<bool> AtualizarMarca(Marca marca);
        Task<List<Marca>> BuscarMarca(int marcaId);
        Task<List<Marca>> BuscarMarcas();
        Task<bool> ExcluirMarca(int marcaId);
    }

}
