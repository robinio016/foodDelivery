using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using foodDeliveryBack.Data;
using foodDeliveryBack.Dto;
using foodDeliveryBack.Model;
using Microsoft.AspNetCore.Mvc;

namespace foodDeliveryBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IFoodDeliveryRepository _repo;
        private readonly IMapper _mapper;

        public HomeController(IFoodDeliveryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllLocations()
        {
            var locationFromRepo = await _repo.GetAllAsync<Location>();

            var locationDto = _mapper.Map<IEnumerable<LocationDto>>(locationFromRepo);

            if(locationDto != null)
                return Ok(locationDto);
            
            return BadRequest("server error");
        }   
    }
}