using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;

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
            throw new NotImplementedException();
        }

        public IList<OrderEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(OrderEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(OrderEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int OrderID)
        {
            throw new NotImplementedException();
        }
    }
}