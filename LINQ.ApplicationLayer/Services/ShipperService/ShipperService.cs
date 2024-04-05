using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using LINQ.DomainLayer.Interfaces;

namespace LINQ.ApplicationLayer.Services.ShipperService
{
    public class ShipperService : IShipperService
    {
        // Instantiate the interface
        private readonly IShipper _repository;

        public ShipperService(IShipper repository)
        {
            _repository = repository;
        }

        public Response<ShipperEntity> Get(int ShipperID)
        {
            var obj = _repository.Get(ShipperID);
            return new Response<ShipperEntity>(true, obj, "OK");
        }

        public Response<IList<ShipperEntity>> GetAll()
        {
            var obj = _repository.GetAll();
            return new Response<IList<ShipperEntity>>(true, obj, "OK");
        }

        public Response<int> Insert(ShipperEntity entity)
        {
            var output = _repository.Insert(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Update(ShipperEntity entity)
        {
            var output = _repository.Update(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Delete(int ShipperID)
        {
            var output = _repository.Delete(ShipperID);
            return new Response<int>(true, output, "OK");
        }
    }
}