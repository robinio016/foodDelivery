namespace foodDeliveryBack.QueryFilters
{
    public class RestaurantParams
    {
        private const int MaxPageSize = 30;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize 
        {
            get { return pageSize;}
            set { pageSize = (value > MaxPageSize) ? MaxPageSize: value; }
        }
        public string Speciality { get; set; }
        public string OrderBy { get; set; }

    }
}