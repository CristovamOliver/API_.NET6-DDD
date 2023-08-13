using Application.DTO;

namespace Application.Interface
{
    public interface IUsuarioAppService
    {
        Task<List<UsuarioDTO>> BuscarUsuarios();
        Task<bool> CadastrarUsuario(UsuarioDTO usuario);
        Task<bool> AtualizarUsuario(UsuarioDTO usuario);
        Task<bool> ExcluirUsuario(int usuarioId);
    }
}
