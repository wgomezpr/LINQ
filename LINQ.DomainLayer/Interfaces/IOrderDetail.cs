using LINQ.DomainLayer.DTO.Entities;

namespace LINQ.DomainLayer.Interfaces
{
    public interface IOrderDetail
    {
        public OrderDetailEntity Get(int OrderID);
        public IList<OrderDetailEntity> GetAll();
        public int Insert(OrderDetailEntity entity);
        public int Update(OrderDetailEntity entity);
        public int Delete(int OrderID);
    }
}