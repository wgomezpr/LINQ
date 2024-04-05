using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;

namespace LINQ.ApplicationLayer.Services.EmployeeService
{
    public interface IEmployeeService
    {
        public Response<EmployeeEntity> Get(int EmployeeID);
        public Response<IList<EmployeeEntity>> GetAll();
        public Response<int> Insert(EmployeeEntity entity);
        public Response<int> Update(EmployeeEntity entity);
        public Response<int> Delete(int EmployeeID);
    }
}