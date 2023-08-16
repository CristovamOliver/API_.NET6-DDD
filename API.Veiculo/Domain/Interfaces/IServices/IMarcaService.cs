using Entities.Entities;

namespace Domain.Interfaces.IServices
{
    public interface IMarcaService

    {
        Task<bool> CadastrarMarca(Marca marca);
        Task<bool> AtualizarMarca(Marca marca);
        Task<List<Marca>> BuscarMarcas();
        Task<List<Marca>> BuscarMarca(int marcaId);
        Task<bool> ExcluirMarca(int marcaId);
    }

}
