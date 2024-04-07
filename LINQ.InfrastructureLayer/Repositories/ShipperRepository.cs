using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;
using Microsoft.EntityFrameworkCore;

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
            return _context.Shippers.Where(x => x.ShipperID == ShipperID).FirstOrDefault() ?? new ShipperEntity();
        }

        public IList<ShipperEntity> GetAll()
        {
            return _context.Shippers.ToList();
        }

        public int Insert(ShipperEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.Shippers.Add(entity);
            _context.SaveChanges();

            return entity.ShipperID;
        }

        public int Update(ShipperEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Shippers.Update(entity);
            _context.SaveChanges();

            return entity.ShipperID;
        }

        public int Delete(int ShipperID)
        {
            var obj = _context.Shippers.First(x => x.ShipperID == ShipperID);

            _context.Entry(obj).State = EntityState.Deleted;
            _context.Shippers.Remove(obj);
            _context.SaveChanges();

            return ShipperID;
        }
    }
}