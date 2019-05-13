using System.ComponentModel.DataAnnotations;

namespace foodDeliveryBack.Model
{
    public class OrderComment
    {
        public int OrderCommentId { get; set; }
        [Required]
        public string Comment { get; set; }
        public bool? IsComplaint { get; set; }
        public bool? IsPraise { get; set; }

        #region Navigation properties and keys
            public int OrderPlacedId { get; set; }
            public OrderPlaced OrderPlaced { get; set; }
            
        #endregion

    }
}