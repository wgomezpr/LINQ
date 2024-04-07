using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;
using Microsoft.EntityFrameworkCore;

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

        public ProductEntity Get(string ProductName, int SupplierID, int CategoryID)
        {
            return _context.Products.Where(x => x.ProductName == ProductName && x.SupplierID == SupplierID && x.CategoryID == CategoryID).FirstOrDefault() ?? new ProductEntity();
        }

        public IList<ProductEntity> GetAll()
        {
            return _context.Products.ToList();
        }

        public int Insert(ProductEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.Products.Add(entity);
            _context.SaveChanges();

            return entity.ProductID;
        }

        public int Update(ProductEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Products.Update(entity);
            _context.SaveChanges();

            return entity.ProductID;
        }

        public int Delete(int ProductID)
        {
            var obj = _context.Products.First(x => x.ProductID == ProductID);
            _context.Entry(obj).State = EntityState.Deleted;
            _context.Products.Remove(obj);
            _context.SaveChanges();

            return ProductID;
        }
    }
}