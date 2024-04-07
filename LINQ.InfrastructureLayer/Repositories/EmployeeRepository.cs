using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LINQ.InfrastructureLayer.Repositories
{
    public class EmployeeRepository : IEmployee
    {
        // Instantiate the BDContext
        private readonly BDNorthwindContext _context;

        public EmployeeRepository(BDNorthwindContext context)
        {
            _context = context;
        }

        public EmployeeEntity Get(int EmployeeID)
        {
            return _context.Employees.Where(x => x.EmployeeID == EmployeeID).FirstOrDefault() ?? new EmployeeEntity();
        }

        public IList<EmployeeEntity> GetAll()
        {
            return _context.Employees.ToList();
        }

        public int Insert(EmployeeEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.Employees.Add(entity);
            _context.SaveChanges();

            return entity.EmployeeID;
        }

        public int Update(EmployeeEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Employees.Update(entity);
            _context.SaveChanges();

            return entity.EmployeeID;
        }

        public int Delete(int EmployeeID)
        {
            var obj = _context.Employees.First(x => x.EmployeeID == EmployeeID);

            _context.Entry(obj).State = EntityState.Deleted;
            _context.Employees.Remove(obj);
            _context.SaveChanges();

            return EmployeeID;
        }
    }
}