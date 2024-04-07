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
            try
            {
                var obj = _repository.Get(CategoryID);
                if (obj.CategoryID > 0)
                {
                    return new Response<CategoryEntity>(true, obj, "OK");

                }
                else
                {
                    return new Response<CategoryEntity>(false, null, "No se ha encontrado la categoría.", 1);

                }
            }
            catch (Exception ex)
            {
                return new Response<CategoryEntity>(false, null, $"Se ha producido una excepción: {ex.Message}.", 0);
            }
        }

        public Response<IList<CategoryEntity>> GetAll()
        {
            try
            {
                var list = _repository.GetAll();
                return new Response<IList<CategoryEntity>>(true, list, "OK");
            }
            catch (Exception ex)
            {
                return new Response<IList<CategoryEntity>>(false, null, $"Se ha producido una excepción: {ex.Message}.", 0);
            }
        }

        public Response<int> Insert(CategoryEntity entity)
        {
            try
            {
                var obj = _repository.GetByName(entity.CategoryName);
                if (obj.CategoryID == 0)
                {
                    var output = _repository.Insert(entity);
                    return new Response<int>(true, output, "OK");
                }
                else
                {
                    return new Response<int>(false, 0, "La categoría ya está registrada.");
                }
            }
            catch (Exception ex)
            {
                return new Response<int>(false, 0, $"Se ha producido una excepción: {ex.Message}.", 0);
            }
        }

        public Response<int> Update(CategoryEntity entity)
        {
            try
            {
                var obj = _repository.GetByName(entity.CategoryName);
                if (obj.CategoryID == entity.CategoryID || obj.CategoryID == 0)
                {
                    var output = _repository.Update(entity);
                    return new Response<int>(true, output, "OK");
                }
                else
                {
                    return new Response<int>(false, 0, "La categoría ya está registrada.");
                }
            }
            catch (Exception ex)
            {
                return new Response<int>(false, 0, $"Se ha producido una excepción: {ex.Message}.", 0);
            }
        }

        public Response<int> Delete(int CategoryID)
        {
            try
            {
                var output = _repository.Delete(CategoryID);
                return new Response<int>(true, output, "La categoría se ha eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return new Response<int>(false, 0, $"Se ha producido una excepción: {ex.Message}.", 0);
            }
        }
    }
}