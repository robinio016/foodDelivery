namespace foodDeliveryBack.Dto
{
    public class IngredientToAddDto
    {
        public string Ingredient { get; set; }
        public decimal? Price { get ; set; }
        public bool CanSelectMultiple { get; set; }
    }
}