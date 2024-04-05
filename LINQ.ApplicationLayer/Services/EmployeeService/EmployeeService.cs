using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using LINQ.DomainLayer.Interfaces;

namespace LINQ.ApplicationLayer.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        // Instantiate the interface
        private readonly IEmployee _repository;

        public EmployeeService(IEmployee repository)
        {
            _repository = repository;
        }

        public Response<EmployeeEntity> Get(int EmployeeID)
        {
            var obj = _repository.Get(EmployeeID);
            return new Response<EmployeeEntity>(true, obj, "OK");
        }

        public Response<IList<EmployeeEntity>> GetAll()
        {
            var obj = _repository.GetAll();
            return new Response<IList<EmployeeEntity>>(true, obj, "OK");
        }

        public Response<int> Insert(EmployeeEntity entity)
        {
            var output = _repository.Insert(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Update(EmployeeEntity entity)
        {
            var output = _repository.Update(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Delete(int EmployeeID)
        {
            var output = _repository.Delete(EmployeeID);
            return new Response<int>(true, output, "OK");
        }
    }
}