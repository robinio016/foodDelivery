using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using foodDeliveryBack.Data;
using foodDeliveryBack.Dto;
using foodDeliveryBack.Helpers;
using foodDeliveryBack.QueryFilters;
using Microsoft.AspNetCore.Mvc;

namespace foodDeliveryBack.Controllers
{
    [Route("api/{locationId}/[controller]")]
    [ApiController]
    public class RestaurantController: ControllerBase
    {
        public readonly IFoodDeliveryRepository _repo;

        private readonly IMapper _mapper;

        public RestaurantController(IFoodDeliveryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]  // api/locationId/restaurant
        public async Task<IActionResult> GetAllRestaurant (int locationId)
        {
            var restoParams = new RestaurantParams();
            var pagedRestaurant = await _repo.GetRestaurantListByLocation(locationId,restoParams);

            if (pagedRestaurant == null)
            {
                return BadRequest("Server Error 500");   
            }
             var restaurantsDto = _mapper.Map<IEnumerable<RestaurantForListDto>>(pagedRestaurant);

             return Ok(restaurantsDto);
        }

        [HttpGet("{restaurantId}")]
        public async Task<IActionResult> GetRestaurantMenu(int locationId, int restaurantId)
        {
            var menuParams = new FoodMenuParams();
            var menusFromRepo = await _repo.GetFoodMenuList(restaurantId,menuParams);
            if (menusFromRepo == null)
            {
                return BadRequest("Server Error 500");   
            }
             var menusDto = _mapper.Map<IEnumerable<MenuForListDto>>(menusFromRepo);

             return Ok(menusDto);

        }
    }
}