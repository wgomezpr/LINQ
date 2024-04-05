using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;

namespace LINQ.ApplicationLayer.Services.SupplierService
{
    public interface ISupplierService
    {
        public Response<SupplierEntity> Get(int SupplierID);
        public Response<IList<SupplierEntity>> GetAll();
        public Response<int> Insert(SupplierEntity entity);
        public Response<int> Update(SupplierEntity entity);
        public Response<int> Delete(int SupplierID);
    }
}