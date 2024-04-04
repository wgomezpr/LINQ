using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;

namespace LINQ.InfrastructureLayer.Repositories
{
    public class SupplierRepository : ISupplier
    {
        // Instantiate the BDContext
        private readonly BDNorthwindContext _context;

        public SupplierRepository(BDNorthwindContext context)
        {
            _context = context;
        }

        public SupplierEntity Get(int SupplierID)
        {
            throw new NotImplementedException();
        }

        public IList<SupplierEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(SupplierEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(SupplierEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int SupplierID)
        {
            throw new NotImplementedException();
        }
    }
}