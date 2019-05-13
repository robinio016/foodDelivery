using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using foodDeliveryBack.Helpers;
using foodDeliveryBack.Model;
using foodDeliveryBack.QueryFilters;
using Microsoft.EntityFrameworkCore;

namespace foodDeliveryBack.Data
{
    public class FoodDeliveryRepository : IFoodDeliveryRepository
    {
        private readonly FoodDeliveryContext _context;

        public FoodDeliveryRepository(FoodDeliveryContext context)
        {
            _context= context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add<T>(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove<T>(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>() where T : class
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById<T>(int id) where T : class
        {
           return await _context.Set<T>().FindAsync(id);
        }

        public async Task<PagedList<MenuItem>> GetFoodMenuList(int restaurantId, FoodMenuParams foodMenuParams)
        {
            var foodMenu = _context.MenuItems
                .Include(ita=>ita.IngredientToAddList).ThenInclude(ing => ing.IngredientCatalog)
                .Include(ita=>ita.MenuCategory)
                .Include(ita=>ita.Restaurant)
                .Where(m=>m.RestaurantId == restaurantId)
                .OrderBy(m=>m.MenuCategory).AsQueryable();
            
            if (!string.IsNullOrEmpty(foodMenuParams.Category))
            {
                foodMenu = foodMenu.Where(f =>f.MenuCategory.MenuCategoryName ==foodMenuParams.Category);
            }
            if (foodMenuParams.MinPrice != 0 || foodMenuParams.MaxPrice !=0)
            {
                foodMenu.Where(mit=>mit.Price > foodMenuParams.MinPrice);
                foodMenu.Where(mit=>mit.Price < foodMenuParams.MaxPrice);
            }
            if(string.IsNullOrEmpty(foodMenuParams.OrderBy))
            {
                switch(foodMenuParams.OrderBy)
                {
                    case "a-z":
                        foodMenu = foodMenu.OrderBy(f=>f.ItemName);
                        break;
                    case "z-a":
                        foodMenu = foodMenu.OrderByDescending(f=>f.ItemName);
                        break;

                    default:
                    foodMenu = foodMenu.OrderBy(f=>f.Price);
                        break;
                }
            }     

           return await PagedList<MenuItem>
                    .CreateAsync(foodMenu,foodMenuParams.PageNumber,foodMenuParams.PageSize);

        }

        public async Task<IEnumerable<IngredientToAdd>> GetIngredientsForMenu(int menuItemId)
        {
            return await  _context.IngredientToAdds
                    .Include(ing => ing.IngredientCatalog)
                    .Where(ing => ing.MenuItemId == menuItemId)
                    .OrderBy(ing =>ing.CanSelectMultiple).ToListAsync();   
        }

        public Task<PagedList<Offer>> GetOfferList(OfferParams offerParams)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedList<Restaurant>> GetRestaurantList(RestaurantParams restaurantParams)
        {
            var restaurant  = _context.Restaurants.AsQueryable();
            if(string.IsNullOrEmpty(restaurantParams.OrderBy))
            {
                switch(restaurantParams.OrderBy)
                {
                    case "a-z":
                    restaurant = restaurant.OrderBy(res => res.RestaurantName);
                    break;
                    case "z-a":
                    restaurant = restaurant.OrderByDescending(res => res.RestaurantName);
                    break;

                    default:  // order by most reviewed
                    restaurant = restaurant.OrderByDescending(res => res.CustomerRestaurantReviewList.Count);
                    break;

                }
            }
            return await PagedList<Restaurant>
                    .CreateAsync(restaurant,restaurantParams.PageNumber,restaurantParams.PageSize);
            
        }
        public async Task<PagedList<Restaurant>> GetRestaurantListByLocation(int locationId, RestaurantParams restaurantParams)
        {
            var restaurant  = _context.Restaurants.Where(res => res.LocationId == locationId).AsQueryable();
            if(string.IsNullOrEmpty(restaurantParams.OrderBy))
            {
                switch(restaurantParams.OrderBy)
                {
                    case "a-z":
                    restaurant = restaurant.OrderBy(res => res.RestaurantName);
                    break;
                    case "z-a":
                    restaurant = restaurant.OrderByDescending(res => res.RestaurantName);
                    break;

                    default:  // order by most reviewed
                    restaurant = restaurant.OrderByDescending(res => res.CustomerRestaurantReviewList.Count);
                    break;

                }
            }
            return await PagedList<Restaurant>
                    .CreateAsync(restaurant,restaurantParams.PageNumber,restaurantParams.PageSize);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<T>> SearchFor<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }
    }
}