using LINQ.DomainLayer.DTO.Entities;

namespace LINQ.DomainLayer.Interfaces
{
    public interface IProduct
    {
        public ProductEntity Get(int ProductID);
        public ProductEntity Get(string ProductName, int SupplierID, int CategoryID);
        public IList<ProductEntity> GetAll();
        public int Insert(ProductEntity entity);
        public int Update(ProductEntity entity);
        public int Delete(int ProductID);
    }
}