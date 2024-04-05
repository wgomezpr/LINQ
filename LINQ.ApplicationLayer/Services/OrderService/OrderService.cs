using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using LINQ.DomainLayer.Interfaces;

namespace LINQ.ApplicationLayer.Services.OrderService
{
    public class OrderService : IOrderService
    {
        // Instantiate the interface
        private readonly IOrder _repository;

        public OrderService(IOrder repository)
        {
            _repository = repository;
        }

        public Response<OrderEntity> Get(int OrderID)
        {
            var obj = _repository.Get(OrderID);
            return new Response<OrderEntity>(true, obj, "OK");
        }

        public Response<IList<OrderEntity>> GetAll()
        {
            var obj = _repository.GetAll();
            return new Response<IList<OrderEntity>>(true, obj, "OK");
        }

        public Response<int> Insert(OrderEntity entity)
        {
            var output = _repository.Insert(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Update(OrderEntity entity)
        {
            var output = _repository.Update(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Delete(int OrderID)
        {
            var output = _repository.Delete(OrderID);
            return new Response<int>(true, output, "OK");
        }
    }
}