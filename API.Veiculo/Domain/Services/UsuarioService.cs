using Domain.Interfaces.IServices;
using Domain.Interfaces.IRepositories;
using Entities.Entities;

namespace Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public Task<bool> AtualizarUsuario(Usuario usuario)
        {
            var atualizaUsuario = _usuarioRepository.AtualizarUsuario(usuario);
            return atualizaUsuario;
        }

        public Task<List<Usuario>> BuscarUsuarios()
        {
            var todosUsuarios = _usuarioRepository.BuscarUsuarios();
            return todosUsuarios;
        }

        public async Task<bool> CadastrarUsuario(Usuario usuario)
        {
            var cadastrarUsuario = await _usuarioRepository.CadastrarUsuario(usuario);
            return cadastrarUsuario;
        }

        public async Task<bool> ExcluirUsuario(int usuarioId)
        {
            var excluirUsuario = await _usuarioRepository.ExcluirUsuario(usuarioId);
            return excluirUsuario;
        }
    }
}
