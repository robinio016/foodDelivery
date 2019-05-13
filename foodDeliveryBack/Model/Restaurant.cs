using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace foodDeliveryBack.Model
{
    public class Restaurant
    {
         public int RestaurantId { get; set; }
         [Required]
         [StringLength(200)]
        public string RestaurantName { get; set; }
         [Required]
         [StringLength(200)]
        public string Address { get; set; }
        public string Description { get; set; }
        public int PhoneNumber { get; set; }
        public string PhotoUrl { get; set; }
        public string StartHour { get; set; } // EX 08:00
        public string CloseHour { get; set; }  //EX 18:00
        public string DaysOff { get ; set; } // sunday,saturday --> use ',' as string separator

        #region Navigation properties and keys
            public int LocationId { get; set; }
            public Location Location { get; set; }

            public List<CustomerRestaurantReview> CustomerRestaurantReviewList { get; set; }
            public List<MenuItem> MenuItemList { get; set; }

        #endregion

    }
}