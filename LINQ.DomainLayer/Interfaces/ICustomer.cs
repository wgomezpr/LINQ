using LINQ.DomainLayer.DTO.Entities;

namespace LINQ.DomainLayer.Interfaces
{
    public interface ICustomer
    {
        public CustomerEntity Get(int CustomerID);
        public IList<CustomerEntity> GetAll();
        public int Insert(CustomerEntity entity);
        public int Update(CustomerEntity entity);
        public int Delete(int CustomerID);
    }
}