using AutoMapper;
using Farmacia.Application;
using Farmacia.Application.Dtos.Sucursal;
using Farmacia.Entities;
using Farmacia.Services;
using Microsoft.AspNetCore.Mvc;

namespace Farmacia.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SucursalesController : ControllerBase
    {
        private readonly ILogger<SucursalesController> _logger;
        private readonly IStringService _stringService;
        private readonly IApplication<Sucursal> _sucursal;
        private readonly IMapper _mapper;

        public SucursalesController(IApplication<Sucursal> sucursal
            , ILogger<SucursalesController> logger
            , IStringService stringService
            , IMapper mapper)
        {
            _sucursal = sucursal;
            _logger = logger;
            _stringService = stringService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            return Ok(_mapper.Map<IList<SucursalResponseDto>>(_sucursal.GetAll()));
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> ById(int? Id)
        {
            if (!Id.HasValue)
                return BadRequest();

            Sucursal sucursal = _sucursal.GetById(Id.Value);
            if (sucursal is null)
                return NotFound();

            return Ok(_mapper.Map<SucursalResponseDto>(sucursal));
        }

        [HttpPost]
        public async Task<IActionResult> Crear(SucursalRequestDto sucursalRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var sucursal = _mapper.Map<Sucursal>(sucursalRequestDto);
            _sucursal.Save(sucursal);
            return Ok(sucursal.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Editar(int? Id, SucursalRequestDto sucursalRequestDto)
        {
            if (!Id.HasValue)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest();

            Sucursal sucursalBack = _sucursal.GetById(Id.Value);
            if (sucursalBack is null)
                return NotFound();

            _mapper.Map(sucursalRequestDto, sucursalBack);
            _sucursal.Save(sucursalBack);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Borrar(int? Id)
        {
            if (!Id.HasValue)
                return BadRequest();

            Sucursal sucursalBack = _sucursal.GetById(Id.Value);
            if (sucursalBack is null)
                return NotFound();

            _sucursal.Delete(sucursalBack.Id);
            return Ok();
        }
    }
}
