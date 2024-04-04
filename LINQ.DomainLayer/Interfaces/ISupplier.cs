using LINQ.DomainLayer.DTO.Entities;

namespace LINQ.DomainLayer.Interfaces
{
    public interface ISupplier
    {
        public SupplierEntity Get(int SupplierID);
        public IList<SupplierEntity> GetAll();
        public int Insert(SupplierEntity entity);
        public int Update(SupplierEntity entity);
        public int Delete(int SupplierID);
    }
}