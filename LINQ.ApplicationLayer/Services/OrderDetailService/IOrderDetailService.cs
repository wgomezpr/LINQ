using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;

namespace LINQ.ApplicationLayer.Services.OrderDetailService
{
    public interface IOrderDetailService
    {
        public Response<OrderDetailEntity> Get(int OrderID);
        public Response<IList<OrderDetailEntity>> GetAll();
        public Response<int> Insert(OrderDetailEntity entity);
        public Response<int> Update(OrderDetailEntity entity);
        public Response<int> Delete(int OrderID);
    }
}