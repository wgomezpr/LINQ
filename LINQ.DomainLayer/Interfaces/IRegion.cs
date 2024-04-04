using LINQ.DomainLayer.DTO.Entities;

namespace LINQ.DomainLayer.Interfaces
{
    public interface IRegion
    {
        public RegionEntity Get(int RegionID);
        public IList<RegionEntity> GetAll();
        public int Insert(RegionEntity entity);
        public int Update(RegionEntity entity);
        public int Delete(int RegionID);
    }
}