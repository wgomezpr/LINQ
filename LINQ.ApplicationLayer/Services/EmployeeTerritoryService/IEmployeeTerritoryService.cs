using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;

namespace LINQ.ApplicationLayer.Services.EmployeeTerritoryService
{
    public interface IEmployeeTerritoryService
    {
        public Response<EmployeeTerritoryEntity> Get(int EmployeeID);
        public Response<IList<EmployeeTerritoryEntity>> GetAll();
        public Response<int> Insert(EmployeeTerritoryEntity entity);
        public Response<int> Update(EmployeeTerritoryEntity entity);
        public Response<int> Delete(int EmployeeID);
    }
}