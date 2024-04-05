using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using LINQ.DomainLayer.Interfaces;

namespace LINQ.ApplicationLayer.Services.EmployeeTerritoryService
{
    public class EmployeeTerritoryService : IEmployeeTerritoryService
    {
        // Instantiate the interface
        private readonly IEmployeeTerritory _repository;

        public EmployeeTerritoryService(IEmployeeTerritory repository)
        {
            _repository = repository;
        }

        public Response<EmployeeTerritoryEntity> Get(int EmployeeID)
        {
            var obj = _repository.Get(EmployeeID);
            return new Response<EmployeeTerritoryEntity>(true, obj, "OK");
        }

        public Response<IList<EmployeeTerritoryEntity>> GetAll()
        {
            var obj = _repository.GetAll();
            return new Response<IList<EmployeeTerritoryEntity>>(true, obj, "OK");
        }

        public Response<int> Insert(EmployeeTerritoryEntity entity)
        {
            var output = _repository.Insert(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Update(EmployeeTerritoryEntity entity)
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