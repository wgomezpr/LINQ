using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LINQ.InfrastructureLayer.Repositories
{
    public class EmployeeTerritoryRepository : IEmployeeTerritory
    {
        // Instantiate the BDContext
        private readonly BDNorthwindContext _context;

        public EmployeeTerritoryRepository(BDNorthwindContext context)
        {
            _context = context;
        }

        public EmployeeTerritoryEntity Get(int EmployeeID)
        {
            return _context.EmployeeTerritories.Where(x => x.EmployeeID == EmployeeID).FirstOrDefault() ?? new EmployeeTerritoryEntity();
        }

        public IList<EmployeeTerritoryEntity> GetAll()
        {
            return _context.EmployeeTerritories.ToList();
        }

        public int Insert(EmployeeTerritoryEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.EmployeeTerritories.Add(entity);
            _context.SaveChanges();

            return entity.EmployeeID;
        }

        public int Update(EmployeeTerritoryEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.EmployeeTerritories.Update(entity);
            _context.SaveChanges();

            return entity.EmployeeID;
        }

        public int Delete(int EmployeeID)
        {
            var obj = _context.EmployeeTerritories.First(x => x.EmployeeID == EmployeeID);

            _context.Entry(obj).State = EntityState.Deleted;
            _context.EmployeeTerritories.Remove(obj);
            _context.SaveChanges();

            return EmployeeID;
        }
    }
}