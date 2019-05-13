using System.ComponentModel.DataAnnotations;

namespace foodDeliveryBack.Model
{
    public class CustomerRestaurantReview
    {
        #region Navigation Property And Combined Primary Key
            public int CustomerId { get; set; }
            public Customer Customer { get; set; }

            public int RestaurantId { get; set; }
            public Restaurant Restaurant { get; set; }
        #endregion
       
         [Required]
        //add constraint to insert only 0 <= value <= 5 -->custom filter
        public int rating { get; set; }  
        public string Description { get; set; }
    }
}