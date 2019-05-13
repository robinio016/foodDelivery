using System.Collections.Generic;

namespace foodDeliveryBack.Model
{
    public class InOrder
    {
        public int InOrderId { get; set; }
        public int Quantity { get; set; }
        public decimal? ItemPrice { get; set; }
        public string Comment { get; set; }

        #region Navigation Properties & keys

            public int OrderPlacedId {get; set; }
            public OrderPlaced OrderPlaced { get; set; } 
            
            public int? MenuItemId {get; set; }
            public MenuItem MenuItem { get; set; }
            
            public List<InOrderIngredientToAdd> InOrderIngredientToAddList { get; set;}
            

        #endregion

    }
}