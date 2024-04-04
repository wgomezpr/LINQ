using LINQ.DomainLayer.DTO.Entities;

namespace LINQ.DomainLayer.Interfaces
{
    public interface IOrder
    {
        public OrderEntity Get(int OrderID);
        public IList<OrderEntity> GetAll();
        public int Insert(OrderEntity entity);
        public int Update(OrderEntity entity);
        public int Delete(int OrderID);
    }
}