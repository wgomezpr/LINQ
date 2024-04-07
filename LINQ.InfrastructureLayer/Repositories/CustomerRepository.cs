using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LINQ.InfrastructureLayer.Repositories
{
    public class CustomerRepository : ICustomer
    {
        // Instantiate the BDContext
        private readonly BDNorthwindContext _context;

        public CustomerRepository(BDNorthwindContext context)
        {
            _context = context;
        }

        public CustomerEntity Get(int CustomerID)
        {
            return _context.Customers.Where(x => x.CustomerID == CustomerID).FirstOrDefault() ?? new CustomerEntity();
        }

        public IList<CustomerEntity> GetAll()
        {
            return _context.Customers.ToList();
        }

        public int Insert(CustomerEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.Customers.Add(entity);
            _context.SaveChanges();

            return entity.CustomerID;
        }

        public int Update(CustomerEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Customers.Update(entity);
            _context.SaveChanges();

            return entity.CustomerID;
        }

        public int Delete(int CustomerID)
        {
            var obj = _context.Customers.First(x => x.CustomerID == CustomerID);

            _context.Entry(obj).State = EntityState.Deleted;
            _context.Customers.Remove(obj);
            _context.SaveChanges();

            return CustomerID;
        }
    }
}