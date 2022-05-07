namespace TSDC.Service.Warehouse
{
    public class WarehouseSearchContext 
    {
        public string? Keywords { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public int? Status { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }
    }
}
