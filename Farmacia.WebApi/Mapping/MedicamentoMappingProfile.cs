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
                .ForMember(
                    dest => dest.NombreMarca,
                    opt => opt.MapFrom(src => src.Marca.Nombre));

            CreateMap<MedicamentoRequestDto, Medicamento>();
        }
    }
}

