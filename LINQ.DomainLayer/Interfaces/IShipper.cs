using LINQ.DomainLayer.DTO.Entities;

namespace LINQ.DomainLayer.Interfaces
{
    public interface IShipper
    {
        public ShipperEntity Get(int ShipperID);
        public IList<ShipperEntity> GetAll();
        public int Insert(ShipperEntity entity);
        public int Update(ShipperEntity entity);
        public int Delete(int ShipperID);
    }
}