using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;

namespace LINQ.InfrastructureLayer.Repositories
{
    public class RegionRepository : IRegion
    {
        // Instantiate the BDContext
        private readonly BDNorthwindContext _context;

        public RegionRepository(BDNorthwindContext context)
        {
            _context = context;
        }

        public RegionEntity Get(int RegionID)
        {
            throw new NotImplementedException();
        }

        public IList<RegionEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(RegionEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(RegionEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int RegionID)
        {
            throw new NotImplementedException();
        }
    }
}