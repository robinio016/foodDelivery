using System.Collections.Generic;


namespace foodDeliveryBack.Dto
{
    public class MenuForListDto
    {
        public int MenuItemId { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string Recipe { get; set; } // Recipe -> list of mandatory ingredients which are sperated by ',' : ing1,ing2,ing3
        public decimal Price {get; set; }
        public bool IsActive { get; set; } = true;

        public string MenuCategoryName { get; set; }

        public string RestaurantName { get; set; }

        public List<IngredientToAddDto> IngredientToAddList { get; set; }

    }
}