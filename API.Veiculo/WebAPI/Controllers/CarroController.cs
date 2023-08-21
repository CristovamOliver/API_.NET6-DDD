
using Application.DTO;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Net;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        private ICarroAppService _carroAppService;
        public CarroController(ICarroAppService carroAppService)
        {
            _carroAppService = carroAppService;
        }

        [HttpGet("buscar")]
        public async Task<IActionResult> BuscarTodosCarros()
        {
            try
            {
                var buscarcarro = await _carroAppService.SelecionarCarros();
                if (buscarcarro.Any())
                    return Ok(buscarcarro);
                return NotFound("Não foram encontrados carros.");


            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpGet("buscar/{carroId}")]
        public async Task<IActionResult> BuscarCarro(int carroId)
        {
            try
            {
                var buscarcarro = await _carroAppService.CarroEspecifico(carroId);
                if (buscarcarro.IsNullOrEmpty())
                    return NotFound("Carro não encontrado !");
                return Ok(buscarcarro);
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost("cadastrar")]
        public async Task<IActionResult> CadastrarCarro(CarroDTO carro)
        {
            try
            {
                var cadastracarro = await _carroAppService.CadastrarCarro(carro);
                if (cadastracarro)
                    return Ok(cadastracarro);
                return BadRequest("Não foi possível cadastrar o carro");
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut("atualizar/{carroId}")]
        public async Task<IActionResult> AtualizarCarro(CarroDTO carroId)
        {
            try
            {
                var atualizarcarro = await _carroAppService.AtualizarCarro(carroId);
                if (atualizarcarro)
                    return Ok(atualizarcarro);
                return BadRequest("Não foi possível atualizar o carro");
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpDelete("deletar/{carroId}")]
        public async Task<IActionResult> DeletarCarro(int carroId)
        {
            try
            {
                var deletarcarro = await _carroAppService.ExcluirCarro(carroId);
                if (deletarcarro)
                    return Ok(deletarcarro);
                return BadRequest("Não foi possível excluir o carro");
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
