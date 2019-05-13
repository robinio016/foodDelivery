namespace foodDeliveryBack.QueryFilters
{
    public class OfferParams
    {
        private const int MaxPageSize = 30;
        public int PageNumber { get; set; }=1;
        private int pageSize = 10;
        public int PageSize 
        {
            get { return pageSize;}
            set { pageSize = (value > MaxPageSize) ? MaxPageSize: value; }
        }
        public string Type { get; set; }
        public decimal MinValue { get; set; }
        public decimal MaxValue { get; set; }
    }
}