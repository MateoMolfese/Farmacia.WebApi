using AutoMapper;
using Farmacia.Application.Dtos.Proveedor;
using Farmacia.Entities;

namespace Farmacia.WebApi.Mapping
{
    public class ProveedorMappingProfile : Profile
    {
        public ProveedorMappingProfile()
        {
            CreateMap<Proveedor, ProveedorResponseDto>();
            CreateMap<ProveedorRequestDto, Proveedor>();
        }
    }
}
