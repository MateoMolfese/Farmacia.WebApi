using AutoMapper;
using Farmacia.Application;
using Farmacia.Application.Dtos.Cliente;
using Farmacia.Entities;
using Farmacia.Services;
using Microsoft.AspNetCore.Mvc;

namespace Farmacia.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ILogger<ClientesController> _logger;
        private readonly IStringService _stringService;
        private readonly IApplication<Cliente> _cliente;
        private readonly IMapper _mapper;

        public ClientesController(IApplication<Cliente> cliente
            , ILogger<ClientesController> logger
            , IStringService stringService
            , IMapper mapper)
        {
            _cliente = cliente;
            _logger = logger;
            _stringService = stringService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            return Ok(_mapper.Map<IList<ClienteResponseDto>>(_cliente.GetAll()));
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> ById(int? Id)
        {
            if (!Id.HasValue)
                return BadRequest();

            Cliente cliente = _cliente.GetById(Id.Value);
            if (cliente is null)
                return NotFound();

            return Ok(_mapper.Map<ClienteResponseDto>(cliente));
        }

        [HttpPost]
        public async Task<IActionResult> Crear(ClienteRequestDto clienteRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var cliente = _mapper.Map<Cliente>(clienteRequestDto);
            _cliente.Save(cliente);
            return Ok(cliente.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Editar(int? Id, ClienteRequestDto clienteRequestDto)
        {
            if (!Id.HasValue)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest();

            Cliente clienteBack = _cliente.GetById(Id.Value);
            if (clienteBack is null)
                return NotFound();

            _mapper.Map(clienteRequestDto, clienteBack);
            _cliente.Save(clienteBack);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Borrar(int? Id)
        {
            if (!Id.HasValue)
                return BadRequest();

            Cliente clienteBack = _cliente.GetById(Id.Value);
            if (clienteBack is null)
                return NotFound();

            _cliente.Delete(clienteBack.Id);
            return Ok();
        }
    }
}
