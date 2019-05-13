using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace foodDeliveryBack.Model
{
    public class OrderPlaced
    {
        public int OrderPlacedId { get; set; }
        public DateTime OrderTime { get; set; }
        [MaxLength(50)]
        public string EstimatedDeliveryTime { get; set; }
        public DateTime? ActualDeliveryTime { get; set; }
        [Required]
        [StringLength(200)]
        public string DeliveryAddress { get; set; }
        [StringLength(200)]
        public string Comment { get; set; }
        public decimal Price { get; set; }
        public decimal? DeliveryFees { get; set; }
        public decimal? Discount { get; set; }
        public decimal FinalPrice { get; set; }

        #region Navigation properties and keys

            public int CustomerId { get; set; }
            public Customer Customer { get; set; }

            public List<InOrder> InOrderList { get; set; }
            public List<OrderComment> OrderCommentList { get; set; }
            public List<OrderStatus> OrderStatusList { get; set; }

        #endregion


    }
}