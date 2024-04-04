using LINQ.DomainLayer.DTO.Entities;

namespace LINQ.DomainLayer.Interfaces
{
    public interface IEmployeeTerritory
    {
        public EmployeeTerritoryEntity Get(int EmployeeID);
        public IList<EmployeeTerritoryEntity> GetAll();
        public int Insert(EmployeeTerritoryEntity entity);
        public int Update(EmployeeTerritoryEntity entity);
        public int Delete(int EmployeeID);
    }
}