using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;
using Microsoft.EntityFrameworkCore;

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
            return _context.Territories.Where(x => x.TerritoryID == TerritoryID).FirstOrDefault() ?? new TerritoryEntity();
        }

        public IList<TerritoryEntity> GetAll()
        {
            return _context.Territories.ToList();
        }

        public int Insert(TerritoryEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.Territories.Add(entity);
            _context.SaveChanges();

            return entity.TerritoryID;
        }

        public int Update(TerritoryEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Territories.Update(entity);
            _context.SaveChanges();

            return entity.TerritoryID;
        }

        public int Delete(int TerritoryID)
        {
            var obj = _context.Territories.First(x => x.TerritoryID == TerritoryID);

            _context.Entry(obj).State = EntityState.Deleted;
            _context.Territories.Remove(obj);
            _context.SaveChanges();

            return TerritoryID;
        }
    }
}