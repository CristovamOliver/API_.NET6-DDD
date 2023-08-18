using Application.DTO;
using AutoMapper;
using Entities.Entities;

namespace CrossCutting
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<Carro, CarroDTO>().ReverseMap();
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
        }
    }
}
