namespace foodDeliveryBack.Model
{
    public class InOffer
    {
        #region Navigation Properties & Keys
            public int OfferId { get; set; }
            public Offer Offer { get; set; }

            public int MenuItemId { get; set; }
            public MenuItem MenuItem { get; set; }

        #endregion

    }
}