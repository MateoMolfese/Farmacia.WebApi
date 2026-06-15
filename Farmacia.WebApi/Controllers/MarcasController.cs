using AutoMapper;
using Farmacia.Application;
using Farmacia.Application.Dtos.Marca;
using Farmacia.Entities;
using Farmacia.Services;
using Microsoft.AspNetCore.Mvc;

namespace Farmacia.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasController : ControllerBase
    {
        private readonly ILogger<MarcasController> _logger;
        private readonly IStringService _stringService;
        private readonly IApplication<Marca> _marca;
        private readonly IMapper _mapper;

        public MarcasController(IApplication<Marca> marca
            , ILogger<MarcasController> logger
            , IStringService stringService
            , IMapper mapper)
        {
            _marca = marca;
            _logger = logger;
            _stringService = stringService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            return Ok(_mapper.Map<IList<MarcaResponseDto>>(_marca.GetAll()));
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> ById(int? Id)
        {
            if (!Id.HasValue)
                return BadRequest();

            Marca marca = _marca.GetById(Id.Value);
            if (marca is null)
                return NotFound();

            return Ok(_mapper.Map<MarcaResponseDto>(marca));
        }

        [HttpPost]
        public async Task<IActionResult> Crear(MarcaRequestDto marcaRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var marca = _mapper.Map<Marca>(marcaRequestDto);
            _marca.Save(marca);
            return Ok(marca.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Editar(int? Id, MarcaRequestDto marcaRequestDto)
        {
            if (!Id.HasValue)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest();

            Marca marcaBack = _marca.GetById(Id.Value);
            if (marcaBack is null)
                return NotFound();

            _mapper.Map(marcaRequestDto, marcaBack);
            _marca.Save(marcaBack);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Borrar(int? Id)
        {
            if (!Id.HasValue)
                return BadRequest();

            Marca marcaBack = _marca.GetById(Id.Value);
            if (marcaBack is null)
                return NotFound();

            _marca.Delete(marcaBack.Id);
            return Ok();
        }
    }
}
