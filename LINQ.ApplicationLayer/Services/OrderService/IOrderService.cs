using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;

namespace LINQ.ApplicationLayer.Services.OrderService
{
    public interface IOrderService
    {
        public Response<OrderEntity> Get(int OrderID);
        public Response<IList<OrderEntity>> GetAll();
        public Response<int> Insert(OrderEntity entity);
        public Response<int> Update(OrderEntity entity);
        public Response<int> Delete(int OrderID);
    }
}