using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;

namespace LINQ.ApplicationLayer.Services.ProductService
{
    public interface IProductService
    {
        public Response<ProductEntity> Get(int ProductID);
        public Response<IList<ProductEntity>> GetAll();
        public Response<int> Insert(ProductEntity entity);
        public Response<int> Update(ProductEntity entity);
        public Response<int> Delete(int ProductID);
    }
}