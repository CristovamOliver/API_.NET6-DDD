using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;
using Entities.Entities;

namespace Domain.Services
{
    public class MarcaService : IMarcaService
    {
        private readonly IMarcaRepository _marcaRepository;

        public MarcaService(IMarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

        public Task<bool> AtualizarMarca(Marca marca)
        {
            var atualizarMarca = _marcaRepository.AtualizarMarca(marca);
            return atualizarMarca;
        }

        public Task<List<Marca>> BuscarMarca(int marcaId)
        {
            var buscarMarca = _marcaRepository.BuscarMarca(marcaId);
            return buscarMarca;
        }

        public Task<List<Marca>> BuscarMarcas()
        {
            var todasMarcas = _marcaRepository.BuscarMarcas();
            return todasMarcas;
        }

        public Task<bool> CadastrarMarca(Marca marca)
        {
            var cadastrarMarca = _marcaRepository.CadastrarMarca(marca);
            return cadastrarMarca;
        }

        public Task<bool> ExcluirMarca(int marcaId)
        {
            var excluirMarca = _marcaRepository.ExcluirMarca(marcaId);
            return excluirMarca;
        }
    }
}
