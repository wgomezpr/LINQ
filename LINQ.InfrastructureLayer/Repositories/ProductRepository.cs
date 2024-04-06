using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;

namespace LINQ.InfrastructureLayer.Repositories
{
    public class ProductRepository : IProduct
    {
        // Instantiate the BDContext
        private readonly BDNorthwindContext _context;

        public ProductRepository(BDNorthwindContext context)
        {
            _context = context;
        }

        public ProductEntity Get(int ProductID)
        {
           return _context.Products.Where(x => x.ProductID == ProductID).FirstOrDefault() ?? new ProductEntity();
        }

        public IList<ProductEntity> GetAll()
        {
            return _context.Products.ToList();
        }

        public int Insert(ProductEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int ProductID)
        {
            throw new NotImplementedException();
        }
    }
}