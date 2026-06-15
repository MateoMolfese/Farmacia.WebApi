using Farmacia.Application;
using Farmacia.Entities;
using Farmacia.Services;
using Microsoft.AspNetCore.Mvc;

namespace Farmacia.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaboratoriosController : ControllerBase
    {
                private readonly ILogger<Laboratorio> _logger;
        private readonly IStringService _stringService;
        private readonly IApplication<Laboratorio> _laboratorio;
        public LaboratoriosController(IApplication<Laboratorio> laboratorio
            , ILogger<Laboratorio> logger
            , IStringService stringService)
        {
            _laboratorio = laboratorio;
            _logger = logger;
            _stringService = stringService;
        }
        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            return Ok(_laboratorio.GetAll());
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> ById(int? Id)
        {
            if (!Id.HasValue)
            {
                return BadRequest();
            }
            Laboratorio laboratorio = _laboratorio.GetById(Id.Value);
            if (laboratorio is null)
            {
                return NotFound();
            }
            return Ok(laboratorio);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Laboratorio laboratorio)
        {
            if (!ModelState.IsValid)
            { return BadRequest(); }
            _laboratorio.Save(laboratorio);
            return Ok(laboratorio.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Editar(int? Id, Laboratorio laboratorio)
        {
            if (!Id.HasValue)
            { return BadRequest(); }
            if (!ModelState.IsValid)
            { return BadRequest(); }
            Laboratorio laboratorioBack = _laboratorio.GetById(Id.Value);
            if (laboratorioBack is null)
            { return NotFound(); }
            laboratorioBack.Nombre = laboratorio.Nombre;
            _laboratorio.Save(laboratorioBack);
            return Ok(laboratorioBack   );
        }

        [HttpDelete]
        public async Task<IActionResult> Borrar(int? Id)
        {
            if (!Id.HasValue)
            { return BadRequest(); }
            if (!ModelState.IsValid)
            { return BadRequest(); }
            Laboratorio laboratorioBack = _laboratorio.GetById(Id.Value);
            if (laboratorioBack is null)
            { return NotFound(); }
            _laboratorio.Delete(laboratorioBack.Id);
            return Ok();
        }

    }
}
