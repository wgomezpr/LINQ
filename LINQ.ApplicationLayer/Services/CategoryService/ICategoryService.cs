using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;

namespace LINQ.ApplicationLayer.Services.CategoryService
{
    public interface ICategoryService
    {
        public Response<CategoryEntity> Get(int CategoryID);
        public Response<IList<CategoryEntity>> GetAll();
        public Response<int> Insert(CategoryEntity entity);
        public Response<int> Update(CategoryEntity entity);
        public Response<int> Delete(int CategoryID);
    }
}