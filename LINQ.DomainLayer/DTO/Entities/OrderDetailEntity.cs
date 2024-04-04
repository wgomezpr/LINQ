namespace LINQ.DomainLayer.DTO.Entities
{
    public class OrderDetailEntity
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public long Quantity { get; set; }
        public decimal Discount { get; set; }
    }
}