using System.ComponentModel.DataAnnotations;

namespace foodDeliveryBack.Model
{
    public class CustomerMenuReview
    {
        
        #region Navigation Property And Combined Primary Key

            public int CustomerId { get; set; }
            public Customer Customer { get; set; }

            public int MenuItemId { get; set; }
            public MenuItem MenuItem { get; set; }

        #endregion

        [Required]
        //add constraint to insert only 0 <= value <= 5 -->custom filter
        public int Rating { get; set; } // rating in [0..5]
        public string Description { get; set; }
    }
}