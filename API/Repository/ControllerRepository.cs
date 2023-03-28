using System.Threading.Tasks;
using Business.Repositories;
using Core.Signatures;
using Microsoft.AspNetCore.Mvc;

namespace API.Repository
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerRepository<TService, TDto> : ControllerBase
    where TDto : class, IBaseDto, new()
    where TService : IServiceRepository<TDto>
    {
        private readonly TService _service;

        public ControllerRepository(TService service)
        {
            _service = service;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var data = await _service.Get(id);
            
            return Ok(data);
        }
       
        [HttpPost]      
        public virtual async Task<IActionResult> Create([FromBody] TDto dto)
        {
            var id = await _service.Insert(dto);
            return CreatedAtAction(null, id);
        }

        [HttpPut("{id:int}")]       
        public virtual async Task<IActionResult> Update([FromRoute] int id, [FromBody] TDto dto)
        {
            await _service.Update(id, dto);
            return StatusCode(204);
        }

        [HttpDelete("{id:int}")]      
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _service.Delete(id);
            return StatusCode(204);
        }

    }
}