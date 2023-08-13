using Application.DTO;

namespace Application.Interface
{
    public interface IMarcaAppService
    {
        Task<bool> CadastrarMarca(MarcaDTO marcaId);
        Task<bool> AtualizarMarca(MarcaDTO NomeMarca);
        Task<bool> ExcluirMarca(int marcaId);
        Task<MarcaDTO> BuscarMarca(int marcaId);
        Task<List<MarcaDTO>> BuscarMarcas();
    }
}
