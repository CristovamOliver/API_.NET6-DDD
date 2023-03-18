using Entities.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface IUsuarioRepository
    {
        Task<bool> CadastrarUsuario(Usuario usuario);
        Task<List<Usuario>> BuscarUsuarios();
        Task<Usuario> BuscarUsuario(int UsuarioID);
        Task<bool> AtualizarUsuario(Usuario usuario);
        Task<bool> ExcluirUsuario(int usuarioId);
    }
}
