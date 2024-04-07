using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;
using Microsoft.EntityFrameworkCore;

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
            return _context.Regions.Where(x => x.RegionID == RegionID).FirstOrDefault() ?? new RegionEntity();
        }

        public IList<RegionEntity> GetAll()
        {
            return _context.Regions.ToList();
        }

        public int Insert(RegionEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.Regions.Add(entity);
            _context.SaveChanges();

            return entity.RegionID;
        }

        public int Update(RegionEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Regions.Update(entity);
            _context.SaveChanges();

            return entity.RegionID;
        }

        public int Delete(int RegionID)
        {
            var obj = _context.Regions.First(x => x.RegionID == RegionID);

            _context.Entry(obj).State = EntityState.Deleted;
            _context.Regions.Remove(obj);
            _context.SaveChanges();

            return RegionID;
        }
    }
}