using AutoMapper;
using Farmacia.Application.Dtos.Sucursal;
using Farmacia.Entities;

namespace Farmacia.WebApi.Mapping
{
    public class SucursalMappingProfile : Profile
    {
        public SucursalMappingProfile()
        {
            CreateMap<Sucursal, SucursalResponseDto>();
            CreateMap<SucursalRequestDto, Sucursal>();
        }
    }
}
