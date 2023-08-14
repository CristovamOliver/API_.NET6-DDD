using Application.DTO;
using Application.Interface;
using AutoMapper;
using Domain.Interfaces.IServices;
using Entities.Entities;

namespace Application.Service
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioservice;
        private readonly IMapper _mapper;

        public UsuarioAppService(IUsuarioService usuarioservice, IMapper mapper)
        {
            _usuarioservice = usuarioservice;
            _mapper = mapper;
        }

        public async Task<bool> AtualizarUsuario(UsuarioDTO usuario)
        {
            var atualizarUsuario = await _usuarioservice.AtualizarUsuario(_mapper.Map<Usuario>(usuario));
            return atualizarUsuario;
        }

        public async Task<List<UsuarioDTO>> BuscarUsuarios()
        {
            var buscarUsuarios = _mapper.Map<List<UsuarioDTO>>(await _usuarioservice.BuscarUsuarios());
            return buscarUsuarios;
        }

        public async Task<UsuarioDTO> BuscarUsuario(int usuarioId)
        {
            var buscarUsuario = _mapper.Map<UsuarioDTO>(await _usuarioservice.BuscarUsuario(usuarioId));
            return buscarUsuario;
        }

        public async Task<bool> CadastrarUsuario(UsuarioDTO usuario)
        {
            var cadastrarUsuario = await _usuarioservice.CadastrarUsuario(_mapper.Map<Usuario>(usuario));
            return cadastrarUsuario;
        }

        public async Task<bool> ExcluirUsuario(int usuarioId)
        {
            var excluirUsuario = await _usuarioservice.ExcluirUsuario(_mapper.Map<int>(usuarioId));
            return excluirUsuario;
        }
    }
}
