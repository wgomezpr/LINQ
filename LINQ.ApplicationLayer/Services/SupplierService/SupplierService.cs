using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using LINQ.DomainLayer.Interfaces;

namespace LINQ.ApplicationLayer.Services.SupplierService
{
    public class SupplierService : ISupplierService
    {
        // Instantiate the interface
        private readonly ISupplier _repository;

        public SupplierService(ISupplier repository)
        {
            _repository = repository;
        }

        public Response<SupplierEntity> Get(int SupplierID)
        {
            var obj = _repository.Get(SupplierID);
            return new Response<SupplierEntity>(true, obj, "OK");
        }

        public Response<IList<SupplierEntity>> GetAll()
        {
            var obj = _repository.GetAll();
            return new Response<IList<SupplierEntity>>(true, obj, "OK");
        }

        public Response<int> Insert(SupplierEntity entity)
        {
            var output = _repository.Insert(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Update(SupplierEntity entity)
        {
            var output = _repository.Update(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Delete(int SupplierID)
        {
            var output = _repository.Delete(SupplierID);
            return new Response<int>(true, output, "OK");
        }
    }
}