using Entities.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface IUsuarioRepository
    {
        Task<bool> CadastrarUsuario(Usuario usuario);
        Task<List<Usuario>> BuscarUsuarios();
        Task<bool> AtualizarUsuario(Usuario usuario);
        Task<bool> ExcluirUsuario(int usuarioId);
    }
}
