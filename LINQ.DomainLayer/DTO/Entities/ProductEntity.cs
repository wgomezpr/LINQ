namespace LINQ.DomainLayer.DTO.Entities
{
    public class ProductEntity
    {
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public Int64 SupplierID { get; set; }
        public Int64 CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitsInStock { get; set; }
        public Int64 UnitsOnOrder { get; set; }
        public Int64 ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}