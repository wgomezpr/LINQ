using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;
using Microsoft.EntityFrameworkCore;

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
            return _context.Suppliers.Where(x => x.SupplierID == SupplierID).FirstOrDefault() ?? new SupplierEntity();
        }

        public IList<SupplierEntity> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public int Insert(SupplierEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.Suppliers.Add(entity);
            _context.SaveChanges();

            return entity.SupplierID;
        }

        public int Update(SupplierEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Suppliers.Update(entity);
            _context.SaveChanges();

            return entity.SupplierID;
        }

        public int Delete(int SupplierID)
        {
            var obj = _context.Suppliers.First(x => x.SupplierID == SupplierID);

            _context.Entry(obj).State = EntityState.Deleted;
            _context.Suppliers.Remove(obj);
            _context.SaveChanges();

            return SupplierID;
        }
    }
}