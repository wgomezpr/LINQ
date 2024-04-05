using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using LINQ.DomainLayer.Interfaces;

namespace LINQ.ApplicationLayer.Services.OrderDetailService
{
    public class OrderDetailService : IOrderDetailService
    {
        // Instantiate the interface
        private readonly IOrderDetail _repository;

        public OrderDetailService(IOrderDetail repository)
        {
            _repository = repository;
        }

        public Response<OrderDetailEntity> Get(int OrderID)
        {
            var obj = _repository.Get(OrderID);
            return new Response<OrderDetailEntity>(true, obj, "OK");
        }

        public Response<IList<OrderDetailEntity>> GetAll()
        {
            var obj = _repository.GetAll();
            return new Response<IList<OrderDetailEntity>>(true, obj, "OK");
        }

        public Response<int> Insert(OrderDetailEntity entity)
        {
            var output = _repository.Insert(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Update(OrderDetailEntity entity)
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