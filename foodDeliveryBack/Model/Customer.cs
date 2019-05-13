using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace foodDeliveryBack.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(200)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(10)]
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? TimeJoined { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(20)]
        public string Password { get; set; }
        [MaxLength(200)]
        public string MainPhoto { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }
        public int? PhoneNumber { get; set; }

        #region define Navigation Properties and Foreign Key
            public List<OrderPlaced> OrderPlacedList { get; set; }
            public List<CustomerRestaurantReview> CustomerRestaurantReviewList { get ; set; }
            public List<CustomerMenuReview> CustomerMenuReviewList { get ; set; }

        #endregion
    }
}