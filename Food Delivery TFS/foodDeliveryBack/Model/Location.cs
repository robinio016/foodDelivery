using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace foodDeliveryBack.Model
{
    public class Location
    {
        public int LocationId { get; set; }
        [MaxLength(200)]
        public string CountryName { get; set; }
        [MaxLength(200)]
        public string CityName { get; set; }
        [MaxLength(200)]
        public string RegionName { get; set; }
        public int? ZipCode { get; set; }

        #region Navigation Properties & Keys
            public List<Restaurant> RestaurantList { get; set; } 

        #endregion

    }
}