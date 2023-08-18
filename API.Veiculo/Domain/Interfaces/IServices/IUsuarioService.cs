using Entities.Entities;

namespace Domain.Interfaces.IServices
{
    public interface IUsuarioService
    {
        Task<bool> CadastrarUsuario(Usuario usuario);
        Task<List<Usuario>> BuscarUsuarios();
        Task<List<Usuario>> BuscarUsuario(int UsuarioID);
        Task<bool> AtualizarUsuario(Usuario usuario);
        Task<bool> ExcluirUsuario(int usuarioId);
    }
}
