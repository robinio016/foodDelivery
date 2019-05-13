using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using foodDeliveryBack.Data;
using foodDeliveryBack.Dto;
using foodDeliveryBack.Helpers;
using foodDeliveryBack.Model;
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
        public async Task<IActionResult> GetRestaurantByRegion (int locationId)
        {
            var restoParams = new RestaurantParams();
            var pagedRestaurant = await _repo.GetRestaurantListByLocation(locationId,restoParams);

            if (pagedRestaurant == null)
            {
                return BadRequest("Server Error 500");   
            }

            List<RestaurantForListDto> restaurantsDto = new List<RestaurantForListDto>();
            foreach(var resto in pagedRestaurant)
            {
                var restaurantDto = _mapper.Map<RestaurantForListDto>(resto);
                restaurantDto.Rating = CalculateRestaurantRate(resto);
                restaurantDto.RatingCount = resto.CustomerRestaurantReviewList.Count;

                restaurantsDto.Add(restaurantDto);
            }

             //var restaurantsDto = _mapper.Map<IEnumerable<RestaurantForListDto>>(pagedRestaurant);


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

        private double CalculateRestaurantRate(Restaurant resto)
        {
            int totalRate = resto.CustomerRestaurantReviewList.Count;

            int rate = resto.CustomerRestaurantReviewList.Sum(custRate => custRate.rating);
            return (double) (rate /(double)totalRate);
        }

    }
}