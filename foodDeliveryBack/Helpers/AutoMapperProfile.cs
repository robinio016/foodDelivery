using AutoMapper;
using foodDeliveryBack.Dto;
using foodDeliveryBack.Model;

namespace foodDeliveryBack.Helpers
{
    public class AutoMapperProfile : Profile
    {
       public AutoMapperProfile()
       {
            //CreateMap<PagedList<MenuItem>,PagedList<MenuForListDto>>();
            CreateMap<Location,LocationDto>();
            CreateMap<Restaurant,RestaurantForListDto>();

            CreateMap<MenuItem,MenuForListDto>()
                .ForMember(dest => dest.MenuCategoryName, opt => {
                    opt.MapFrom(src => src.MenuCategory.MenuCategoryName);
                })
                .ForMember(dest => dest.RestaurantName, opt =>{
                    opt.MapFrom(src => src.Restaurant.RestaurantName);
                });
                // .ForMember(dest => dest.IngredientToAddList, opt => {
                //     opt.MapFrom(src => src.IngredientToAddList.)
                // })
                CreateMap<IngredientToAdd,IngredientToAddDto>()
                    .ForMember(dest => dest.Ingredient, opt =>{
                        opt.MapFrom(src => src.IngredientCatalog.Ingredient);
                    });
       }
    }
}