using AutoMapper;
using Farmacia.Application.Dtos.Medicamento;
using Farmacia.Entities;

namespace Farmacia.WebApi.Mapping
{
    public class MedicamentoMappingProfile : Profile
    {
        public MedicamentoMappingProfile()
        {
            CreateMap<Medicamento, MedicamentoResponseDto>()
                .ForMember(dest => dest.NombreMarca, ori => ori.MapFrom(src => src.Marca != null ? src.Marca.Nombre : null));
            CreateMap<MedicamentoRequestDto, Medicamento>();
        }
    }
}
