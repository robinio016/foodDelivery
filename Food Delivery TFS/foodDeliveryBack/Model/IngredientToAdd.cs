

using System.Collections.Generic;

namespace foodDeliveryBack.Model
{
    public class IngredientToAdd
    {
        public int IngredientToAddId { get; set; }
        public decimal? Price { get ; set; }
        public bool CanSelectMultiple { get; set; } = false;  // create checkbox if true else radioButton

        #region Navigation and Keys
             public int IngredientCatalogId { get; set; }
            public IngredientCatalog IngredientCatalog { get; set; }
            
            public int MenuItemId { get; set; }
            public MenuItem MenuItem { get; set; }

            public List<InOrder> InOrderList { get; set; }

            public List<InOrderIngredientToAdd> InOrderIngredientToAddList { get; set;}

        #endregion
       
    }
}