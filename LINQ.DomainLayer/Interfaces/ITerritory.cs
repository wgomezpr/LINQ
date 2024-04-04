using LINQ.DomainLayer.DTO.Entities;

namespace LINQ.DomainLayer.Interfaces
{
    public interface ITerritory
    {
        public TerritoryEntity Get(int TerritoryID);
        public IList<TerritoryEntity> GetAll();
        public int Insert(TerritoryEntity entity);
        public int Update(TerritoryEntity entity);
        public int Delete(int TerritoryID);
    }
}