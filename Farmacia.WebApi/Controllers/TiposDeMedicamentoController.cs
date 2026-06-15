using AutoMapper;
using Farmacia.Application;
using Farmacia.Application.Dtos.TiposDeMedicamento;
using Farmacia.Entities;
using Farmacia.Services;
using Microsoft.AspNetCore.Mvc;

namespace Farmacia.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposDeMedicamentoController : ControllerBase
    {
        private readonly ILogger<TiposDeMedicamentoController> _logger;
        private readonly IStringService _stringService;
        private readonly IApplication<TiposDeMedicamento> _tiposDeMedicamento;
        private readonly IMapper _mapper;

        public TiposDeMedicamentoController(IApplication<TiposDeMedicamento> tiposDeMedicamento
            , ILogger<TiposDeMedicamentoController> logger
            , IStringService stringService
            , IMapper mapper)
        {
            _tiposDeMedicamento = tiposDeMedicamento;
            _logger = logger;
            _stringService = stringService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            return Ok(_mapper.Map<IList<TiposDeMedicamentoResponseDto>>(_tiposDeMedicamento.GetAll()));
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> ById(int? Id)
        {
            if (!Id.HasValue)
                return BadRequest();

            TiposDeMedicamento tipo = _tiposDeMedicamento.GetById(Id.Value);
            if (tipo is null)
                return NotFound();

            return Ok(_mapper.Map<TiposDeMedicamentoResponseDto>(tipo));
        }

        [HttpPost]
        public async Task<IActionResult> Crear(TiposDeMedicamentoRequestDto tipoRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var tipo = _mapper.Map<TiposDeMedicamento>(tipoRequestDto);
            _tiposDeMedicamento.Save(tipo);
            return Ok(tipo.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Editar(int? Id, TiposDeMedicamentoRequestDto tipoRequestDto)
        {
            if (!Id.HasValue)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest();

            TiposDeMedicamento tipoBack = _tiposDeMedicamento.GetById(Id.Value);
            if (tipoBack is null)
                return NotFound();

            _mapper.Map(tipoRequestDto, tipoBack);
            _tiposDeMedicamento.Save(tipoBack);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Borrar(int? Id)
        {
            if (!Id.HasValue)
                return BadRequest();

            TiposDeMedicamento tipoBack = _tiposDeMedicamento.GetById(Id.Value);
            if (tipoBack is null)
                return NotFound();

            _tiposDeMedicamento.Delete(tipoBack.Id);
            return Ok();
        }
    }
}
