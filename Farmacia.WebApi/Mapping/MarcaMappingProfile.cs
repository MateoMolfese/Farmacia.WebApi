using AutoMapper;
using Farmacia.Application.Dtos.Marca;
using Farmacia.Entities;

namespace Farmacia.WebApi.Mapping
{
    public class MarcaMappingProfile : Profile
    {
        public MarcaMappingProfile()
        {
            CreateMap<Marca, MarcaResponseDto>();
            CreateMap<MarcaRequestDto, Marca>();
        }
    }
}
