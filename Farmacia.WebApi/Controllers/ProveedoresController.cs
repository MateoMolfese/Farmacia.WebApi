using AutoMapper;
using Farmacia.Application;
using Farmacia.Application.Dtos.Proveedor;
using Farmacia.Entities;
using Farmacia.Services;
using Microsoft.AspNetCore.Mvc;

namespace Farmacia.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedoresController : ControllerBase
    {
        private readonly ILogger<ProveedoresController> _logger;
        private readonly IStringService _stringService;
        private readonly IApplication<Proveedor> _proveedor;
        private readonly IMapper _mapper;

        public ProveedoresController(IApplication<Proveedor> proveedor
            , ILogger<ProveedoresController> logger
            , IStringService stringService
            , IMapper mapper)
        {
            _proveedor = proveedor;
            _logger = logger;
            _stringService = stringService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            return Ok(_mapper.Map<IList<ProveedorResponseDto>>(_proveedor.GetAll()));
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> ById(int? Id)
        {
            if (!Id.HasValue)
                return BadRequest();

            Proveedor proveedor = _proveedor.GetById(Id.Value);
            if (proveedor is null)
                return NotFound();

            return Ok(_mapper.Map<ProveedorResponseDto>(proveedor));
        }

        [HttpPost]
        public async Task<IActionResult> Crear(ProveedorRequestDto proveedorRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var proveedor = _mapper.Map<Proveedor>(proveedorRequestDto);
            _proveedor.Save(proveedor);
            return Ok(proveedor.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Editar(int? Id, ProveedorRequestDto proveedorRequestDto)
        {
            if (!Id.HasValue)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest();

            Proveedor proveedorBack = _proveedor.GetById(Id.Value);
            if (proveedorBack is null)
                return NotFound();

            _mapper.Map(proveedorRequestDto, proveedorBack);
            _proveedor.Save(proveedorBack);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Borrar(int? Id)
        {
            if (!Id.HasValue)
                return BadRequest();

            Proveedor proveedorBack = _proveedor.GetById(Id.Value);
            if (proveedorBack is null)
                return NotFound();

            _proveedor.Delete(proveedorBack.Id);
            return Ok();
        }
    }
}
