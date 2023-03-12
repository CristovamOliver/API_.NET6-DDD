using Entities.Entities;

namespace Domain.Interfaces.IServices
{
    public interface IUsuarioService
    {
        Task<bool> CadastrarUsuario(Usuario usuario);
        Task<List<Usuario>> BuscarUsuarios();
        Task<bool> AtualizarUsuario(Usuario usuario);
        Task<bool> ExcluirUsuario(int usuarioId);
    }
}
