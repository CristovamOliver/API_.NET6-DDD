using Application.DTO;
using Application.Interface;
using AutoMapper;

namespace Application.Service
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioAppService _usuarioAppservice;
        private readonly IMapper _mapper;

        public UsuarioAppService(IUsuarioAppService usuarioAppservice, IMapper mapper)
        {
            _usuarioAppservice = usuarioAppservice;
            _mapper = mapper;
        }

        public async Task<bool> AtualizarUsuario(UsuarioDTO usuario)
        {
            var atualizarUsuario = await _usuarioAppservice.AtualizarUsuario(_mapper.Map<UsuarioDTO>(usuario));
            return atualizarUsuario;
        }

        public async Task<List<UsuarioDTO>> BuscarUsuarios()
        {
            var buscarUsuarios = _mapper.Map<List<UsuarioDTO>>(await _usuarioAppservice.BuscarUsuarios());
            return buscarUsuarios;
        }

        public async Task<UsuarioDTO> BuscarUsuario(int usuarioId)
        {
            var buscarUsuario = _mapper.Map<UsuarioDTO>(await _usuarioAppservice.BuscarUsuario(usuarioId));
            return buscarUsuario;
        }

        public async Task<bool> CadastrarUsuario(UsuarioDTO usuario)
        {
            var cadastrarUsuario = await _usuarioAppservice.CadastrarUsuario(_mapper.Map<UsuarioDTO>(usuario));
            return cadastrarUsuario;
        }

        public async Task<bool> ExcluirUsuario(int usuarioId)
        {
            var excluirUsuario = await _usuarioAppservice.ExcluirUsuario(_mapper.Map<int>(usuarioId));
            return excluirUsuario;
        }
    }
}
