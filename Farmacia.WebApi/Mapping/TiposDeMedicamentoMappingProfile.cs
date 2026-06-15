using AutoMapper;
using Farmacia.Application.Dtos.TiposDeMedicamento;
using Farmacia.Entities;

namespace Farmacia.WebApi.Mapping
{
    public class TiposDeMedicamentoMappingProfile : Profile
    {
        public TiposDeMedicamentoMappingProfile()
        {
            CreateMap<TiposDeMedicamento, TiposDeMedicamentoResponseDto>();
            CreateMap<TiposDeMedicamentoRequestDto, TiposDeMedicamento>();
        }
    }
}
