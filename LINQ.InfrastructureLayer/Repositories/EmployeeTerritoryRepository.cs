using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;

namespace LINQ.InfrastructureLayer.Repositories
{
    public class EmployeeTerritoryRepository : IEmployeeTerritory
    {
        // Instantiate the BDContext
        private readonly BDNorthwindContext _context;

        public EmployeeTerritoryRepository(BDNorthwindContext context)
        {
            _context = context;
        }

        public EmployeeTerritoryEntity Get(int EmployeeID)
        {
            throw new NotImplementedException();
        }

        public IList<EmployeeTerritoryEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(EmployeeTerritoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(EmployeeTerritoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int EmployeeID)
        {
            throw new NotImplementedException();
        }
    }
}