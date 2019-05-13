namespace foodDeliveryBack.Model
{
    public class InOrderIngredientToAdd
    {
        #region Navigation Properties & Keys
        
            public int InOrderId { get; set; }
            public InOrder InOrder { get; set; }
            
            public int IngredientToAddId { get; set; }
            public IngredientToAdd IngredientToAdd { get; set;}

        #endregion
        

    }
}