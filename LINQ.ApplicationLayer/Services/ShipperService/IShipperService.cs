using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;

namespace LINQ.ApplicationLayer.Services.ShipperService
{
    public interface IShipperService
    {
        public Response<ShipperEntity> Get(int ShipperID);
        public Response<IList<ShipperEntity>> GetAll();
        public Response<int> Insert(ShipperEntity entity);
        public Response<int> Update(ShipperEntity entity);
        public Response<int> Delete(int ShipperID);
    }
}