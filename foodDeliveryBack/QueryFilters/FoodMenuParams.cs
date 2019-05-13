namespace foodDeliveryBack.QueryFilters
{
    public class FoodMenuParams
    {
        private const int MaxPageSize = 30;
        public int PageNumber { get; set; }=1;
        private int pageSize = 10;
        public int PageSize 
        {
            get { return pageSize;}
            set { pageSize = (value > MaxPageSize) ? MaxPageSize: value; }
        }
        public string Category { get; set; }
        public string OrderBy { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        
    }
}