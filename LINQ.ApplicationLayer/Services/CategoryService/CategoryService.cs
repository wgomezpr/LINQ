using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using LINQ.DomainLayer.Interfaces;

namespace LINQ.ApplicationLayer.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        // Instantiate the interface
        private readonly ICategory _repository;

        public CategoryService(ICategory repository)
        {
            _repository = repository;
        }

        public Response<CategoryEntity> Get(int CategoryID)
        {
            var obj = _repository.Get(CategoryID);
            return new Response<CategoryEntity>(true, obj, "OK");
        }

        public Response<IList<CategoryEntity>> GetAll()
        {
            var obj = _repository.GetAll();
            return new Response<IList<CategoryEntity>>(true, obj, "OK");
        }

        public Response<int> Insert(CategoryEntity entity)
        {
            var output = _repository.Insert(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Update(CategoryEntity entity)
        {
            var output = _repository.Update(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Delete(int CategoryID)
        {
            var output = _repository.Delete(CategoryID);
            return new Response<int>(true, output, "OK");
        }
    }
}