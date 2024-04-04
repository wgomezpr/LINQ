using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;

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
            throw new NotImplementedException();
        }

        public IList<OrderDetailEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(OrderDetailEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(OrderDetailEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int OrderID)
        {
            throw new NotImplementedException();
        }
    }
}