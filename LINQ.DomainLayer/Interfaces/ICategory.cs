using LINQ.DomainLayer.DTO.Entities;

namespace LINQ.DomainLayer.Interfaces
{
    public interface ICategory
    {
        public CategoryEntity Get(int CategoryID);
        public IList<CategoryEntity> GetAll();
        public int Insert(CategoryEntity entity);
        public int Update(CategoryEntity entity);
        public int Delete(int CategoryID);
    }
}