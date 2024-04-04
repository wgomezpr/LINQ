using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;

namespace LINQ.InfrastructureLayer.Repositories
{
    public class ShipperRepository : IShipper
    {
        // Instantiate the BDContext
        private readonly BDNorthwindContext _context;

        public ShipperRepository(BDNorthwindContext context)
        {
            _context = context;
        }

        public ShipperEntity Get(int ShipperID)
        {
            throw new NotImplementedException();
        }

        public IList<ShipperEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(ShipperEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ShipperEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int ShipperID)
        {
            throw new NotImplementedException();
        }
    }
}