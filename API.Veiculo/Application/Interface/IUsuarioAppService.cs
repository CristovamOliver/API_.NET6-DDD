using Application.DTO;

namespace Application.Interface
{
    public interface IUsuarioAppService
    {
        Task<List<UsuarioDTO>> BuscarUsuarios();
        Task<List<UsuarioDTO>> BuscarUsuario(int usuarioId);
        Task<bool> CadastrarUsuario(UsuarioDTO usuario);
        Task<bool> AtualizarUsuario(UsuarioDTO usuario);
        Task<bool> ExcluirUsuario(int usuarioId);
    }
}
