using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace foodDeliveryBack.Model
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        [Required]
        [MaxLength(200)]
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string Recipe { get; set; } // Recipe -> list of mandatory ingredients which are sperated by ',' : ing1,ing2,ing3
        public decimal Price {get; set; }
        public bool IsActive { get; set; } = true;

        //define many to many relationShip between MenuItem and Customer for review
        #region Navigation Properties and Keys

            public int MenuCategoryId { get; set; } 
            public MenuCategory MenuCategory { get; set; }
            
            public int RestaurantId { get; set; } 
            public Restaurant Restaurant { get; set; }

            public List<InOrder> InOrderList { get; set; } 
            
            public List<IngredientToAdd> IngredientToAddList { get; set; }
            public List<CustomerMenuReview> CustomerMenuReviewList { get ; set; }
            public List<InOffer> InOfferList { get; set; }

        #endregion
        
    }
}