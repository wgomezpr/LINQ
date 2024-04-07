using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LINQ.InfrastructureLayer.Repositories
{
    public class OrderRepository : IOrder
    {
        // Instantiate the BDContext
        private readonly BDNorthwindContext _context;

        public OrderRepository(BDNorthwindContext context)
        {
            _context = context;
        }

        public OrderEntity Get(int OrderID)
        {
            return _context.Orders.Where(x => x.OrderID == OrderID).FirstOrDefault() ?? new OrderEntity();
        }

        public IList<OrderEntity> GetAll()
        {
            return _context.Orders.ToList();
        }

        public int Insert(OrderEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.Orders.Add(entity);
            _context.SaveChanges();

            return entity.OrderID;
        }

        public int Update(OrderEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Orders.Update(entity);
            _context.SaveChanges();

            return entity.OrderID;
        }

        public int Delete(int OrderID)
        {
            var obj = _context.Orders.First(x => x.OrderID == OrderID);

            _context.Entry(obj).State = EntityState.Deleted;
            _context.Orders.Remove(obj);
            _context.SaveChanges();

            return OrderID;
        }
    }
}