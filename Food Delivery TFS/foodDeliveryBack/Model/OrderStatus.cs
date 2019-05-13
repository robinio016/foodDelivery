namespace foodDeliveryBack.Model
{
    public class OrderStatus
    {
        #region Navigation properties and keys
            public int OrderPlacedId { get; set; }
            public OrderPlaced OrderPlaced { get; set; }

            public int StatusCatalogId { get; set; }
            public StatusCatalog StatusCatalog { get; set; }
            
        #endregion

        
    }
}