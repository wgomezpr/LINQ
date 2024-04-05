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
            var obj = _repository.Get(ProductID);
            return new Response<ProductEntity>(true, obj, "OK");
        }

        public Response<IList<ProductEntity>> GetAll()
        {
            var obj = _repository.GetAll();
            return new Response<IList<ProductEntity>>(true, obj, "OK");
        }

        public Response<int> Insert(ProductEntity entity)
        {
            var output = _repository.Insert(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Update(ProductEntity entity)
        {
            var output = _repository.Update(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Delete(int ProductID)
        {
            var output = _repository.Delete(ProductID);
            return new Response<int>(true, output, "OK");
        }
    }
}