namespace foodDeliveryBack.Dto
{
    public class RestaurantForListDto
    {
        public string RestaurantName { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int PhoneNumber { get; set; }
        public string PhotoUrl { get; set; }
        public string StartHour { get; set; }
        public string CloseHour { get; set; }  
        public string DaysOff { get ; set; }
    }
}