using FIAP.CP2.Application.Interfaces;
using FIAP.CP2.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FIAP.CP2.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoController : ControllerBase
    {
        private readonly ITipoApplicationService _service;

        public TipoController(ITipoApplicationService service)
        {
            _service = service;
        }

        // GET api/tipo
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tipos = await _service.GetAllAsync();
            return Ok(tipos);
        }

        // GET api/tipo/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tipo = await _service.GetByIdAsync(id);

            if (tipo == null)
                return NotFound();

            return Ok(tipo);
        }

        // POST api/tipo
        [HttpPost]
        public async Task<IActionResult> Create(TipoDTO dto)
        {
            var created = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        // PUT api/tipo/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, TipoDTO dto)
        {
            var updated = await _service.UpdateAsync(id, dto);

            if (updated == null)
                return NotFound();

            return Ok(updated);
        }

        // DELETE api/tipo/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);

            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}
