using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using foodDeliveryBack.Helpers;
using foodDeliveryBack.Model;
using foodDeliveryBack.QueryFilters;

namespace foodDeliveryBack.Data
{
    public interface IFoodDeliveryRepository
    {
         void Add<T>(T entity) where T: class;
         Task<IEnumerable<T>> GetAllAsync<T>() where T : class;
         Task<T> GetById<T>(int id) where T : class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<T>> SearchFor<T> (Expression<Func<T, bool>> predicate) where T: class;
        Task<PagedList<Restaurant>> GetRestaurantList(RestaurantParams restaurantParams);
        Task<PagedList<Restaurant>> GetRestaurantListByLocation(int locationId, RestaurantParams restaurantParams);
        Task<PagedList<MenuItem>> GetFoodMenuList(int restaurantId, FoodMenuParams foodMenuParams);
        //Task<MenuItem> GetFoodMenu(int id);
        Task<IEnumerable<IngredientToAdd>> GetIngredientsForMenu (int menuItemId);
        Task<PagedList<Offer>> GetOfferList(OfferParams offerParams);
        
    }
}