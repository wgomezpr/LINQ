using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;

namespace LINQ.ApplicationLayer.Services.CustomerService
{
    public interface ICustomerService
    {
        public Response<CustomerEntity> Get(int CustomerID);
        public Response<IList<CustomerEntity>> GetAll();
        public Response<int> Insert(CustomerEntity entity);
        public Response<int> Update(CustomerEntity entity);
        public Response<int> Delete(int CustomerID);
    }
}