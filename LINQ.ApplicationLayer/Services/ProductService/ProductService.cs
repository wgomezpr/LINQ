using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using LINQ.DomainLayer.Interfaces;

namespace LINQ.ApplicationLayer.Services.ProductService
{
    public class ProductService : IProductService
    {
        // Instantiate the interface
        private readonly IProduct _repository;

        public ProductService(IProduct repository)
        {
            _repository = repository;
        }

        public Response<ProductEntity> Get(int ProductID)
        {
            try
            {
                var obj = _repository.Get(ProductID);
                if (obj.ProductID > 0)
                {
                    return new Response<ProductEntity>(true, obj, "OK");

                }
                else
                {
                    return new Response<ProductEntity>(false, null, "No se ha encontrado el producto.", 1);

                }
            }
            catch (Exception ex)
            {
                return new Response<ProductEntity>(false, null, $"Se ha producido una excepción: {ex.Message}.", 0);
            }
        }

        public Response<IList<ProductEntity>> GetAll()
        {
            try
            {
                var list = _repository.GetAll();
                return new Response<IList<ProductEntity>>(true, list, "OK");
            }
            catch (Exception ex)
            {
                return new Response<IList<ProductEntity>>(false, null, $"Se ha producido una excepción: {ex.Message}.", 0);
            }
        }

        public Response<int> Insert(ProductEntity entity)
        {
            try
            {
                var obj = _repository.Get(entity.ProductName, entity.SupplierID, entity.CategoryID);
                if (obj.ProductID == 0)
                {
                    var output = _repository.Insert(entity);
                    return new Response<int>(true, output, "OK");
                }
                else
                {
                    return new Response<int>(false, 0, "El producto ya está registrado.");
                }
            }
            catch (Exception ex)
            {
                return new Response<int>(false, 0, $"Se ha producido una excepción: {ex.Message}.", 0);
            }
        }

        public Response<int> Update(ProductEntity entity)
        {
            try
            {
                var obj = _repository.Get(entity.ProductName, entity.SupplierID, entity.CategoryID);
                if (obj.ProductID == entity.ProductID || obj.ProductID == 0)
                {
                    var output = _repository.Update(entity);
                    return new Response<int>(true, output, "OK");
                }
                else
                {
                    return new Response<int>(false, 0, "El producto ya está registrado.");
                }
            }
            catch (Exception ex)
            {
                return new Response<int>(false, 0, $"Se ha producido una excepción: {ex.Message}.", 0);
            }
        }

        public Response<int> Delete(int ProductID)
        {
            try
            {
                var output = _repository.Delete(ProductID);
                return new Response<int>(true, output, "El producto se ha eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return new Response<int>(false, 0, $"Se ha producido una excepción: {ex.Message}.", 0);
            }
        }
    }
}