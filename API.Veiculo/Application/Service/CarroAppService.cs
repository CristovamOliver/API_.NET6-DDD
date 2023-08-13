using Application.DTO;
using Application.Interface;
using AutoMapper;
using Domain.Interfaces.IServices;
using Entities.Entities;

namespace Application.Service
{
    public class CarroAppService : ICarroAppService
    {

        private readonly ICarroService _carroService;
        private readonly IMapper _mapper;

        public CarroAppService(ICarroService carroService, IMapper mapper)
        {
            _carroService = carroService;
            _mapper = mapper;
        }

        public async Task<bool> AtualizarCarro(CarroDTO carro)
        {
            var atualizarCarro = await _carroService.AtualizarCarro(_mapper.Map<Carro>(carro));
            return atualizarCarro;
        }

        public async Task<bool> CadastrarCarro(CarroDTO carro)
        {
            var cadastrarCarro = await _carroService.CadastrarCarro(_mapper.Map<Carro>(carro));
            return cadastrarCarro;
        }

        public async Task<CarroDTO> CarroEspecifico(int carroId)
        {
            var carroEspecifico = _mapper.Map<CarroDTO>(await _carroService.CarroEspecifico(carroId));
            return carroEspecifico;
        }

        public async Task<bool> ExcluirCarro(int carroId)
        {
            var excluirCarro = await _carroService.ExcluirCarro(_mapper.Map<int>(carroId));
            return excluirCarro;
        }

        public async Task<List<CarroDTO>> SelecionarCarros()
        {
            var selecionarCarros = _mapper.Map<List<CarroDTO>>(await _carroService.SelecionarCarros());
            return selecionarCarros;
        }
    }
}
