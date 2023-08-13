using Application.DTO;
using Application.Interface;
using AutoMapper;
using Domain.Interfaces.IServices;
using Entities.Entities;

namespace Application.Service
{
    public class MarcaAppService : IMarcaAppService
    {
        private readonly IMarcaService _marcaService;
        private readonly IMapper _mapper;

        public MarcaAppService(IMarcaService marcaService, IMapper mapper)
        {
            _marcaService = marcaService;
            _mapper = mapper;
        }

        public async Task<bool> AtualizarMarca(MarcaDTO NomeMarca)
        {
            var atualizarMarca = await _marcaService.AtualizarMarca(_mapper.Map<Marca>(NomeMarca));
            return atualizarMarca;
        }

        public async Task<MarcaDTO> BuscarMarca(int marcaId)
        {
            var buscaMarca = _mapper.Map<MarcaDTO>(await _marcaService.BuscarMarca(marcaId));
            return buscaMarca;
        }

        public async Task<List<MarcaDTO>> BuscarMarcas()
        {
            var buscarMarcas = _mapper.Map<List<MarcaDTO>>(await _marcaService.BuscarMarcas());
            return buscarMarcas;
        }

        public async Task<bool> CadastrarMarca(MarcaDTO marcaId)
        {
            var cadastrarMarca = await _marcaService.CadastrarMarca(_mapper.Map<Marca>(marcaId));
            return cadastrarMarca;
        }

        public async Task<bool> ExcluirMarca(int marcaId)
        {
            var excluirMarca = await _marcaService.ExcluirMarca(_mapper.Map<int>(marcaId));
            return excluirMarca;
        }
    }
}
