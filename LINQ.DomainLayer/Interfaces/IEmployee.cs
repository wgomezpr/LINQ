using LINQ.DomainLayer.DTO.Entities;

namespace LINQ.DomainLayer.Interfaces
{
    public interface IEmployee
    {
        public EmployeeEntity Get(int EmployeeID);
        public IList<EmployeeEntity> GetAll();
        public int Insert(EmployeeEntity entity);
        public int Update(EmployeeEntity entity);
        public int Delete(int EmployeeID);
    }
}