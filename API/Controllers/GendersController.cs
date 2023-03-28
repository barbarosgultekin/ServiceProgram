using API.Repository;
using Business.Abstract;
using Business.Models.BaseDTO;
using Core.Aspects.CacheAspect;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class GendersController : ControllerRepository<IGenderService, GenderDto>
    {
        private readonly IGenderService _service;

        public GendersController(IGenderService service) : base(service)
        {
            _service = service;
        }

        [HttpGet]        
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAllAsync();

            return Ok(data);
        }


    }
}
