using FIAP.CP2.Application.DTOs;
using FIAP.CP2.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FIAP.CP2.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfissaoFuturaController : ControllerBase
    {
        private readonly IProfissaoFuturaAppService _service;

        public ProfissaoFuturaController(IProfissaoFuturaAppService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _service.ObterTodos();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _service.ObterPorId(id);
            if (result == null)
                return NotFound("Profissão futura não encontrada.");

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProfissaoFuturaDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _service.Criar(dto);
            return CreatedAtAction(nameof(GetById), new { id = dto.Id }, dto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ProfissaoFuturaDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var sucesso = _service.Atualizar(id, dto);

            if (!sucesso)
                return NotFound("Profissão futura não encontrada.");

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var sucesso = _service.Deletar(id);

            if (!sucesso)
                return NotFound("Profissão futura não encontrada.");

            return NoContent();
        }
    }
}
