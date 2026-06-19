using AutoMapper;
using Farmacia.Application.Dtos.Cliente;
using Farmacia.Entities;

namespace Farmacia.WebApi.Mapping
{
    public class ClienteMappingProfile : Profile
    {
        public ClienteMappingProfile()
        {
            CreateMap<Cliente, ClienteResponseDto>();
            CreateMap<ClienteRequestDto, Cliente>();
        }
    }
}
