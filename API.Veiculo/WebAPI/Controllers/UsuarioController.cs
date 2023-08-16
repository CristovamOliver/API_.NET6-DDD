using Application.DTO;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioAppService _usuarioAppService;
        public UsuarioController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        [HttpGet("buscar")]
        public async Task<IActionResult> BuscarTodosUsuarios()
        {
            try
            {
                var buscausuarios = await _usuarioAppService.BuscarUsuarios();
                if (buscausuarios.Any())
                    return Ok(buscausuarios);
                return NotFound("Não foram encontrados usuários.");


            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpGet("buscar/{usuarioId}")]
        public async Task<IActionResult> BuscarUsuario(int usuarioId)
        {
            try
            {
                var buscarusuario = await _usuarioAppService.BuscarUsuario(usuarioId);
                if (buscarusuario == null)
                    return NotFound("Usuário não encontrado !");
                return Ok(buscarusuario);
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost("cadastrar")]
        public async Task<IActionResult> CadastrarUsuario(UsuarioDTO usuario)
        {
            try
            {
                var cadastrausuario = await _usuarioAppService.CadastrarUsuario(usuario);
                if (cadastrausuario)
                    return Ok(cadastrausuario);
                return BadRequest("Não foi possível cadastrar usuário");
            }
            catch(ArgumentException ex) 
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut("atualizar/{usuarioId}")]
        public async Task<IActionResult> AtualizarUsuario(UsuarioDTO usuarioId)
        {
            try
            {
                var atualizarusuario = await _usuarioAppService.AtualizarUsuario(usuarioId);
                if (atualizarusuario)
                    return Ok(atualizarusuario);
                return BadRequest("Não foi possível atualizar usuário");
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpDelete("deletar/{usuarioId}")]
        public async Task<IActionResult> DeletarUsuario(int usuarioId)
        {
            try
            {
                var deletarusuario = await _usuarioAppService.ExcluirUsuario(usuarioId);
                if (deletarusuario)
                    return Ok(deletarusuario);
                return BadRequest("Não foi possível excluir usuário");
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
