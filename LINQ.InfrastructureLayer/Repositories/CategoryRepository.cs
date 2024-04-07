using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LINQ.InfrastructureLayer.Repositories
{
    public class CategoryRepository : ICategory
    {
        // Instantiate the BDContext
        private readonly BDNorthwindContext _context;

        public CategoryRepository(BDNorthwindContext context)
        {
            _context = context;
        }

        public CategoryEntity Get(int CategoryID)
        {
            return _context.Categories.Where(x => x.CategoryID == CategoryID).FirstOrDefault() ?? new CategoryEntity();
        }

        public CategoryEntity GetByName(string CategoryName)
        {
            return _context.Categories.Where(x => x.CategoryName.Contains(CategoryName)).FirstOrDefault() ?? new CategoryEntity();
        }

        public IList<CategoryEntity> GetAll()
        {
            return _context.Categories.ToList();
        }

        public int Insert(CategoryEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.Categories.Add(entity);
            _context.SaveChanges();

            return entity.CategoryID;
        }

        public int Update(CategoryEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Categories.Update(entity);
            _context.SaveChanges();

            return entity.CategoryID;
        }

        public int Delete(int CategoryID)
        {
            var obj = _context.Categories.First(x => x.CategoryID == CategoryID);

            _context.Entry(obj).State = EntityState.Deleted;
            _context.Categories.Remove(obj);
            _context.SaveChanges();

            return CategoryID;
        }
    }
}