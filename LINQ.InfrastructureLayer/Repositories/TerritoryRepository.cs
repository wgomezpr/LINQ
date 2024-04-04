using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;

namespace LINQ.InfrastructureLayer.Repositories
{
    public class TerritoryRepository : ITerritory
    {
        // Instantiate the BDContext
        private readonly BDNorthwindContext _context;

        public TerritoryRepository(BDNorthwindContext context)
        {
            _context = context;
        }

        public TerritoryEntity Get(int TerritoryID)
        {
            throw new NotImplementedException();
        }

        public IList<TerritoryEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(TerritoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(TerritoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int TerritoryID)
        {
            throw new NotImplementedException();
        }
    }
}