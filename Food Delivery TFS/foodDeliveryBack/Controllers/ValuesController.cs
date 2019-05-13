using System;
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

namespace fooddeliveryback.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly FoodDeliveryContext _context;
        private IFoodDeliveryRepository _repo;
        private readonly IMapper _mapper;

        public ValuesController(FoodDeliveryContext context,IFoodDeliveryRepository repo,IMapper mapper)
        {
            _context = context;
            _repo = repo;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var foodParam = new FoodMenuParams();
            var pp = await  _repo.GetFoodMenuList(3,foodParam);
            var menuListToReturn = new List<MenuForListDto>();
            foreach (var item in pp)
            {
                var ppDto = _mapper.Map<MenuForListDto>(item);
                menuListToReturn.Add(ppDto);
            }
            
            
            return Ok(new PagedList<MenuForListDto>(menuListToReturn
                        ,pp.Count
                        ,pp.CurrentPage
                        ,pp.PageSize)
                    );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/valuesP
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
