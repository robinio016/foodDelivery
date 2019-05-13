using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace foodDeliveryBack.Model
{
    public class IngredientCatalog
    {
        public int IngredientCatalogId { get; set; }
        [MaxLength(200)]
        public string Ingredient {get; set; }
        public string Description { get; set; }

        #region Navigation And Foreign keys
            public List<IngredientToAdd> IngredientToAddList { get; set; }
            
        #endregion

    }
}