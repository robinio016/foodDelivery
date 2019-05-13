using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace foodDeliveryBack.Model
{
    public class StatusCatalog
    {
        public int StatusCatalogId { get; set; }
        [Required]
        [MaxLength(50)]
        public string StatusName { get; set; }

        #region Navigation properties and keys
            public List<OrderStatus> OrderStatusList { get; set; }

        #endregion
    }
}