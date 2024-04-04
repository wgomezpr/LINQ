using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;

namespace LINQ.InfrastructureLayer.Repositories
{
    public class CustomerRepository : ICustomer
    {
        // Instantiate the BDContext
        private readonly BDNorthwindContext _context;

        public CustomerRepository(BDNorthwindContext context)
        {
            _context = context;
        }

        public CustomerEntity Get(int CustomerID)
        {
            throw new NotImplementedException();
        }

        public IList<CustomerEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(CustomerEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(CustomerEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int CustomerID)
        {
            throw new NotImplementedException();
        }
    }
}