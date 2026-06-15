using AutoMapper;
using Farmacia.Application.Dtos.Laboratorio;
using Farmacia.Entities;

namespace Farmacia.WebApi.Mapping
{
    public class LaboratorioMappingProfile : Profile
    {
        public LaboratorioMappingProfile()
        {
            CreateMap<Laboratorio, LaboratorioResponseDto>();
            CreateMap<LaboratorioRequestDto, Laboratorio>();
        }
    }
}
