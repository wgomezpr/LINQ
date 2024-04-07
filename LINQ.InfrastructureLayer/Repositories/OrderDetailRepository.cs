using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LINQ.InfrastructureLayer.Repositories
{
    public class OrderDetailRepository : IOrderDetail
    {
        // Instantiate the BDContext
        private readonly BDNorthwindContext _context;

        public OrderDetailRepository(BDNorthwindContext context)
        {
            _context = context;
        }

        public OrderDetailEntity Get(int OrderID)
        {
            return _context.OrderDetails.Where(x => x.OrderID == OrderID).FirstOrDefault() ?? new OrderDetailEntity();
        }

        public IList<OrderDetailEntity> GetAll()
        {
            return _context.OrderDetails.ToList();
        }

        public int Insert(OrderDetailEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.OrderDetails.Add(entity);
            _context.SaveChanges();

            return entity.OrderID;
        }

        public int Update(OrderDetailEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.OrderDetails.Update(entity);
            _context.SaveChanges();

            return entity.OrderID;
        }

        public int Delete(int OrderID)
        {
            var obj = _context.OrderDetails.First(x => x.OrderID == OrderID);

            _context.Entry(obj).State = EntityState.Deleted;
            _context.OrderDetails.Remove(obj);
            _context.SaveChanges();

            return OrderID;
        }
    }
}