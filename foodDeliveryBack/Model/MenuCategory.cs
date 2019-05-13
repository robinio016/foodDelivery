using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace foodDeliveryBack.Model
{
    public class MenuCategory
    {
        public int MenuCategoryId { get; set; }
        [Required]
        [MaxLength(200)]
        public string MenuCategoryName { get; set; }

        #region Navigation Properties & Keys
        public List<MenuItem> MenuItemList { get; set; }
        
        #endregion
    }
}