using Application.DTO;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaAppService _marcaAppService;

        public MarcaController(IMarcaAppService marcaAppService)
        {
            _marcaAppService = marcaAppService;
        }

        [HttpGet("buscar")]
        public async Task<IActionResult> BuscarTodasMarcas()
        {
            try
            {
                var marcas = await _marcaAppService.BuscarMarcas();
                if (marcas.Any())
                    return Ok(marcas);
                return NotFound("Não foram encontrados registros");
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet("buscar/{marcaId}")]
        public async Task<IActionResult> BuscarMarca(int marcaId)
        {
            try
            {
                var marca = await _marcaAppService.BuscarMarca(marcaId);
                if (marca == null)
                    return NotFound("Não foram encontrados registros");
                return Ok(marca);

            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost("cadastrar")]
        public async Task<IActionResult> CadastrarMarca(MarcaDTO marca)
        {
            try
            {
                var marcaCadastrada = await _marcaAppService.CadastrarMarca(marca);
                if (marcaCadastrada)
                    return Ok();
                return BadRequest("Ocorreu um erro ao cadastrar a marca");
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut("atualizar/{marcaId}")]

        public async Task<IActionResult> AtualizarMarca(MarcaDTO marcaId)
        {
            try
            {
                var atualizarMarca = await _marcaAppService.AtualizarMarca(marcaId);
                if (atualizarMarca)
                    return Ok();
                return BadRequest("Ocorreu um erro ao atualizar a marca.");
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);

            }
        }

        [HttpDelete("deletar/{marcaId}")]
        public async Task<IActionResult> DeletarMarca(int marcaId)
        {
            try
            {
                var deletarMarca = await _marcaAppService.ExcluirMarca(marcaId);
                if (deletarMarca)
                    return Ok();
                return BadRequest("Ocorreu um erro ao deletar a marca.");
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);

            }
        }

    }
}
