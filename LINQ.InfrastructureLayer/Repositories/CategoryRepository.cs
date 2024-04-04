using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Data.Context;

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
            throw new NotImplementedException();
        }

        public IList<CategoryEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(CategoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(CategoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int CategoryID)
        {
            throw new NotImplementedException();
        }
    }
}