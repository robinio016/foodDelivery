using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace foodDeliveryBack.Model
{
    public class Offer
    {
        public int OfferId { get; set; }
        public DateTime DateActiveFrom { get; set; }
        public DateTime TimeActiveFrom { get; set; }
        public DateTime DateActiveTo { get; set; }
        public DateTime TimeActiveTo { get; set; }
        [MaxLength(20)]
        public string OfferType {get; set; } ="promotion"; //offerType: Promotion or Coupon
        public decimal? OfferPrice { get; set; }

        [MaxLength(50)]
        public string CouponCode { get; set; }
        public decimal? CouponValue { get; set; }

        #region Navigation Properties & Keys
            public List<InOffer> InOfferList { get; set; }
            
        #endregion
        
    }
}