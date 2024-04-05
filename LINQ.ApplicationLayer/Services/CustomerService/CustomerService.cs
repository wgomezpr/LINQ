using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using LINQ.DomainLayer.Interfaces;

namespace LINQ.ApplicationLayer.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
        // Instantiate the interface
        private readonly ICustomer _repository;

        public CustomerService(ICustomer repository)
        {
            _repository = repository;
        }

        public Response<CustomerEntity> Get(int CustomerID)
        {
            var obj = _repository.Get(CustomerID);
            return new Response<CustomerEntity>(true, obj, "OK");
        }

        public Response<IList<CustomerEntity>> GetAll()
        {
            var obj = _repository.GetAll();
            return new Response<IList<CustomerEntity>>(true, obj, "OK");
        }

        public Response<int> Insert(CustomerEntity entity)
        {
            var output = _repository.Insert(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Update(CustomerEntity entity)
        {
            var output = _repository.Update(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Delete(int CustomerID)
        {
            var output = _repository.Delete(CustomerID);
            return new Response<int>(true, output, "OK");
        }
    }
}