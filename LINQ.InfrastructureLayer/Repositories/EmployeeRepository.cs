using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;

namespace LINQ.InfrastructureLayer.Repositories
{
    public class EmployeeRepository : IEmployee
    {
        // Instantiate the BDContext
        private readonly BDNorthwindContext _context;

        public EmployeeRepository(BDNorthwindContext context)
        {
            _context = context;
        }

        public EmployeeEntity Get(int EmployeeID)
        {
            throw new NotImplementedException();
        }

        public IList<EmployeeEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(EmployeeEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(EmployeeEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int EmployeeID)
        {
            throw new NotImplementedException();
        }
    }
}